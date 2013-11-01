using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Person p)
            :this()
        {
            this.textBox1.Text = p.FirstName;
            this.textBox2.Text = p.LastName;
            this.textBox3.Text = p.Age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string FirstName
        {
            get { return this.textBox1.Text; }
        }

        public string LastName
        {
            get
            {
                return this.textBox2.Text;
            }
        }

        public int Age
        {
            get { return int.Parse(this.textBox3.Text); }
        }

        public bool CancelClicked { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            CancelClicked = true;
            this.Close();
        }
    }
}
