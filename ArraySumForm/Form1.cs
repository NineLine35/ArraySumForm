using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySumForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(numberTextBox.Text, out number))
            {
                numberListBox.Items.Add(numberTextBox.Text);
                numberTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please input a number.");
                numberTextBox.Clear();
            }
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count;
            count = numberListBox.Items.Count;
            int[] answer = new int[count];  //answer array

            int[] numberArray = new int[count];   //listbox array

            int index = 0;  //Accumulator
            int y = 0; //Accumulator


            //Assign the listbox items to an int array.
            foreach (string VARIABLE in numberListBox.Items)
            {
                
                numberArray[index] = int.Parse(VARIABLE);

                index++;
            }

            
            //Create a new array to hold the summed values
            for (int x = 0; x < count; x++)
            {
                
                y = numberArray[x] + y;

                answer[x] = y;

            }

            foreach (int VARIABLE in answer)
            {
                outputListBox.Items.Add(VARIABLE);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numberListBox.Items.Clear();
            outputListBox.Items.Clear();
        }
    }
}
