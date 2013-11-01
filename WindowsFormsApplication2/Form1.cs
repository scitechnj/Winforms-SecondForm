using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private bool _isFirstFocus = true;
        public Form1()
        {
            InitializeComponent();
            SetPlaceholder();
            this.textBox1.GotFocus += textBox1_GotFocus;
            this.textBox1.LostFocus += textBox1_LostFocus;
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                return;
            }

            _isFirstFocus = true;
            SetPlaceholder();
        }

        private void SetPlaceholder()
        {
            this.textBox1.ForeColor = Color.Gray;
            this.textBox1.Font = new Font(this.textBox1.Font.FontFamily, this.textBox1.Font.Size, FontStyle.Italic);
            this.textBox1.Text = "Placeholder";
            
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (!_isFirstFocus)
            {
                return;
            }
            _isFirstFocus = false;
            this.textBox1.Text = "";
            this.textBox1.ForeColor = Color.Black;
            this.textBox1.Font = new Font(this.textBox1.Font.FontFamily, this.textBox1.Font.Size, FontStyle.Regular);
        }

       
    }
}
