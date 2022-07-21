; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "PoliceInfo"
#define MyAppVersion "1.0"
#define MyAppPublisher "��ɽ��¡�����Ʊ��Ƽ����޹�˾"
#define MyAppExeName "PoliceInfo.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (�����µ�GUID����� ����|��IDE������GUID��)
AppId={{0897C52B-6459-47B3-9D14-8DF73F269C71}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=C:\Users\Admin\Desktop
OutputBaseFilename=Setup
SetupIconFile=I:\PoliceInfo\image\ti.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\PoliceInfo.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\DAL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\data.db"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\ICSharpCode.SharpZipLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\Models.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\NPOI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\NPOI.OOXML.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\NPOI.OOXML.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\NPOI.OpenXml4Net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\NPOI.OpenXml4Net.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\NPOI.OpenXmlFormats.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\NPOI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\PoliceInfo.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\PoliceInfo.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\PoliceInfo.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\PoliceInfo.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\PoliceInfo.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\System.Data.SQLite.dll.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "I:\PoliceInfo\PoliceInfo\bin\Debug\System.Data.SQLite.xml"; DestDir: "{app}"; Flags: ignoreversion 
Source: "I:\PoliceInfo\image\ti.ico"; DestDir: "{app}"; Flags: ignoreversion 
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{userappdata}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; 
Name: "{userdesktop}\ʩ���ع����־��������Σ��Ա���ݿ�";Filename: "{app}\{#MyAppExeName}";IconFilename: "{app}\ti.ico" 



[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

