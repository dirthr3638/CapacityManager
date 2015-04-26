using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacityManager
{
    class UIController : IController
    {
        CapacityManager cm;
        FileSearcher fs;
        public UIController(CapacityManager cm)
        {
            this.cm = cm;
            fs = new FileSearcher(this);
        }

        public void SearchStart()
        {
            cm.BeforeSearchStart();
            fs.SearchStart();
        }

        public void DetectFileData(FileInformation file)
        {
            cm.DetectFile(file); 
        }
       
        public void DetectStartAlarm(long TotalFileCount)
        {
            cm.DetectStartAlarm(TotalFileCount);
        }

        public void DelectedFolder(long count, string folder)
        {
            cm.DelectedFolder(count, folder);
        }

        public void StopSearch()
        {
            fs.StopSearch();
        }
        public void StopComplete()
        {
            cm.StopComplete();
        }
        public void AlarmBeforeDetectingFile()
        {
            cm.AlarmBeforeDetectingFile();
        }
        public void AlarmComleteDetect()
        {
            cm.AlarmComleteDetect();
        }
    }
}
