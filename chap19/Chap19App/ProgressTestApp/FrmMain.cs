using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgressTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "시작";

            Thread th = new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(100);
                }
            });
            th.IsBackground = true;
            th.Start();

            label1.Text = "종료";
            
            //th.Join();

        }
    }
}
