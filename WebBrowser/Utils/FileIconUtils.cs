// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-01-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="FileIconUtils.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   FileIconUtils.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using Microsoft.Win32;
    using System.Reflection;
    using System.Collections.Generic;
    using System.IO;
    using System.Drawing.Imaging;

    /// <summary>
    /// Two constants extracted from the FileInfoFlags, the only that are
    /// meaningful for the user of this class.
    /// </summary>
    public enum FileIconSize
    {
        Large = 0x000000000,

        Small = 0x000000001
    }

    public static class FileIconUtils
    {
        // TOP LEVEL API

        public static MemoryStream GetFileIcon( string name, FileIconSize size )
        {
            var icon = FileIconUtils.IconFromExtension( name.GetAfter( "." ), size );

            using( icon )
            {
                using( var bmp = icon.ToBitmap( ) )
                {
                    var ms = new MemoryStream( );
                    bmp.Save( ms, ImageFormat.Png );
                    ms.Seek( 0, SeekOrigin.Begin );
                    return ms;
                }
            }
        }

        public class IconNotFoundException : Exception
        {
            public IconNotFoundException( string fileName, int index )
                : base( string.Format( "Icon with Id = {0} wasn't found in file {1}", index,
                    fileName ) )
            {
            }
        }

        public class UnableToExtractIconsException : Exception
        {
            public UnableToExtractIconsException( string fileName, int firstIconIndex,
                int iconCount )
                : base( string.Format(
                    "Tried to extract {2} icons starting from the one with id {1} from the \"{0}\" file but failed",
                    fileName, firstIconIndex, iconCount ) )
            {
            }
        }

        public static void ExtractEx( string fileName, List<Icon> largeIcons, List<Icon> smallIcons,
            int firstIconIndex, int iconCount )
        {
            /*
             * Memory allocations
             */
            IntPtr[ ] smallIconsPtrs = null;
            IntPtr[ ] largeIconsPtrs = null;

            if( smallIcons != null )
            {
                smallIconsPtrs = new IntPtr[ iconCount ];
            }

            if( largeIcons != null )
            {
                largeIconsPtrs = new IntPtr[ iconCount ];
            }

            /*
             * Call to native Win32 API
             */

            var apiResult = FileIconUtils.ExtractIconEx( fileName, firstIconIndex, largeIconsPtrs,
                smallIconsPtrs, iconCount );

            if( apiResult != iconCount )
            {
                throw new UnableToExtractIconsException( fileName, firstIconIndex, iconCount );
            }

            /*
             * Fill lists
             */

            if( smallIcons != null )
            {
                smallIcons.Clear( );

                foreach( var actualIconPtr in smallIconsPtrs )
                {
                    smallIcons.Add( Icon.FromHandle( actualIconPtr ) );
                }
            }

            if( largeIcons != null )
            {
                largeIcons.Clear( );

                foreach( var actualIconPtr in largeIconsPtrs )
                {
                    largeIcons.Add( Icon.FromHandle( actualIconPtr ) );
                }
            }
        }

        public static List<Icon> ExtractEx( string fileName, FileIconSize size, int firstIconIndex,
            int iconCount )
        {
            var iconList = new List<Icon>( );

            switch( size )
            {
                case FileIconSize.Large:

                    FileIconUtils.ExtractEx( fileName, iconList, null, firstIconIndex, iconCount );
                    break;
                case FileIconSize.Small:

                    FileIconUtils.ExtractEx( fileName, null, iconList, firstIconIndex, iconCount );
                    break;
                default:

                    throw new ArgumentOutOfRangeException( "size" );
            }

            return iconList;
        }

        public static void Extract( string fileName, List<Icon> largeIcons, List<Icon> smallIcons )
        {
            var iconCount = FileIconUtils.GetIconsCountInFile( fileName );
            FileIconUtils.ExtractEx( fileName, largeIcons, smallIcons, 0, iconCount );
        }

        public static List<Icon> Extract( string fileName, FileIconSize size )
        {
            var iconCount = FileIconUtils.GetIconsCountInFile( fileName );
            return FileIconUtils.ExtractEx( fileName, size, 0, iconCount );
        }

        public static Icon ExtractOne( string fileName, int index, FileIconSize size )
        {
            try
            {
                var iconList = FileIconUtils.ExtractEx( fileName, size, index, 1 );
                return iconList[ 0 ];
            }
            catch( UnableToExtractIconsException )
            {
                throw new IconNotFoundException( fileName, index );
            }
        }

        public static void ExtractOne( string fileName, int index, out Icon largeIcon,
            out Icon smallIcon )
        {
            var smallIconList = new List<Icon>( );
            var largeIconList = new List<Icon>( );

            try
            {
                FileIconUtils.ExtractEx( fileName, largeIconList, smallIconList, index, 1 );
                largeIcon = largeIconList[ 0 ];
                smallIcon = smallIconList[ 0 ];
            }
            catch( UnableToExtractIconsException )
            {
                throw new IconNotFoundException( fileName, index );
            }
        }

        //this will look throw the registry 
        //to find if the Extension have an icon.
        public static Icon IconFromExtension( string extension, FileIconSize size )
        {
            // Add the '.' to the extension if needed
            if( extension[ 0 ] != '.' )
            {
                extension = '.' + extension;
            }

            extension = extension.ToLower( );

            //opens the registry for the wanted key.
            var Root = Registry.ClassesRoot;
            var ExtensionKey = Root.OpenSubKey( extension );
            ExtensionKey.GetValueNames( );
            var ApplicationKey = Root.OpenSubKey( ExtensionKey.GetValue( "" ).ToString( ) );

            //gets the name of the file that have the icon.
            var IconLocation =
                ApplicationKey.OpenSubKey( "DefaultIcon" ).GetValue( "" ).ToString( );

            var IconPath = IconLocation.Split( ',' );
            IconPath[ 1 ] ??= "0";
            IntPtr[ ] Large = new IntPtr[ 1 ], Small = new IntPtr[ 1 ];

            //extracts the icon from the file.
            FileIconUtils.ExtractIconEx( IconPath[ 0 ], Convert.ToInt16( IconPath[ 1 ] ), Large,
                Small, 1 );

            return size == FileIconSize.Large
                ? Icon.FromHandle( Large[ 0 ] )
                : Icon.FromHandle( Small[ 0 ] );
        }

        /// <summary>
        /// Parse strings in registry who contains the name of the icon and
        /// the index of the icon an return both parts.
        /// </summary>
        /// <param name="regString">The full string in the form "path,index" as found in registry.</param>
        /// <param name="fileName">The "path" part of the string.</param>
        /// <param name="index">The "index" part of the string.</param>
        public static void ExtractInformationsFromRegistryString( string regString,
            out string fileName, out int index )
        {
            if( regString == null )
            {
                throw new ArgumentNullException( "regString" );
            }

            if( regString.Length == 0 )
            {
                throw new ArgumentException( "The string should not be empty.", "regString" );
            }

            index = 0;
            var strArr = regString.Replace( "\"", "" ).Split( ',' );
            fileName = strArr[ 0 ].Trim( );

            if( strArr.Length > 1 )
            {
                int.TryParse( strArr[ 1 ].Trim( ), out index );
            }
        }

        /// <summary>
        /// Contains information about a file object. 
        /// </summary>
        private struct SHFILEINFO
        {
            /// <summary>
            /// Array of values that indicates the attributes of the file object.
            /// For information about these values, see the IShellFolder::GetAttributesOf
            /// method.
            /// </summary>
            public uint dwAttributes;

            /// <summary>
            /// Handle to the icon that represents the file. You are responsible for
            /// destroying this handle with DestroyIcon when you no longer need it. 
            /// </summary>
            public IntPtr hIcon;

            /// <summary>
            /// Index of the icon image within the system image list.
            /// </summary>
            public IntPtr iIcon;

            /// <summary>
            /// String that contains the name of the file as it appears in the Microsoft
            /// Windows Shell, or the path and file name of the file that contains the
            /// icon representing the file.
            /// </summary>
            [ MarshalAs( UnmanagedType.ByValTStr, SizeConst = 260 ) ]
            public string szDisplayName;

            /// <summary>
            /// String that describes the type of file.
            /// </summary>
            [ MarshalAs( UnmanagedType.ByValTStr, SizeConst = 80 ) ]
            public string szTypeName;
        };

        [ Flags ]
        private enum FileInfoFlags
        {
            /// <summary>
            /// Retrieve the handle to the icon that represents the file and the index 
            /// of the icon within the system image list. The handle is copied to the 
            /// hIcon member of the structure specified by psfi, and the index is copied 
            /// to the iIcon member.
            /// </summary>
            SHGFI_ICON = 0x000000100,

            /// <summary>
            /// Indicates that the function should not attempt to access the file 
            /// specified by pszPath. Rather, it should act as if the file specified by 
            /// pszPath exists with the file attributes passed in dwFileAttributes.
            /// </summary>
            SHGFI_USEFILEATTRIBUTES = 0x000000010
        }

        /// <summary>
        ///     Creates an array of handles to large or small icons extracted from
        ///     the specified executable file, dynamic-link library (DLL), or icon
        ///     file. 
        /// </summary>
        /// <param name="lpszFile">
        ///     Name of an executable file, DLL, or icon file from which icons will
        ///     be extracted.
        /// </param>
        /// <param name="nIconIndex">
        ///     <para>
        ///         Specifies the zero-based index of the first icon to extract. For
        ///         example, if this value is zero, the function extracts the first
        ///         icon in the specified file.
        ///     </para>
        ///     <para>
        ///         If this value is �1 and <paramref name="phiconLarge"/> and
        ///         <paramref name="phiconSmall"/> are both NULL, the function returns
        ///         the total number of icons in the specified file. If the file is an
        ///         executable file or DLL, the return value is the number of
        ///         RT_GROUP_ICON resources. If the file is an .ico file, the return
        ///         value is 1. 
        ///     </para>
        ///     <para>
        ///         Windows 95/98/Me, Windows NT 4.0 and later: If this value is a 
        ///         negative number and either <paramref name="phiconLarge"/> or 
        ///         <paramref name="phiconSmall"/> is not NULL, the function begins by
        ///         extracting the icon whose resource identifier is equal to the
        ///         absolute value of <paramref name="nIconIndex"/>. For example, use -3
        ///         to extract the icon whose resource identifier is 3. 
        ///     </para>
        /// </param>
        /// <param name="phIconLarge">
        ///     An array of icon handles that receives handles to the large icons
        ///     extracted from the file. If this parameter is NULL, no large icons
        ///     are extracted from the file.
        /// </param>
        /// <param name="phIconSmall">
        ///     An array of icon handles that receives handles to the small icons
        ///     extracted from the file. If this parameter is NULL, no small icons
        ///     are extracted from the file. 
        /// </param>
        /// <param name="nIcons">
        ///     Specifies the number of icons to extract from the file. 
        /// </param>
        /// <returns>
        ///     If the <paramref name="nIconIndex"/> parameter is -1, the
        ///     <paramref name="phIconLarge"/> parameter is NULL, and the
        ///     <paramref name="phiconSmall"/> parameter is NULL, then the return
        ///     value is the number of icons contained in the specified file.
        ///     Otherwise, the return value is the number of icons successfully
        ///     extracted from the file. 
        /// </returns>
        [ DllImport( "Shell32", CharSet = CharSet.Auto ) ]
        private static extern int ExtractIconEx(
            [ MarshalAs( UnmanagedType.LPTStr ) ] string lpszFile, int nIconIndex,
            IntPtr[ ] phIconLarge, IntPtr[ ] phIconSmall, int nIcons );

        [ DllImport( "Shell32", CharSet = CharSet.Auto ) ]
        private static extern IntPtr SHGetFileInfo( string pszPath, int dwFileAttributes,
            out SHFILEINFO psfi, int cbFileInfo, FileInfoFlags uFlags );

        /// <summary>
        /// Get the number of icons in the specified file.
        /// </summary>
        /// <param name="fileName">Full path of the file to look for.</param>
        /// <returns></returns>
        private static int GetIconsCountInFile( string fileName )
        {
            return FileIconUtils.ExtractIconEx( fileName, -1, null, null, 0 );
        }
    }
}