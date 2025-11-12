using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public NumberButton[,] _numberArray;
        public Form1()
            
        {
            int count = 1;
            InitializeComponent();
            _numberArray = new NumberButton[4, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {  
                    NumberButton numberbutton = new NumberButton(this,new Size(100,100),new Point(j*100,i*100), $"{count}",i,j,count);
                    _numberArray[i, j] = numberbutton;
                    Controls.Add(numberbutton);
                    count++;
                }
            }
           //"0"用.
            NumberButton zero = new NumberButton(this, new Size(100, 100), new Point(100, 300), $"{0}", 3, 1,0);
            _numberArray[3,1] = zero;
            Controls.Add(zero);
        }

        
    }
}
