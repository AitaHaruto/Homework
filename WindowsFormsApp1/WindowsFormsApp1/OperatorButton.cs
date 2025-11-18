using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class OperatorButton:Button
    {
        int state = 0;
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
        public void Addtion()
        {
            if (_form1._operatorArray[_x].Text == "+")
            {
                state = 1;
            }
        }
        public void Subtraction()
        {
            if (_form1._operatorArray[_x].Text == "-")
            {
                state = 2;

            }
        }
        public void Multiplication()
        {
            if (_form1._operatorArray[_x].Text == "×")
            {
                state = 3;
            }

        }
        public void Division()
        {
            if (_form1._operatorArray[_x].Text == "÷")
            {
                state = 4;
            }

        }
        public void Equal()
        {
            if (_form1._operatorArray[_x].Text == "＝")
            {
                if (state == 1)
                { 
                
                }
            }
        }
        
        public void Operator_Click(object sender, EventArgs e)
        {

            
        }
    }
}
