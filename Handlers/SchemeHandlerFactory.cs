namespace BudgetExecution
{
    using CefSharp;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CefSharp.ISchemeHandlerFactory" />
    internal class SchemeHandlerFactory : ISchemeHandlerFactory
    {
        /// <summary>
        /// Creates the specified browser.
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <param name="frame">The frame.</param>
        /// <param name="schemeName">Name of the scheme.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public IResourceHandler Create( IBrowser browser, IFrame frame, string schemeName,
            IRequest request )
        {
            return new SchemeHandler( WebBrowser.Instance );
        }
    }
}