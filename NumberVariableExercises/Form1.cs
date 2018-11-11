using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberVariableExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            // cast decimal to int
            int myIntValue = (int) myDecimalValue;
            MessageBox.Show("The myIntValue is " + myIntValue);

            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            //can't cast bool to double
            //bool myBool = (bool)myDouble;
            string myString = "false";
            //cannot cast bool to string
            //myBool = (bool)myString;
            //cannot cast string to int
            //myString = (string)myInt;
            myString = myInt.ToString();
            //cannot cast bool to byte
            //myBool = (bool)myByte;
            //myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            //cannot cast string to char
            //myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte
            + myDouble + myChar;
        }
    }
}
