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
        public OperatorButton[] _operatorArray;
        public Form1()
            
        {
            int count = 1;
            InitializeComponent();
            _numberArray = new NumberButton[4, 4];
            _operatorArray = new OperatorButton[5];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {  
                    NumberButton numberbutton = new NumberButton(this,new Size(100,100),new Point(j*100,i*100+100), $"{count}",i,j,count);
                    _numberArray[i, j] = numberbutton;
                    Controls.Add(numberbutton);
                    count++;
                }
            }
           //"0"用.
            NumberButton zero = new NumberButton(this, new Size(100, 100), new Point(100, 400), $"{0}", 3, 1,0);
            _numberArray[3,1] = zero;
            Controls.Add(zero);

            //演算子ボタンの生成.
            OperatorButton addition = new OperatorButton (this, new Size(100, 100), new Point(300, 100), "+", 0);
            _operatorArray[0] = addition;
            Controls.Add(addition);
            OperatorButton subtraction = new OperatorButton(this, new Size(100, 100), new Point(300, 200), "-", 1);
            _operatorArray[1] = subtraction;
            Controls.Add(subtraction);
            OperatorButton multiplication = new OperatorButton(this, new Size(100, 100), new Point(300, 300), "×", 2);
            _operatorArray[2] = multiplication;
            Controls.Add(multiplication);
            OperatorButton division = new OperatorButton(this, new Size(100, 100), new Point(300, 400), "÷", 3);
            _operatorArray[3] = division;
            Controls.Add(division);
            OperatorButton equal = new OperatorButton(this, new Size(100, 100), new Point(200, 400), "＝", 4);
            _operatorArray[4] = equal;
            Controls.Add(equal);

        }

        
    }
}
