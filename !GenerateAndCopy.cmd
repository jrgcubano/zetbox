@echo off
echo ********************************************************************************
echo Only Generating and Publish
echo Used if only frozen objects has changed
echo ********************************************************************************

bin\Debug\Kistl.Server.Service.exe Configs\%zenv%\Kistl.Server.Service.xml -generate
IF ERRORLEVEL 1 GOTO FAIL

rem refresh local code
call GetCodeGen.cmd
IF ERRORLEVEL 1 GOTO FAIL

bin\debug\Kistl.Server.Service.exe Configs\%zenv%\Kistl.Server.Service.xml -publish Kistl.Server\Database\Database.xml
IF ERRORLEVEL 1 GOTO FAIL

bin\debug\Kistl.Server.Service.exe Configs\%zenv%\Kistl.Server.Service.xml -publish Kistl.Server\Database\KistlBase.xml -ownermodules KistlBase;GUI
IF ERRORLEVEL 1 GOTO FAIL

echo ********************************************************************************
echo ************************************ Success ***********************************
echo ********************************************************************************
GOTO EOF

:FAIL
echo ********************************************************************************
echo ************************************* FAIL *************************************
echo ********************************************************************************
echo Aborting reset.

:EOF
pause