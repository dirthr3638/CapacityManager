using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileInformation
{
    public enum EXT_KIND
    {
        MOVIE = 0,
        IMAGE,
        DOC,
        ETC,
        NONE
    };

    public string FileName
    {
        get;
        set;
    }
    public long FileSize
    {
        get;
        set;
    }
    public string FilePath
    {
        get;
        set;
    }
    public string FullPath
    {
        get;
        set;
    }
    public string LastAccessDate
    {
        get;
        set;
    }
    public EXT_KIND FileKind
    {
        get;
        set;
    }

}
