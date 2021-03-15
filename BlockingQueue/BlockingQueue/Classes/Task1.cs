using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockingQueue.Classes
{
    class Task1 : QueueTask
    {
        private int _InputNumberOne = 0;
        private int _InputNubmerTwo = 0;
        public Task1()
        {
            TaskName = "AddNumbers";
        }

        [System.ComponentModel.Category("ITask Settings")]
        public int Number1
        {
            get
            {
                return _InputNumberOne;
            }
            set
            {
                int substitueNumber = 0;
                if (int.TryParse(value.ToString(), out substitueNumber))
                    _InputNumberOne = substitueNumber;
            }
        }
        [System.ComponentModel.Category("ITask Settings")]
        public int Number2
        {
            get
            {
                return _InputNubmerTwo;
            }
            set
            {
                int substitueNumber = 0;
                if (int.TryParse(value.ToString(), out substitueNumber))
                    _InputNubmerTwo = substitueNumber;
            }
        }

        public override object Mission()
        {
            int sum = Number1 + Number2;
            string result = string.Format("sum is {0}", sum);
            return result;
        }

    }
}
