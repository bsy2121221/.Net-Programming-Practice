using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Click";
            b.Size = new Size(100, 50);
            b.Location = new Point(100, 100);
            this.Controls.Add(b);

            //using Anynomous method
            b.Click += delegate (object sender1, EventArgs e1)
              {
                  MessageBox.Show("hello");
              };

            //by using lambda expression
            b.Click += (sender2, e2) =>
            {
                MessageBox.Show("Hello");
            };

        }
    }
}
