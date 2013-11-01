using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

        public string TextBoxText
        {
            get { return this.textBox1.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
