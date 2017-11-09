using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QueueLibrary;

namespace MainApp
{
    public partial class Form1 : Form
    {   
        private QueueWrapper<int> _wrapper;
        private readonly List<string> _resultList=new List<string>();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThreads_Click(object sender, EventArgs e)
        {   
            RunQueue();
        }

        private void RunQueue()
        {
            _wrapper = QueueWrapper<int>.Instanse;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(_wrapper);
        }
        
        void bw_DoWork(object sender, DoWorkEventArgs args)
        {
          if (string.IsNullOrEmpty(txtThread1.Text))
                return;
            var array = txtThread1.Text.Split(',');
            if (!array.Any())
                return;
            
            foreach (var item in array)
            {
                int value;
                if (!int.TryParse(item, out value))
                    continue;
                _wrapper.Push(value);
                _resultList.Add(_wrapper.Pop().ToString());
                
            }
            args.Result = _resultList;
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs args)
        {
            if (!args.Cancelled && args.Error == null && args.Result != null)
            {
                var list = args.Result as List<string>;
                if (list == null || !list.Any())
                    return;

                foreach (var item in list)
                    listBox1.Items.Add(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;

            if (string.IsNullOrEmpty(txtThread1.Text))
                return;

            var array = txtThread1.Text.Split(',').ToList();
            if (!array.Any())
                return;

            array.ForEach((item) =>
            {
                if (!int.TryParse(item, out number))
                    return;
            });

            if (!int.TryParse(txtValue.Text, out number))
                return;

            var heplper = new CollectionHelper() {BaseList = array, Number = number};
            var result = heplper.GetData();

            listBox1.Items.Clear();
            foreach (var item in result)
                listBox1.Items.Add(item.ToString());

        }
    }
}
