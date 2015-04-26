using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


    class SettingController
    {

        //public EXT_KIND exKind;
        private string iniPath;
        private const string iniName = "Setting.ini";
        private IniStructure iniController;
        public static int Lastday = 7;
        public static ArrayList InitMovieList = new ArrayList{
                                ".avi"
                                ,".divx"
                                ,".wmx"
                                ,".wmv"
                                ,".mpg"
                                ,".mpeg"
                                ,".mp4"
                                ,".flv"
                                ,".mkv"
                                };
        public static ArrayList InitDocList = new ArrayList{
                                ".doc"
                                ,".docx"
                                ,".xls"
                                ,".xlsx"
                                ,".ppt"
                                ,".pptx"
                                ,".hwp"
                                ,".pdf"
                                };
        public static ArrayList InitImageList = new ArrayList{
                                 ".jpg"
                                ,".jpeg"
                                ,".bmp"
                                ,".gif"
                                };
        public static ArrayList InitEtcList = new ArrayList
        {
                                };
        public static ArrayList ExceptFolder = new ArrayList{
                                 "Windows"
                                 ,"Program"
                                 };

        public ArrayList MovieList;
        public ArrayList ImageList;
        public ArrayList DocList;
        public ArrayList EtcList;
        public ArrayList SystemList;
        public int LastDay
        {
            get;
            set;
        }
        public string TargetFolder
        {
            get;
            set;
        }

        private static SettingController scInstance;

        /*  Creator
         *  Ini파일이 있는지 확인한다
         *      Ini파일이 없을시 기본 세팅으로 설정하여 저장해준다
         *  Ini파일의 세팅값에 맞추어 속성값을 Setting하여준다
         *  
        */
        private SettingController()
        {
            MovieList = new ArrayList();
            DocList = new ArrayList();
            ImageList = new ArrayList();
            EtcList = new ArrayList();
            SystemList = new ArrayList();


            LastDay = 0;
            iniPath = GetAppDataPath() + ("\\") + GetMyProgramName() + ("\\");
            iniController = new IniStructure();

            if(!CheckIni())
                SaveIniValue(InitMovieList,InitImageList, InitDocList, InitEtcList, ExceptFolder, "7");
            SettingOptionFromIni();
        }

        public string GetMyProgramName()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        }

        private bool CheckIni()
        {
            if (!Directory.Exists(iniPath))
            {
                Directory.CreateDirectory(iniPath);
                return false;
            }
            else
                if (File.Exists(iniPath + iniName))
                    return true;
            
            return false;

        }

        public void SaveIniValue
            (ArrayList MovieList,ArrayList ImageList, ArrayList DocList, ArrayList EtcList, ArrayList SystemList, string Date)
        {
            iniController.DeleteCategory("Movie");
            iniController.DeleteCategory("Image");
            iniController.DeleteCategory("Doc");
            iniController.DeleteCategory("Etc");
            iniController.DeleteCategory("System");
            iniController.DeleteCategory("Date");
            
            iniController.AddCategory("Movie");
            iniController.AddCategory("Image");
            iniController.AddCategory("Doc");
            iniController.AddCategory("Etc");
            iniController.AddCategory("System");
            iniController.AddCategory("Date");

            int i = 1;

            foreach (string a in MovieList)
            {
                iniController.AddValue("Movie", i.ToString(), a);
                i++;
            }
            i = 1;
            foreach (string a in ImageList)
            {
                iniController.AddValue("Image", i.ToString(), a);
                i++;
            }
            i = 1;
            foreach (string a in DocList)
            {
                iniController.AddValue("Doc", i.ToString(), a);
                i++;
            }
            i = 1;
            foreach (string a in EtcList)
            {
                iniController.AddValue("Etc", i.ToString(), a);
                i++;
            }
            i = 1;
            foreach (string a in SystemList)
            {
                iniController.AddValue("System", i.ToString(), a);
                i++;
            }
            i = 1;
            iniController.AddValue("Date", i.ToString(), Date);

           
            IniStructure.WriteIni(iniController, iniPath + iniName);
        }

        public void SettingOptionFromIni()
        {
            iniController = IniStructure.ReadIni(iniPath + iniName);
            ClearListView();

            for (int i = 1; ; i++)
            {
                string s = iniController.GetValue("Movie", i.ToString());
                if (s == null)
                    break;
                if(!MovieList.Contains(s))
                    MovieList.Add(s);
            }
            for (int i = 1; ; i++)
            {
                string s = iniController.GetValue("Image", i.ToString());
                if (s == null)
                    break;
                if (!ImageList.Contains(s))
                    ImageList.Add(s);
            }
            for (int i = 1; ; i++)
            {
                string s = iniController.GetValue("Doc", i.ToString());
                if (s == null)
                    break;
                if (!DocList.Contains(s))
                    DocList.Add(s);
            }
            for (int i = 1; ; i++)
            {
                string s = iniController.GetValue("Etc", i.ToString());
                if (s == null)
                    break;
                if (!EtcList.Contains(s))
                    EtcList.Add(s);
            }
            for (int i = 1; ; i++)
            {
                string s = iniController.GetValue("System", i.ToString());
                if (s == null)
                    break;
                if (!SystemList.Contains(s))
                    SystemList.Add(s);
            }

            LastDay = Convert.ToInt32(iniController.GetValue("Date", "1"));
        }

        private void ClearListView()
        {
            MovieList.Clear();
            ImageList.Clear();
            DocList.Clear();
            EtcList.Clear();
            SystemList.Clear();
            
        }

        public static SettingController GetInstance()
        {
            if (scInstance == null)
            {
                scInstance = new SettingController();
            }

            return scInstance;
        }

        private string GetAppDataPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        public FileInformation.EXT_KIND CheckExt(string file)
        {
            foreach (string kind in MovieList)
            {
                if (file.ToUpper().Contains(kind.ToUpper()))
                    return FileInformation.EXT_KIND.MOVIE;
            }
            foreach (string kind in ImageList)
            {
                if (file.ToUpper().Contains(kind.ToUpper()))
                    return FileInformation.EXT_KIND.IMAGE;
            } 
            foreach (string kind in DocList)
            {
                if (file.ToUpper().Contains(kind.ToUpper()))
                    return FileInformation.EXT_KIND.DOC;
            } 
            foreach (string kind in EtcList)
            {
                if (file.ToUpper().Contains(kind.ToUpper()))
                    return FileInformation.EXT_KIND.ETC;
            }

            return FileInformation.EXT_KIND.NONE;
        }
    }
