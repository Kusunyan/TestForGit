using System.Collections.Generic;
using System.Windows.Forms;

namespace BlockingQueue
{
    public partial class Form1 : Form
    {
        private Classes.QueueTaskHandler _Collector;
        private Queue<Classes.QueueTask> QueueWork;
        Dictionary<string, Classes.QueueTask> QueueTaskDic;
        private object QueueLockObject=new object();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

            QueueTaskDic=new Dictionary<string,Classes.QueueTask>();
            addTaskType(new Classes.Task1());
            addTaskType(new Classes.Task2());
            QueueWork = new Queue<Classes.QueueTask>();
           // cboTaskType.Items.add
           
        }
        private void addTaskType(Classes.QueueTask task)
        { 
            QueueTaskDic.Add(task.TaskName,task);
            cboTaskType.Items.Add(task.TaskName);
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            if (_Collector != null)
                _Collector.workMessageHandler -= new Classes.QueueTaskHandler.workMessage(AddInformation);
            
            int numOfReadThreads = System.Convert.ToInt32(txtNumberOfDequeueWorkerThreads.Text);
            _Collector = new Classes.QueueTaskHandler(numOfReadThreads, DequeueTask);
            _Collector.workMessageHandler += new Classes.QueueTaskHandler.workMessage(AddInformation);
        }

        private void btnQueue_Click(object sender, System.EventArgs e)
        {
            Classes.QueueTask task = getTaskType();
            settingParameterOfTask(task);
            lock (QueueLockObject)
            {
                QueueWork.Enqueue(task);
            }          
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            lvwOutputs.Items.Clear();
        }
        private void settingParameterOfTask(Classes.QueueTask task)
        {           
            task.NumberOfThreads = getNumber(txtNQWorkerThreads.Text);
            task.TaskOfThreads = getNumber(txtTaskInstancesPerThread.Text);
        }

        private int getNumber(string numberStr)
        {
            int substitueNum = 0;
            if (int.TryParse(numberStr, out substitueNum))
                return substitueNum;
            else
                return 0;
        }

        private Classes.QueueTask getTaskType()
        {
            if (cboTaskType.SelectedIndex == -1)
                throw new System.Exception("Please choose a type");
            Classes.QueueTask task = QueueTaskDic[cboTaskType.SelectedItem.ToString()];
            return task;
        }

        private void cboTaskType_DropDownClosed(object sender, System.EventArgs e)
        {       
            propertyGrid1.SelectedObject = getTaskType();
        }

        private void DequeueTask()
        { 
            lock(QueueLockObject)
            {
                if(QueueWork.Count!=0)
             _Collector.TaskCollector.Enqueue(QueueWork.Dequeue())  ;
            }
           
        }

        private delegate void AddInformationHandler(string message);
        private void AddInformation(string message)
        {
            if (this.InvokeRequired)
            {
                AddInformationHandler aih = new AddInformationHandler(AddInformation);
                this.Invoke(aih,message);
            }
            else
            {
                lvwOutputs.Items.Add(message);
            }          
        }

      
       
    }
}
