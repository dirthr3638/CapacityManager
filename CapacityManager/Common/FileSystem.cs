using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.IO;


class FileSystem
{
    ArrayList DriveKind;
    ArrayList FolderList = new ArrayList();
    ArrayList FileList = new ArrayList();
    int Depth;
    public bool stop
    {
        get;
        set;
    }

    public FileSystem()
    {
        stop = false;
        DriveKind = new ArrayList();
        Depth = 0;
    }

    public ArrayList GetDriveInfo()
    {
        foreach (DriveInfo drv in DriveInfo.GetDrives())
        {
            if (DriveType.Fixed == drv.DriveType)
               DriveKind.Add(drv.Name);
        }
        return DriveKind;
    }

    public ArrayList GetFileListInDrive(string folder)
    {
        try
        {
            foreach (string file in Directory.GetFiles(folder))
                FileList.Add(file);
            foreach (string dir in Directory.GetDirectories(folder))
                GetFileListInDirectory(dir);
        }
        catch { }

        return FileList;
    }

    public ArrayList GetFileListInDirectory(string folder)
    {

        try
        {
            foreach (string file in Directory.GetFiles(folder))
            {
                FileList.Add(Path.GetFileName(file));
            }
            
        }
        catch { }

        return FileList;
    }

    private bool CheckExceptFolder(string folder)
    {
        SettingController sc = SettingController.GetInstance();

        foreach (string kind in sc.SystemList)
        {
            if (kind == "Windows")
            {
                if (folder.ToUpper().Contains(Environment.GetFolderPath(Environment.SpecialFolder.Windows).ToUpper()))
                    return true;
            }
            else if (kind == "Program")
            {
                if (folder.ToUpper().Contains(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToUpper()) ||
                folder.ToUpper().Contains(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).ToUpper()))
                    return true;
            }
        }

        return false;
    }

    public ArrayList GetDirectoryInFullPath(string folder)
    {
        if(CheckExceptFolder(folder))
            return FolderList;

        if (Depth == 0)
        {
            FolderList.Clear();
            FolderList.Add(folder);
        }
        try
        {
            foreach (string dir in Directory.GetDirectories(folder))
            {
                if (stop)
                {
                    return FolderList;
                }
                FolderList.Add(dir);
                Depth++;
                GetDirectoryInFullPath(dir);
                Depth--;
            }
        }
        catch { }

        return FolderList;
    }

    public void GetDirectoryInFullPathStop()
    {
        stop = true;
    }

    public DateTime GetFileAccessDate(string file)
    {
        return File.GetLastAccessTime(file);
    }

    public TimeSpan GetCompareTime(DateTime date1, DateTime date2)
    {
        return date1.Subtract(date2);
    }

    public string DeleteFile(string file)
    {
        File.Delete(file);

        return "삭제";
    }

    public int GetFileCount(string dir)
    {
        return Directory.GetFiles(dir).Length;
    }

    public bool CheckWindowsFolder(string dir)
    {
        return dir.Contains(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
    }

    public bool CheckProgramFolder(string dir)
    {
        return dir.Contains(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) | 
            dir.Contains(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
    }

    public long GetFileSize(string file)
    {
        try
        {
            System.IO.FileInfo leftFileInfo = new System.IO.FileInfo(file);
            return leftFileInfo.Length / 1024;
        }
        catch
        {
            return 0;
        }
    }

    public long GetFileCount(ArrayList folderList)
    {
        long cnt = 0;

        foreach (string folder in folderList)
        {
            try
            {
                cnt += Directory.GetFiles(folder).Length;
            }
            catch
            {
            }
        }

        return cnt;
    }

    public long GetFileCountInFolder(string folder)
    {
        int count = 0;
        try
        {
            count = Directory.GetFiles(folder).Length;
            return count;
        }
        catch
        {
            return count;
        }

        
    }
}
