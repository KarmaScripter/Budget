UPDATE FullTimeEquivalents
    INNER JOIN ResourcePlanningOffices
ON FullTimeEquivalents.RpioCode = ResourcePlanningOffices.Code
    SET FullTimeEquivalents.RpioName = ResourcePlanningOffices.Name;