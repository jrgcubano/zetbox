#!/bin/bash -e

echo '********************************************************************************'
echo 'generate new business objects from the database'
echo '********************************************************************************'

mono --debug bin/Debug/Kistl.Server.Service.exe Configs/$zenv/Kistl.Server.Service.xml -generate

echo '********************************************************************************'
echo '************************************ Success ***********************************'
echo '********************************************************************************'