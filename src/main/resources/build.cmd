@echo off
if not exist target mkdir target
if not exist target\classes mkdir target\classes


echo compile classes
javac -nowarn -d target\classes -sourcepath jvm -cp "d:\fpt\jni4net-0.8.8.0-bin\lib\jni4net.j-0.8.8.0.jar"; "jvm\fptframework/outhouse/security\LibEncryption.java" 
IF %ERRORLEVEL% NEQ 0 goto end


echo FptFramework.OutHouse.Security.j4n.jar 
jar cvf FptFramework.OutHouse.Security.j4n.jar  -C target\classes "fptframework\outhouse\security\LibEncryption.class"  > nul 
IF %ERRORLEVEL% NEQ 0 goto end


echo FptFramework.OutHouse.Security.j4n.dll 
csc /nologo /warn:0 /t:library /out:FptFramework.OutHouse.Security.j4n.dll /recurse:clr\*.cs  /reference:"D:\FPT\FPT.Hospital.Business\externalDll\FptFramework.OutHouse.Security.dll" /reference:"D:\FPT\jni4net-0.8.8.0-bin\lib\jni4net.n-0.8.8.0.dll"
IF %ERRORLEVEL% NEQ 0 goto end


:end
