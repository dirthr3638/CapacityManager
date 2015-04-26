using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace CapacityManager
{
    class FileSearcher : ThreadControl
    {
        UIController uc;
        SettingController sc;
        //public List<FileInformation> FileInfo = new List<FileInformation>();
      //  private long TotalFileCount;
        private bool threadStop;
        FileSystem fs = new FileSystem();

        public FileSearcher(UIController uc)
        {
            threadStop = false;
            this.uc = uc;
            sc = SettingController.GetInstance();
        }

        public override void run()
        {

            ArrayList DriveList = new ArrayList();
            ArrayList FolderList = new ArrayList();
            
            
            DriveList = fs.GetDriveInfo();
            long FileCount = 0;

            SettingController sc = SettingController.GetInstance();
            if (sc.TargetFolder == null)
            {
                //모든 폴더 검출
                foreach (string drive in DriveList)
                {
                    FolderList.AddRange((ArrayList)fs.GetDirectoryInFullPath(drive).Clone());
                }
            }
            else
                FolderList.AddRange((ArrayList)fs.GetDirectoryInFullPath(sc.TargetFolder).Clone());

            

            if (RequestStop())
            {
                fs.stop = false;
                return;
            }

            uc.AlarmBeforeDetectingFile();

            FileCount = fs.GetFileCount(FolderList);
            DetectStartAlarm(FileCount);

            //해당 폴더들에서 파일 검출
            //예외폴더는 제외시킴
            foreach (string folder in FolderList)
            {
                if (RequestStop())
                {
                    fs.stop = false;
                    return;
                }
                DetectingFile(folder);
                DelectedFolder(fs.GetFileCountInFolder(folder), folder);
            }

            uc.AlarmComleteDetect();
            
        }

        private void DetectStartAlarm(long TotalFileCount)
        {
            uc.DetectStartAlarm(TotalFileCount);
        }

        private void DelectedFolder(long count, string folder)
        {
            uc.DelectedFolder(count, folder);
        }

        private void DetectingFile(string folder)
        {
            ArrayList FileList;
            FileSystem fs = new FileSystem();
            FileList = fs.GetFileListInDirectory(folder);
            foreach (string file in FileList)
            {
                /*
                 * 최종파일검출
                 * 1. 검출 확장자에 들어있는지 확인
                 * 2. 시간차에 맞는지 확인
                 * 
                */
                if (RequestStop())
                    return;

                FileInformation.EXT_KIND kind;
                kind = sc.CheckExt(file);
                switch (kind)
                {
                    case FileInformation.EXT_KIND.MOVIE:
                        break;
                    case FileInformation.EXT_KIND.IMAGE:
                        break;
                    case FileInformation.EXT_KIND.DOC:
                        break;
                    case FileInformation.EXT_KIND.ETC:
                        break;
                    default:
                        continue;
                }

                TimeSpan time = fs.GetCompareTime(DateTime.Now, fs.GetFileAccessDate(folder + "\\" + file));
                int days = (int)time.TotalDays;

                //최좀 검출이 완료될시 Flow
                if (days >= sc.LastDay)
                {
                    FileInformation fi = new FileInformation();
                    fi.FileName = file;
                    fi.FilePath = folder;
                    fi.FileSize = fs.GetFileSize(folder + "\\" + file);
                    fi.FullPath = folder + "\\" + file;
                    fi.LastAccessDate = string.Format("{0}", days);
                    fi.FileKind = kind;
                    uc.DetectFileData(fi);
                }
            }
        }

        public void SearchStart()
        {
   
            start();
        }

        public void StopSearch()
        {
            threadStop = true;
            fs.GetDirectoryInFullPathStop();
            th.Join();
            uc.StopComplete();
            threadStop = false;
        }

        private void InitSet()
        {

        }

        private bool RequestStop()
        {
            return threadStop;
        }


    }
}
