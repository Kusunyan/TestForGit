using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockingQueue.Classes
{
    abstract class QueueTask
    {
        private string _TaskName = "";
        private int _NumberOfThreads = 0;

        private int _TaskOfThreads = 0;
        public string TaskName
        {
            get { return _TaskName; }
            set { _TaskName = value; }
        }

        public int NumberOfThreads
        {
            get { return _NumberOfThreads; }
            set { _NumberOfThreads = value; }
        }
        public int TaskOfThreads
        {
            get { return _TaskOfThreads; }
            set { _TaskOfThreads = value; }
        }

        public  abstract object Mission();

    }
}
