using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BlockingQueue.Classes
{
    class QueueTaskHandler
    {
        private Queue<QueueTask> _TaskCollector;
        private object QueueLockObject=new object();
        private List<System.Threading.Timer> ReadThreads;
        public delegate void workMessage(string status);
        public event workMessage workMessageHandler;
        public Queue<QueueTask> TaskCollector
        {
            get { return _TaskCollector; }
        }

        private Action WorkMission;

       
        public QueueTaskHandler(int numberOfThreads, Action action)
        {                 
            this.WorkMission = action;
            _TaskCollector = new Queue<QueueTask>();
            ReadThreads = new List<System.Threading.Timer>();
            for (int i = 0; i < numberOfThreads; i++)
            {
                TimerCallback callback = new TimerCallback(ReadThreadWork);
                System.Threading.Timer myTimer = new System.Threading.Timer(callback, null, 0, 1000);
                ReadThreads.Add(myTimer);
            }           
        }


        
        void writeThreadWork(object taskObject)
        {
            QueueTask task = (QueueTask)taskObject;
            for (int i = 0; i < task.TaskOfThreads; i++)
            {
                string message = string.Format("{0} {1} {2}", task.TaskName, Thread.CurrentThread.Name, task.Mission());
                workMessageHandler(message);
            }
        }
        void ReadThreadWork(object taskObject)
        {
            WorkMission();
            dequeueAndExecuteTask();
           
        }
        void dequeueAndExecuteTask()
        {
            lock (QueueLockObject)
            {
                if (_TaskCollector.Count != 0)
                {
                    QueueTask task = _TaskCollector.Dequeue();
                    for (int i = 0; i < task.NumberOfThreads; i++)
                    {
                        System.Threading.Thread myThread = new System.Threading.Thread(writeThreadWork);
                        myThread.IsBackground = true;
                        myThread.Name = string.Format("Work Thread {0}", i);                      
                        myThread.Start(task);
                    }                      
                }
            }
        }

        
    }
}
