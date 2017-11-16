USE master;  
GO  

ALTER DATABASE IrrigationAdvisor
SET SINGLE_USER WITH
ROLLBACK IMMEDIATE

RESTORE DATABASE IrrigationAdvisor 
  FROM DISK = 'E:\MSSQL\Backup\IrrigationAdvisor-DEMO.Bak'
  WITH REPLACE,
  MOVE 'IrrigationAdvisor-DEMO' TO 'F:\MSSQL\Data\IrrigationAdvisor\IrrigationAdvisor.mdf',
  MOVE 'IrrigationAdvisor-DEMO_log' TO 'F:\MSSQL\Data\IrrigationAdvisor\IrrigationAdvisor_log.ldf';
  

ALTER DATABASE [IrrigationAdvisor] MODIFY FILE ( NAME = "IrrigationAdvisor-DEMO", NEWNAME = IrrigationAdvisor );
GO
ALTER DATABASE [IrrigationAdvisor] MODIFY FILE ( NAME = "IrrigationAdvisor-DEMO_log", NEWNAME = IrrigationAdvisor_log );
GO