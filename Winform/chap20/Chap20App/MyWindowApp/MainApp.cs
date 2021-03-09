using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowApp
{
    class MainApp : Form
    {

        public MainApp(string title)
        {
            this.Text = title;
            //this.MouseClick += new MouseEventHandler(MainApp_MouseClick);
            this.MouseClick += MainApp_MouseClick;
        }

        private void MainApp_MouseClick(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            var result = $"sender : {sender}\r\n" +
                         $"e: {e}\r\n" +
                         $"e.X : {e.X}, e.Y : {e.Y}" +
                         $"Button : {e.Button}, Clicks : {e.Clicks}";

            MessageBox.Show(result);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event App"));
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainApp
            // 
            ClientSize = new System.Drawing.Size(346, 365);
            this.Name = "MainApp";
            this.ResumeLayout(false);

        }
    }
}
