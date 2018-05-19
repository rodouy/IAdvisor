USE master;  
GO  

ALTER DATABASE IrrigationAdvisor
SET SINGLE_USER WITH
ROLLBACK IMMEDIATE

RESTORE DATABASE IrrigationAdvisor 
  FROM DISK = 'C:\Projects\Database\Backup\IrrigationAdvisor.Bak'
  WITH REPLACE