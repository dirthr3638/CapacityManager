using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

abstract class ThreadControl// : IThreadRun
{
    public Thread th;

    public abstract void run();

    protected void start()
    {
        th = new Thread(new ThreadStart(run));
        th.Start();
//        th.Join();
    }
    protected void threadSuspend()
    {
        if (th != null)
        {
            th.Suspend();
        }
    }
    protected void threadResume()
    {
        th.Resume();
    }
}

