using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class PlaceHolderTextBox : TextBox
    {
        private bool _isFirstFocus = true;
        private Font _previousFont;
        private Color _previousColor;

        public PlaceHolderTextBox()
        {
            this.GotFocus += PlaceHolderTextBox_GotFocus;
            this.LostFocus += PlaceHolderTextBox_LostFocus;
        }

        void PlaceHolderTextBox_LostFocus(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.Text))
            {
                return;
            }
            _isFirstFocus = true;
            SetPlaceholder();
        }

        protected override void InitLayout()
        {
            base.InitLayout();
            SetPlaceholder();
        }

        private void PlaceHolderTextBox_GotFocus(object sender, EventArgs e)
        {
            if (!_isFirstFocus)
            {
                return;
            }
            _isFirstFocus = false;
            this.Text = "";
            this.ForeColor = this._previousColor;
            this.Font = this._previousFont;

        }

        private void SetPlaceholder()
        {
            this._previousColor = ForeColor;
            this.ForeColor = this.PlaceHolderColor;
            this._previousFont = this.Font;
            this.Font = this.PlaceHolderFont;
            this.Text = PlaceHolderText;
            if (this.PlaceholderTextShown != null)
            {
                PlaceholderTextShown(this, EventArgs.Empty);
            }
        }

        public string PlaceHolderText { get; set; }
        public Font PlaceHolderFont { get; set; }
        public Color PlaceHolderColor { get; set; }

        public event EventHandler PlaceholderTextShown;
    }
}
