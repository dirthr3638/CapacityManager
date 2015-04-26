using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;

namespace CapacityManager
{
    class InitialChecker
    {

        public InitialChecker()
        {

        }

        //레지스트리에서 윈7이상일 경우 접근일자 플래그를 갱신하고  explorer를 재시작함
        public void UpdateRegistAccessDate()
        {
            
            OperatingSystem os = Environment.OSVersion;
            Version version = os.Version;
            //윈vista 이상일경우
            if (version.Major > 5)
            {
                const string regRoot = @"SYSTEM\ControlSet001\Control\";
                const string setting = regRoot + @"FileSystem";
                RegistryKey reg = Registry.LocalMachine;
                reg = reg.OpenSubKey(setting, true);
                int Value = Convert.ToInt32(reg.GetValue("NtfsDisableLastAccessUpdate"));

                if (Value != 0)
                {
                    reg.SetValue("NtfsDisableLastAccessUpdate", 0, RegistryValueKind.DWord);
                    ProcessControl pc = new ProcessControl();
                    pc.ResetExplorer();
                }
            }
        }

        //환경설정을 저장하는 폴더를 체크하고 없을시 기본값 세팅
        //해당 레지스트리가 0일 경우에만 엑세스데이타가 활성화됨
        public void CheckOptionFile()
        {
            string appFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CapacitySetting";
            DirectoryInfo dir = new DirectoryInfo(appFolder);
            if (dir.Exists == false)
            {
                dir.Create();
            }
            
        }





    }
}
