; Script generated with the Venis Install Wizard

; Define your application name
!define APPNAME "Proportion Calc"
!define APPNAMEANDVERSION "Proportion Calc 0.2"

; Main Install settings
Unicode true
Name "${APPNAMEANDVERSION}"
InstallDir "$PROGRAMFILES\PropCalc"
InstallDirRegKey HKLM "Software\${APPNAME}" ""
OutFile "Output\propcalc_setup.exe"

DirText "Choose the folder in which to install ${APPNAMEANDVERSION}."

ShowInstDetails show

Section "Proportion Calc"

	; Set Section properties
	SectionIn RO
	SetOverwrite on

	; Set Section Files and Shortcuts
	SetOutPath "$INSTDIR\"
	File "bin\PropCalc.exe"
	
	MessageBox MB_YESNO "Create shortcut on Desktop?" IDNO NoCreate
	CreateShortCut "$DESKTOP\Proportion Calc.lnk" "$INSTDIR\PropCalc.exe"
	
	NoCreate:
	CreateDirectory "$SMPROGRAMS\Proportion Calc"
	CreateShortCut "$SMPROGRAMS\Proportion Calc\Proportion Calc.lnk" "$INSTDIR\PropCalc.exe"
	CreateShortCut "$SMPROGRAMS\Proportion Calc\Uninstall.lnk" "$INSTDIR\uninstall.exe"

SectionEnd

Section -FinishSection

	WriteRegStr HKLM "Software\${APPNAME}" "" "$INSTDIR"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "DisplayName" "${APPNAME}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "UninstallString" "$INSTDIR\uninstall.exe"
	WriteUninstaller "$INSTDIR\uninstall.exe"

SectionEnd

;Uninstall section
Section Uninstall

	SetDetailsView show
	;Remove from registry...
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}"
	DeleteRegKey HKLM "SOFTWARE\${APPNAME}"

	; Delete self
	Delete "$INSTDIR\uninstall.exe"

	; Delete Shortcuts
	Delete "$DESKTOP\Proportion Calc.lnk"
	Delete "$SMPROGRAMS\Proportion Calc\Proportion Calc.lnk"
	Delete "$SMPROGRAMS\Proportion Calc\Uninstall.lnk"

	; Clean up Proportion Calc
	Delete "$INSTDIR\PropCalc.exe"

	; Remove remaining directories
	RMDir "$SMPROGRAMS\Proportion Calc"
	RMDir "$INSTDIR\"

SectionEnd

Function un.onInit

	MessageBox MB_YESNO|MB_DEFBUTTON2|MB_ICONQUESTION "Remove ${APPNAMEANDVERSION} and all of its components?" IDYES DoUninstall
		Abort
	DoUninstall:

FunctionEnd

; eof