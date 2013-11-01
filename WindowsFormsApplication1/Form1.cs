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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult result = form2.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            this.listBox1.Items.Add(new Person
                {
                    FirstName = form2.FirstName,
                    LastName = form2.LastName,
                    Age = form2.Age
                });


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Are you sure?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            this.label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
            {
                return;
            }

            Person person = (Person)this.listBox1.SelectedItem;
            Form2 form2 = new Form2(person);
            if (form2.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            this.listBox1.Items[this.listBox1.SelectedIndex] = new Person
                {
                    FirstName = form2.FirstName,
                    LastName = form2.LastName,
                    Age = form2.Age
                };

        }
    }
}
