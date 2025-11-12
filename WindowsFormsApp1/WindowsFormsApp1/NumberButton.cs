using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class NumberButton:Button
    {
      
        
        

        private int _y;
        
        private int _x;

        private int _z;
        private Form1 _form1;
        public  NumberButton(Form1 form1, Size size, Point location, string text,int x, int y,int z)
        {
            _form1 = form1;
             Size = size;
            Location = location;
            Text = text;
            _x = x;
            _y = y;
            _z = z;
            Click += NumberButton_Click;


        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = _form1._numberArray[_x, _y]._z;
            MessageBox.Show($"{num1}");
        }
    }
}
