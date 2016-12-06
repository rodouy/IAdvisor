

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

UPDATE  dbo.Status
SET     DateOfReference = GETDATE()
WHERE   Name = 'Demo';
  --Name = 'Production';

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

