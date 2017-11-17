USE "IrrigationAdvisor-DEMO";  
GO  

ALTER DATABASE "IrrigationAdvisor-DEMO" 
MODIFY FILE
    (NAME = "IrrigationAdvisor-DEMO",
    SIZE = 100MB);
GO

ALTER DATABASE "IrrigationAdvisor-DEMO" 
MODIFY FILE
    (NAME = "IrrigationAdvisor-DEMO_log",
    SIZE = 600MB);
GO

BACKUP DATABASE "IrrigationAdvisor-DEMO"  
TO DISK = 'E:\MSSQL\Backup\IrrigationAdvisor-DEMO.Bak'  
   WITH FORMAT,  
      MEDIANAME = 'Z_SQLServerBackups',  
      NAME = 'Full Backup of IrrigationAdvisor-DEMO';  
GO  

