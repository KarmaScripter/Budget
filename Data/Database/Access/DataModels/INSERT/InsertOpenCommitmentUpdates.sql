INSERT INTO OpenCommitments
(ObligationsId,
 BFY,
 EFY,
 RpioCode,
 RpioName,
 AhCode,
 AhName,
 FundCode,
 FundName,
 OrgCode,
 OrgName,
 AccountCode,
 ProgramProjectCode,
 ProgramProjectName,
 RcCode,
 RcName,
 DocumentType,
 DocumentNumber,
 DocumentControlNumber,
 ReferenceDocumentNumber,
 ProcessedDate,
 LastActivityDate,
 Age,
 BocCode,
 BocName,
 FocCode,
 FocName,
 NpmCode,
 NpmName,
 VendorCode,
 VendorName,
 Amount)
SELECT DISTINCT ObligationsId,
                BFY,
                EFY,
                RpioCode,
                RpioName,
                AhCode,
                AhName,
                FundCode,
                FundName,
                OrgCode,
                OrgName,
                AccountCode,
                ProgramProjectCode,
                ProgramProjectName,
                RcCode,
                RcName,
                DocumentType,
                DocumentNumber,
                DocumentControlNumber,
                ReferenceDocumentNumber,
                ProcessedDate,
                LastActivityDate,
                Age,
                BocCode,
                BocName,
                FocCode,
                FocName,
                NpmCode,
                NpmName,
                VendorCode,
                VendorName,
                OpenCommitments AS Amount
FROM Obligations
WHERE OpenCommitments > 0
ORDER BY BFY DESC;