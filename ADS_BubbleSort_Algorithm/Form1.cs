using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS_BubbleSort_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*--------BubbleSort Algorithm------------------------------------
        The algorithm for the bubble sort algorithm can be stated as follows:
        1. Start from the beginning of the array and compare the adjacent values.
        2. If they are in descending order, swap them.
        3. Repeat steps 1 and 2 until the end of the array is reached.
        4. Ignore the sorted values and start from the unsorted of the array and repeat steps 1, 2 and 3.
        5. When all values in the array are sorted stop.
        */
        private void btnExecute_Click(object sender, EventArgs e)
        {
            // declare new array
            int[] numbers = new int[] { 3, 6, 1, 4, 5 };

            // Add text to output
            txtOutput.Text = "Unsorted array:\r\n";

            // cycle through array to print unsorted values
            foreach(int value in numbers)
                txtOutput.Text += value + "\t"; // "\t" = one Tab
            
            // add text to output
            txtOutput.Text += "\r\nSorted Array:\r\n";

            // run array through bubblesort algorithm
            bubbleSort(numbers);

            // cycle through array to print sorted values
            foreach (int value in numbers)
                txtOutput.Text += value + "\t";
        }

        // bubblesort algorithm.
        // when calling method after creating an array enter the name of the array as the argument
        // example created array called "numbers" to call array in bubblesort algorithm type "bubbleSort(numbers);"
        public void bubbleSort(int[] sortArray)
        {
            int size = sortArray.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j < size - i; j++)
                {
                    if (sortArray[j - 1] > sortArray[j])
                    {
                        int temp = sortArray[j - 1];
                        sortArray[j - 1] = sortArray[j];
                        sortArray[j] = temp;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
