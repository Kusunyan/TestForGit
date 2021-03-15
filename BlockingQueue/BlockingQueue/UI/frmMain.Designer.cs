namespace BlockingQueue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNumberOfDequeueWorkerThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvwOutputs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQueue = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskInstancesPerThread = new System.Windows.Forms.TextBox();
            this.txtNQWorkerThreads = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTaskType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtNumberOfDequeueWorkerThreads);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(612, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 21);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNumberOfDequeueWorkerThreads
            // 
            this.txtNumberOfDequeueWorkerThreads.Location = new System.Drawing.Point(305, 32);
            this.txtNumberOfDequeueWorkerThreads.Name = "txtNumberOfDequeueWorkerThreads";
            this.txtNumberOfDequeueWorkerThreads.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfDequeueWorkerThreads.TabIndex = 1;
            this.txtNumberOfDequeueWorkerThreads.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of de-queue worker threads";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.lvwOutputs);
            this.groupBox2.Location = new System.Drawing.Point(340, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 21);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvwOutputs
            // 
            this.lvwOutputs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwOutputs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwOutputs.Location = new System.Drawing.Point(6, 18);
            this.lvwOutputs.Name = "lvwOutputs";
            this.lvwOutputs.Size = new System.Drawing.Size(361, 273);
            this.lvwOutputs.TabIndex = 0;
            this.lvwOutputs.UseCompatibleStateImageBehavior = false;
            this.lvwOutputs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ouput";
            this.columnHeader1.Width = 500;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQueue);
            this.groupBox3.Controls.Add(this.propertyGrid1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTaskInstancesPerThread);
            this.groupBox3.Controls.Add(this.txtNQWorkerThreads);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cboTaskType);
            this.groupBox3.Location = new System.Drawing.Point(23, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 344);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(112, 306);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(75, 21);
            this.btnQueue.TabIndex = 2;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(16, 57);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(258, 158);
            this.propertyGrid1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Task instances per thread";
            // 
            // txtTaskInstancesPerThread
            // 
            this.txtTaskInstancesPerThread.Location = new System.Drawing.Point(193, 271);
            this.txtTaskInstancesPerThread.Name = "txtTaskInstancesPerThread";
            this.txtTaskInstancesPerThread.Size = new System.Drawing.Size(100, 22);
            this.txtTaskInstancesPerThread.TabIndex = 1;
            this.txtTaskInstancesPerThread.Text = "10";
            // 
            // txtNQWorkerThreads
            // 
            this.txtNQWorkerThreads.Location = new System.Drawing.Point(193, 246);
            this.txtNQWorkerThreads.Name = "txtNQWorkerThreads";
            this.txtNQWorkerThreads.Size = new System.Drawing.Size(100, 22);
            this.txtNQWorkerThreads.TabIndex = 1;
            this.txtNQWorkerThreads.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number Of Queuing worker threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "TaskType";
            // 
            // cboTaskType
            // 
            this.cboTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaskType.FormattingEnabled = true;
            this.cboTaskType.Location = new System.Drawing.Point(153, 18);
            this.cboTaskType.Name = "cboTaskType";
            this.cboTaskType.Size = new System.Drawing.Size(121, 20);
            this.cboTaskType.TabIndex = 0;
            this.cboTaskType.DropDownClosed += new System.EventHandler(this.cboTaskType_DropDownClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Blocking Queue Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNumberOfDequeueWorkerThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTaskType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskInstancesPerThread;
        private System.Windows.Forms.TextBox txtNQWorkerThreads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.ListView lvwOutputs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClear;
    }
}

