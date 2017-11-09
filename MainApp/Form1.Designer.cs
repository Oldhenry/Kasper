namespace MainApp
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
            this.btnThreads = new System.Windows.Forms.Button();
            this.txtThread1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThreads
            // 
            this.btnThreads.Location = new System.Drawing.Point(346, 8);
            this.btnThreads.Name = "btnThreads";
            this.btnThreads.Size = new System.Drawing.Size(130, 23);
            this.btnThreads.TabIndex = 0;
            this.btnThreads.Text = "Queque Threads";
            this.btnThreads.UseVisualStyleBackColor = true;
            this.btnThreads.Click += new System.EventHandler(this.btnThreads_Click);
            // 
            // txtThread1
            // 
            this.txtThread1.Location = new System.Drawing.Point(12, 10);
            this.txtThread1.Name = "txtThread1";
            this.txtThread1.Size = new System.Drawing.Size(250, 20);
            this.txtThread1.TabIndex = 1;
            this.txtThread1.Text = "22,8,27,91,0,1,2,3,4,5,6,7,8,9";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "12, 8, 1, 9, 4, 2, 4, 0, 12, 43, 33, 4, 55";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Collection Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(519, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 277);
            this.listBox1.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(268, 51);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(44, 20);
            this.txtValue.TabIndex = 5;
            this.txtValue.Text = "13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 315);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtThread1);
            this.Controls.Add(this.btnThreads);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThreads;
        private System.Windows.Forms.TextBox txtThread1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtValue;
    }
}

