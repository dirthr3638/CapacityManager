using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class MyListView : ListView
{
    public MyListView()
    {
        //Activate double buffering
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

        //Enable the OnNotifyMessage event so we get a chance to filter out 
        // Windows messages before they get to the form's WndProc
        this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        this.SetStyle(ControlStyles.DoubleBuffer, true);
        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        this.SetStyle(ControlStyles.UserPaint, true);
        this.SetStyle(ControlStyles.ResizeRedraw, true);
    }

    protected override void OnNotifyMessage(Message m)
    {
        //Filter out the WM_ERASEBKGND message
        if(m.Msg != 0x14)
        {
            base.OnNotifyMessage(m);
        }
    }
}
