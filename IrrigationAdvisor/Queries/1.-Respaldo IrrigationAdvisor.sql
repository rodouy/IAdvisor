USE "IrrigationAdvisor";  
GO  
BACKUP DATABASE "IrrigationAdvisor"  
TO DISK = 'E:\MSSQL\Backup\IrrigationAdvisor.Bak'  
   WITH FORMAT,  
      MEDIANAME = 'Z_SQLServerBackups',  
      NAME = 'Full Backup of IrrigationAdvisor';  
GO  