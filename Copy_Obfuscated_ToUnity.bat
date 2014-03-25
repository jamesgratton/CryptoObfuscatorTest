@echo off

del Unity\Assets\bin\*.dll

copy /Y Publish\Obfuscated\SimpleClassLibrary.dll Unity\Assets\bin\Obfuscated.dll
copy /Y Publish\Obfuscated\EntryScript.cs Unity\Assets\Scripts\EntryScript.cs

echo.
echo Copied Obfuscated to Unity
echo.

pause