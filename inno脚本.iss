; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "PoliceInfo"
#define MyAppVersion "1.0"
#define MyAppPublisher "保山市隆阳区云豹科技有限公司"
#define MyAppExeName "PoliceInfo.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
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
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{userappdata}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; 
Name: "{userdesktop}\施甸县公安分局涉黑涉恶高危人员数据库";Filename: "{app}\{#MyAppExeName}";IconFilename: "{app}\ti.ico" 



[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

