

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

UPDATE  dbo.Status
SET     DateOfReference = GETDATE()
WHERE   Name = 'Demo';
 --'Production';

SELECT  * ,
        GETDATE()
FROM    dbo.Status;

