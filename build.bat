mkdir .\bin

echo Starting DotNet Compiler
cd .\csharp
dotnet publish /p:NativeLib=Shared /p:SelfContained=true -r win-x64 -c release
cd ..\
echo C# Compiled!

echo Starting GCC
gcc main.c -o .\bin\test.exe -L.\csharp\bin\Release\net5.0\win-x64\publish\ -lSharpCode
echo C Compiled!

echo Copying Libraries
xcopy /y /d .\csharp\bin\Release\net5.0\win-x64\publish\SharpCode.dll .\bin\
echo Libraries copied!

echo Starting
echo --------------------------------
.\bin\test.exe
