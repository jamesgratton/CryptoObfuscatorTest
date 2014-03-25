@echo off

del Unity\Assets\bin\*.dll

copy /Y Publish\UnObfuscated\SimpleClassLibrary.dll Unity\Assets\bin\UnObfuscated.dll
copy /Y Publish\UnObfuscated\EntryScript.cs Unity\Assets\Scripts\EntryScript.cs

echo.
echo Copied UnObfuscated to Unity
echo.

pause