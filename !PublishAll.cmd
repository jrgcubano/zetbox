@echo off
cd Kistl.Server
bin\Debug\Kistl.Server.exe -generate -updateschema -repairschema
bin\debug\Kistl.Server.exe -publish Database\Database.xml *
pause
