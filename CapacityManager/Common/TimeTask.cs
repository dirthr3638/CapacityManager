using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacityManager.Common
{
    class TimeTask
    {
        private DateTime GetTimeAtNow()
        {
            return DateTime.Now;
        }

        public double CompareDateDay(bool bCompare, DateTime date1)
        {
            DateTime date = GetTimeAtNow();

            TimeSpan ts = date1 - date;

            return ts.TotalDays;
        }

        public string SuitDateChange(double day)
        {
            return string.Format("{0}일 전", day);
        }

    }
}
