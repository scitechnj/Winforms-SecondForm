using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        public static extern void AllocConsole();

        public Form1()
        {
            AllocConsole();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            Form2 form2 = new Form2();
            form2.LabelText = text;
            form2.ShowDialog();

            this.textBox1.Text = form2.TextBoxText;

            Console.WriteLine("After show!");
        }
    }
}
