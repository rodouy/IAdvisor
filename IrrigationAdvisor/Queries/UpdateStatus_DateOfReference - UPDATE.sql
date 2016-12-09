
Use IrrigationAdvisor

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

UPDATE  dbo.Status
SET     DateOfReference = GETDATE()
WHERE  Name = 'Production';

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

Use [IrrigationAdvisor-DEMO]

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

UPDATE  dbo.Status
SET     DateOfReference = GETDATE()
WHERE   Name = 'Demo';

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

