using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockingQueue.Classes
{
    class Task2:QueueTask
    {
        private string _InputNumberOne = "";
          public Task2()
        {
            TaskName = "CheckPolindrom";
        }
        
          [System.ComponentModel.Category("ITask Settings")]
          public string Number1
          {
              get
              {
                  return _InputNumberOne;
              }
              set
              {
                  _InputNumberOne = value;
              }
          }

          public override object Mission()
          {
              int substitueNumber = 0;
              Boolean result=false;
              if (int.TryParse(Number1, out substitueNumber))
                  result =true;

              string resultMessgae = string.Format("The result is {0}", result);
              return resultMessgae;
          }
    }
}
