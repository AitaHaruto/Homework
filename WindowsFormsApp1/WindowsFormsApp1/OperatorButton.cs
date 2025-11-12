using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class OperatorButton:Button
    {
        private int _x;
        private int _y;
        private Form1 _form1;
        private NumberButton _numberbutton;
        public OperatorButton(Form1 form1, Size size, Point location, string text, int x)
        {
            _form1 = form1;
            Size = size;
            Location = location;
            Text = text;
            _x = x;
            
            Click += Operator_Click;
        }
        private void Operator_Click(object sender, EventArgs e)
        { 
        
        }
    }
}
