@echo off
SETLOCAL ENABLEDELAYEDEXPANSION
SET LinkName=BASTA
SET BaseTargetPath=%%HOMEDRIVE%%\Program Files\Amped FIVE
SET TargetName=five
SET IconName=five300
SET Esc_LinkDest=%%HOMEDRIVE%%%%HOMEPATH%%\Desktop\!LinkName!.lnk
SET Esc_LinkTarget=!BaseTargetPath!\bin32\!TargetName!.EXE
SET Esc_IconLocation=!BaseTargetPath!\fivedata\img\!IconName!.ICO
SET cSctVBS=CreateShortcut.vbs
SET LOG=".\%~N0_runtime.log"
((
  echo Set oWS = WScript.CreateObject^("WScript.Shell"^) 
  echo sLinkFile = oWS.ExpandEnvironmentStrings^("!Esc_LinkDest!"^)
  echo Set oLink = oWS.CreateShortcut^(sLinkFile^) 
  echo oLink.TargetPath = oWS.ExpandEnvironmentStrings^("!Esc_LinkTarget!"^)
  echo oLink.IconLocation = oWS.ExpandEnvironmentStrings^("!Esc_IconLocation!"^)
  echo oLink.Save
)1>!cSctVBS!
cscript //nologo .\!cSctVBS!
DEL !cSctVBS! /f /q
)1>>!LOG! 2>>&1