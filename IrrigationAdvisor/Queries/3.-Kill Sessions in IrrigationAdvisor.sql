USE [master]
GO  

select db_id('IrrigationAdvisor')
GO

/* SQL Server 2008
DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('IrrigationAdvisor')

EXEC(@kill);
*/
USE master  
GO  

DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), spid) + ';'  
FROM master..sysprocesses  
WHERE dbid = db_id('IrrigationAdvisor')

EXEC(@kill); 

select *
FROM sys.dm_exec_sessions