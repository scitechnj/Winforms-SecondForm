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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PlaceHolderTextBox textBox = new PlaceHolderTextBox();
            textBox.PlaceHolderText = "First Name";
            textBox.PlaceHolderFont = new Font("Comic Sans MS", 8f, FontStyle.Italic | FontStyle.Underline);
            textBox.PlaceHolderColor = Color.Orange;

            textBox.Size = new Size(100, 30);
            textBox.Location = new Point(40, 60);

            this.Controls.Add(textBox);
        }
    }
}
