using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Collections;
using Microsoft.ShDocVw;

class ProcessControl
{
    public bool ProcessKill(string proessName)
    {
        Process[] myProcesses = Process.GetProcessesByName(proessName);
        foreach (Process myProcess in myProcesses)
            myProcess.Kill();

        return true;
    }

    public ArrayList GetExplorerList()
    {
        ArrayList urlList = new ArrayList();

        foreach (InternetExplorer page in new ShellWindows())
            urlList.Add(page.LocationURL);

        return urlList;
    }

    public void ResetExplorer()
    {
        ArrayList urlList = new ArrayList();
        urlList = GetExplorerList();

        ProcessKill("explorer");

        foreach (string urlName in urlList)
            System.Diagnostics.Process.Start("explorer.exe", urlName);
    }


}

