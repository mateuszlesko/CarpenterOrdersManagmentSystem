CREATE DATABASE carpenter_orders;
GO
USE carpenter_orders;
GO
CREATE LOGIN admin WITH PASSWORD = 'P@ssword', CHECK_POLICY = ON;
GO
CREATE USER admin FOR LOGIN admin;
GO
ALTER ROLE db_owner ADD MEMBER [admin];
GO