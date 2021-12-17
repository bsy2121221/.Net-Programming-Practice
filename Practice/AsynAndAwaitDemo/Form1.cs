using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace AsynAndAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharecters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\File.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private async void ReadFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharecters);
            task.Start();

            label1.Text = "File in Processing";

            int count = await task;
            label1.Text = count.ToString() + " charecters in file";
        }
    }
}
