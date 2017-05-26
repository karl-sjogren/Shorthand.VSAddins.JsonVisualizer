!include "WordFunc.nsh"
!insertmacro VersionConvert
!insertmacro VersionCompare

Function CheckVersion
    Pop $8 ;Version
    Pop $9 ;Id
    DetailPrint "Letar efter en nyare version av installationsprogrammet"
    Push "http://installcenter.shorthand.se/InstallCenter.ashx/getversion/$9"
    Call ReadFromUrl

    Pop $0
    DetailPrint "Senaste versionen är $0"
    ${VersionConvert} $0 "" $R0
    ${VersionCompare} $R0 $8 $R2
    StrCmp $R2 1 0 End
    DetailPrint "En nyare version finns tillgänglig"
    MessageBox MB_YESNO "En nyare version av detta installationsprogram (version $0) finns tillgänlig, ska den installeras istället?" /SD IDNO IDNO End

    Push "http://installcenter.shorthand.se/InstallCenter.ashx/getdownloadurl/$9"
    Call ReadFromUrl
    Pop $0

    inetc::get /caption "Laddar ner nytt installationsprogram" /popup "http://www.shorthand.se/" /canceltext "Avbryt" $0 "$TEMP\$9.exe" /end
    Pop $1
    StrCmp $1 "OK" 0 Error
    
    ExecWait "$TEMP\$9.exe"
    Delete "$TEMP\$9.exe"

    Quit
    Error:
    End:
FunctionEnd

!macro ReadFromUrl un
  Function ${un}ReadFromUrl
    Pop $0
    GetTempFilename $1
    inetc::get /silent /timeout 2000 $0 $1 /end
    Pop $0
    StrCmp $0 "OK" 0 Error
    FileOpen $0 $1 "r"
    IfErrors Error
    FileRead $0 $1
    FileClose $0
    Push $1
    Goto End
    Error:
    Push ""
    End:
  FunctionEnd
!macroend
!insertmacro ReadFromUrl ""
!insertmacro ReadFromUrl "un."

!macro InstallCenterPost
  WriteRegStr HKCU "Software\Shorthand Software\Shorthand Install Center\${PRODUCT_NAME}" "Version" "${PRODUCT_LONGVERSION}"
  WriteRegStr HKCU "Software\Shorthand Software\Shorthand Install Center\${PRODUCT_NAME}" "InstallPath" "$INSTDIR"
  WriteRegStr HKCU "Software\Shorthand Software\Shorthand Install Center\${PRODUCT_NAME}" "Uninstaller" "$INSTDIR\uninst.exe"
  WriteRegStr HKCU "Software\Shorthand Software\Shorthand Install Center\${PRODUCT_NAME}" "InstallCenterId" "${INSTALLCENTER_ID}"

  Push "http://installcenter.shorthand.se/InstallCenter.ashx/addinstallation/${INSTALLCENTER_ID}"
  Call ReadFromUrl
  Pop $0
  
  IfSilent 0 +2
  Exec "$INSTDIR\${PRODUCT_EXENAME}"
!macroend

!macro InstallCenterUninstall
  DeleteRegKey HKCU "Software\Shorthand Software\Shorthand Install Center\${PRODUCT_NAME}"

  Push "http://installcenter.shorthand.se/InstallCenter.ashx/adduninstallation/${INSTALLCENTER_ID}"
  Call un.ReadFromUrl
  Pop $0
!macroend

!macro InstallCenterOnInit
  IfSilent AfterSplash

  Push ${INSTALLCENTER_ID}
  Push ${PRODUCT_LONGVERSION}
  Call CheckVersion

  ReadRegStr $0 HKCU "Software\Shorthand Software\Shorthand Install Center\${PRODUCT_NAME}" "InstallPath"
  StrCmp $0 "" +2 0
  StrCpy $INSTDIR $0

  Goto NotSilent
  AfterSplash:
  Sleep 3000
  NotSilent:
!macroend

;!insertmacro IfKeyExists "ROOT" "KeyToCheckIn" "KeyToCheck"
;Pop $R0
;$R0 contains 0 (not present) or 1 (present)
!macro IfKeyExists ROOT MAIN_KEY KEY
  Push $R0
  Push $R1
  Push $R2
 
  # XXX bug if ${ROOT}, ${MAIN_KEY} or ${KEY} use $R0 or $R1
 
  StrCpy $R1 "0" # loop index
  StrCpy $R2 "0" # not found
 
  ${Do}
    EnumRegKey $R0 ${ROOT} "${MAIN_KEY}" "$R1"
    ${If} $R0 == "${KEY}"
      StrCpy $R2 "1" # found
      ${Break}
    ${EndIf}
    IntOp $R1 $R1 + 1
  ${LoopWhile} $R0 != ""
 
  ClearErrors
 
  Exch 2
  Pop $R0
  Pop $R1
  Exch $R2
!macroend

!macro InstallCenterMUISettings
  !define MUI_ABORTWARNING
  !define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"
  !define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"
  !define MUI_HEADERIMAGE_BITMAP "HeaderImage.bmp"
  !define MUI_HEADERIMAGE
  !define MUI_WELCOMEFINISHPAGE_BITMAP "WelcomeFinishPage.bmp"
  !define MUI_UNWELCOMEFINISHPAGE_BITMAP "WelcomeFinishPage.bmp"
  !define MUI_COMPONENTSPAGE_NODESC
!macroend

!macro InstallCenterSettings
  Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
  OutFile "${PRODUCT_SETUPNAME}-Setup-${PRODUCT_VERSION}.exe"
  InstallDir "$PROGRAMFILES\${PRODUCT_PUBLISHER}\${PRODUCT_NAME}"
  InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
  ShowInstDetails show
  ShowUnInstDetails show
  BrandingText "${PRODUCT_PUBLISHER} using NSIS ${NSIS_VERSION}"
  RequestExecutionLevel admin

  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "${PRODUCT_NAME}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "${PRODUCT_PUBLISHER}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "Copyright © 2008-2012 ${PRODUCT_PUBLISHER}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "${PRODUCT_NAME}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "${PRODUCT_VERSION}"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductVersion" "${PRODUCT_VERSION}"

VIProductVersion "${PRODUCT_LONGVERSION}"
!macroend