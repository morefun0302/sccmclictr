﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientCenter.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>CcmExec</string>
  <string>WinRM</string>
  <string>wuauserv</string>
  <string>LanmanWorkstation</string>
  <string>LanmanServer</string>
  <string>RemoteRegistry</string>
  <string>BITS</string>
  <string>CmRcService</string>
  <string>Winmgmt</string>
  <string>PeerDistSvc</string>
  <string>smstsmgr</string>
  <string>RpcSs</string>
  <string>ccmsetup</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ServicesHighlited {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ServicesHighlited"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Username {
            get {
                return ((string)(this["Username"]));
            }
            set {
                this["Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string DefaultHostName {
            get {
                return ((string)(this["DefaultHostName"]));
            }
            set {
                this["DefaultHostName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"$a = 0
$timespan = New-Object System.TimeSpan(0, 0, 1)
$scope = New-Object System.Management.ManagementScope(""\\.\root\ccm\Events"")
$query = New-Object System.Management.WQLEventQuery(""CCM_Event"", $timespan)
$watcher = New-Object System.Management.ManagementEventWatcher($scope,$query)
do 
    {
        $b = $watcher.WaitForNextEvent()
        $b
    } 
while ($a -ne 1)")]
        public string PSEventQuery {
            get {
                return ((string)(this["PSEventQuery"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>%systemroot%\\system32\\actxprxy.dll</string>\r\n  <string>%systemroot%\\system" +
            "32\\atl.dll</string>\r\n  <string>%systemroot%\\system32\\Bitsprx2.dll</string>\r\n  <s" +
            "tring>%systemroot%\\system32\\Bitsprx3.dll</string>\r\n  <string>%systemroot%\\system" +
            "32\\browseui.dll</string>\r\n  <string>%systemroot%\\system32\\cryptdlg.dll</string>\r" +
            "\n  <string>%systemroot%\\system32\\dssenh.dll</string>\r\n  <string>%systemroot%\\sys" +
            "tem32\\gpkcsp.dll</string>\r\n  <string>%systemroot%\\system32\\initpki.dll</string>\r" +
            "\n  <string>%systemroot%\\system32\\jscript.dll</string>\r\n  <string>%systemroot%\\sy" +
            "stem32\\mshtml.dll</string>\r\n  <string>%systemroot%\\system32\\msi.dll</string>\r\n  " +
            "<string>%systemroot%\\system32\\mssip32.dll</string>\r\n  <string>%systemroot%\\syste" +
            "m32\\msxml.dll</string>\r\n  <string>%systemroot%\\system32\\msxml3.dll</string>\r\n  <" +
            "string>%systemroot%\\system32\\msxml3a.dll</string>\r\n  <string>%systemroot%\\system" +
            "32\\msxml3r.dll</string>\r\n  <string>%systemroot%\\system32\\msxml4.dll</string>\r\n  " +
            "<string>%systemroot%\\system32\\msxml4a.dll</string>\r\n  <string>%systemroot%\\syste" +
            "m32\\msxml4r.dll</string>\r\n  <string>%systemroot%\\system32\\msxml6.dll</string>\r\n " +
            " <string>%systemroot%\\system32\\msxml6r.dll</string>\r\n  <string>%systemroot%\\syst" +
            "em32\\muweb.dll</string>\r\n  <string>%systemroot%\\system32\\ole32.dll</string>\r\n  <" +
            "string>%systemroot%\\system32\\oleaut32.dll</string>\r\n  <string>%systemroot%\\syste" +
            "m32\\Qmgr.dll</string>\r\n  <string>%systemroot%\\system32\\Qmgrprxy.dll</string>\r\n  " +
            "<string>%systemroot%\\system32\\rsaenh.dll</string>\r\n  <string>%systemroot%\\system" +
            "32\\sccbase.dll</string>\r\n  <string>%systemroot%\\system32\\scrrun.dll</string>\r\n  " +
            "<string>%systemroot%\\system32\\shdocvw.dll</string>\r\n  <string>%systemroot%\\syste" +
            "m32\\shell32.dll</string>\r\n  <string>%systemroot%\\system32\\slbcsp.dll</string>\r\n " +
            " <string>%systemroot%\\system32\\softpub.dll</string>\r\n  <string>%systemroot%\\syst" +
            "em32\\urlmon.dll</string>\r\n  <string>%systemroot%\\system32\\userenv.dll</string>\r\n" +
            "  <string>%systemroot%\\system32\\vbscript.dll</string>\r\n  <string>%systemroot%\\sy" +
            "stem32\\Winhttp.dll</string>\r\n  <string>%systemroot%\\system32\\wintrust.dll</strin" +
            "g>\r\n  <string>%systemroot%\\system32\\wuapi.dll</string>\r\n  <string>%systemroot%\\s" +
            "ystem32\\wuaueng.dll</string>\r\n  <string>%systemroot%\\system32\\wuaueng1.dll</stri" +
            "ng>\r\n  <string>%systemroot%\\system32\\wucltui.dll</string>\r\n  <string>%systemroot" +
            "%\\system32\\wucltux.dll</string>\r\n  <string>%systemroot%\\system32\\wups.dll</strin" +
            "g>\r\n  <string>%systemroot%\\system32\\wups2.dll</string>\r\n  <string>%systemroot%\\s" +
            "ystem32\\wuweb.dll</string>\r\n  <string>%systemroot%\\system32\\wuwebv.dll</string>\r" +
            "\n  <string>%systemroot%\\system32\\wbem\\wmisvc.dll</string>\r\n  <string>%systemroot" +
            "%\\system32\\Xpob2res.dll</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection RegisterDLLs {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RegisterDLLs"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("O:BAG:BAD:(A;;CCDCSW;;;WD)(A;;CCDCLCSWRP;;;BA)(A;;CCDCLCSWRP;;;LU)(A;;CCDCLCSWRP;" +
            ";;S-1-5-32-562)")]
        public string MachineLaunchRestriction {
            get {
                return ((string)(this["MachineLaunchRestriction"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("O:BAG:BAD:(A;;CCDCLC;;;WD)(A;;CCDCLC;;;LU)(A;;CCDCLC;;;S-1-5-32-562)(A;;CCDCLC;;;" +
            "AN)")]
        public string MachineAccessRestriction {
            get {
                return ((string)(this["MachineAccessRestriction"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("O:BAG:BAD:(A;;CCDCLCSWRP;;;SY)(A;;CCDCLCSWRP;;;BA)(A;;CCDCLCSWRP;;;IU)")]
        public string DefaultLaunchPermission {
            get {
                return ((string)(this["DefaultLaunchPermission"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool NoLocalAdminCheck {
            get {
                return ((bool)(this["NoLocalAdminCheck"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5985")]
        public string WinRMPort {
            get {
                return ((string)(this["WinRMPort"]));
            }
            set {
                this["WinRMPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WinRMSSL {
            get {
                return ((bool)(this["WinRMSSL"]));
            }
            set {
                this["WinRMSSL"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>Password</string>\r\n  <string>PWD</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection CollectionVariablesFilter {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["CollectionVariablesFilter"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>OS Architecture|root\cimv2|SELECT VariableValue FROM  Win32_Environment WHERE Name='PROCESSOR_ARCHITECTURE' AND UserName='&lt;SYSTEM&gt;'</string>
  <string>PC Manufacturer|root\cimv2|SELECT Manufacturer FROM Win32_ComputerSystem</string>
  <string>LastHWInv|Root\CCM\Scheduler|SELECT LastTriggerTime FROM CCM_Scheduler_History WHERE ScheduleID='{00000000-0000-0000-0000-000000000001}' and UserSID='Machine'</string>
  <string>LastSWInv|Root\CCM\Scheduler|SELECT LastTriggerTime FROM CCM_Scheduler_History WHERE ScheduleID='{00000000-0000-0000-0000-000000000002}' and UserSID='Machine'</string>
  <string>LastDDR|Root\CCM\Scheduler|SELECT LastTriggerTime FROM CCM_Scheduler_History WHERE ScheduleID='{00000000-0000-0000-0000-000000000003}' and UserSID='Machine'</string>
  <string>LastMachinePolicyRequest|Root\CCM\Scheduler|SELECT LastTriggerTime FROM CCM_Scheduler_History WHERE ScheduleID='{00000000-0000-0000-0000-000000000021}' and UserSID='Machine'</string>
  <string>LastReboot|root\cimv2|SELECT LastBootUpTime FROM Win32_OperatingSystem</string>
  <string>InstallDate|root\cimv2|SELECT InstallDate FROM Win32_OperatingSystem</string>
  <string>CurrentUser|root\cimv2|SELECT Username FROM Win32_ComputerSystem</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AdhocInv {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AdhocInv"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>127.0.0.1</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection recentlyUsedComputers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["recentlyUsedComputers"]));
            }
            set {
                this["recentlyUsedComputers"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool showPingButton {
            get {
                return ((bool)(this["showPingButton"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AgentInstallSiteCode {
            get {
                return ((string)(this["AgentInstallSiteCode"]));
            }
            set {
                this["AgentInstallSiteCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AgentInstallMP {
            get {
                return ((string)(this["AgentInstallMP"]));
            }
            set {
                this["AgentInstallMP"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$CM12MP = \'Management Point FQDN\' \r\n$CMSiteCode = \'xxx\'  \r\n\r\n$ErrorActionPreferen" +
            "ce = \"SilentlyContinue\" \r\n\r\n#Only migrate non CM12 Agents \r\nif(([wmi]\"ROOT\\ccm:S" +
            "MS_Client=@\").ClientVersion.StartsWith(\'5.\')) \r\n{ \r\n    \"Already migrated...\" \r\n" +
            "    exit 0 \r\n} \r\n\r\ntry \r\n{ \r\n#Get ccm cache path for later cleanup... \r\n    try " +
            "\r\n    { \r\n        $ccmcache = ([wmi]\"ROOT\\ccm\\SoftMgmtAgent:CacheConfig.ConfigKe" +
            "y=\'Cache\'\").Location \r\n    } catch {} \r\n\r\n#download ccmsetup.exe from MP \r\n    $" +
            "webclient = New-Object System.Net.WebClient \r\n    $url = \"http://$($CM12MP)/CCM_" +
            "Client/ccmsetup.exe\" \r\n    $file = \"c:\\windows\\temp\\ccmsetup.exe\" \r\n    $webclie" +
            "nt.DownloadFile($url,$file) \r\n\r\n#stop the old sms agent service \r\n    stop-servi" +
            "ce \'ccmexec\' -ErrorAction SilentlyContinue \r\n\r\n#Cleanup cache \r\n    if($ccmcache" +
            " -ne $null) \r\n    { \r\n        try \r\n        { \r\n        dir $ccmcache \'*\' -direc" +
            "tory | % { [io.directory]::delete($_.fullname, $true)  } -ErrorAction SilentlyCo" +
            "ntinue \r\n        } catch {} \r\n    } \r\n\r\n#Cleanup Execution History \r\n    Remove-" +
            "Item -Path \'HKLM:\\SOFTWARE\\Wow6432Node\\Microsoft\\SMS\\Mobile Client\\*\' -Recurse -" +
            "ErrorAction SilentlyContinue \r\n\r\n#Cleanup App-V 4.6 Packages \r\n    try \r\n    { \r" +
            "\n        (get-wmiobject -query \"SELECT * FROM Package WHERE SftPath like \'%\' AND" +
            " InUse = \'FALSE\' \" -namespace \"root\\Microsoft\\appvirt\\client\") | % { start-proce" +
            "ss -wait sftmime.exe -argumentlist \"delete package:$([char]34)$($_.Name)$([char]" +
            "34) /global\" }         \r\n    } catch {} \r\n\r\n#kill existing instances of ccmsetup" +
            ".exe \r\n    $ccm = (Get-Process \'ccmsetup\' -ErrorAction SilentlyContinue) \r\n    i" +
            "f($ccm -ne $null) \r\n    { \r\n            $ccm.kill(); \r\n    } \r\n\r\n#run ccmsetup \r" +
            "\n    $proc = Start-Process -FilePath \'c:\\windows\\temp\\ccmsetup.exe\' -PassThru -W" +
            "ait -ArgumentList \"/mp:$($CM12MP) /source:http://$($CM12MP)/CCM_Client CCMHTTPPO" +
            "RT=80 RESETKEYINFORMATION=TRUE SMSSITECODE=$($CMSiteCode) SMSSLP=$($CM12MP) FSP=" +
            "$($CM12MP)\" \r\n   Sleep(5) \r\n   \"ccmsetup started...\" \r\n} \r\n\r\ncatch \r\n{ \r\n       " +
            " \"an Error occured...\" \r\n        $error[0] \r\n} ")]
        public string AgentInstallPS {
            get {
                return ((string)(this["AgentInstallPS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HideTSAdvertisements {
            get {
                return ((bool)(this["HideTSAdvertisements"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideNonUserUIExperienceApplicattions {
            get {
                return ((bool)(this["HideNonUserUIExperienceApplicattions"]));
            }
        }
    }
}
