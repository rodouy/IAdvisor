USE "IrrigationAdvisor";  
GO  
BACKUP DATABASE "IrrigationAdvisor"  
TO DISK = 'C:\Projects\Database\Backup\IrrigationAdvisor.Bak'  
   WITH FORMAT,  
      MEDIANAME = 'C_SQLServerBackups',  
      NAME = 'Full Backup of IrrigationAdvisor';  
GO  