UPDATE PayrollActivity
    INNER JOIN ProgramProjectDescriptions
ON ProgramProjectDescriptions.ProgramProjectCode = PayrollActivity.ProgramProjectCode
    SET PayrollActivity.ProgramAreaCode = ProgramProjectDescriptions.ProgramAreaCode
WHERE PayrollActivity.ProgramProjectCode = ProgramProjectDescriptions.ProgramProjectCode;