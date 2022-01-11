@echo off
c:\xampp\mysql\bin\mysqldump --user=root --password= --result-file="c:\flotabackup.sql" flota
echo Export is completed!
exit
