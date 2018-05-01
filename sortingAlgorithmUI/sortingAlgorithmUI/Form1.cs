using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortingAlgorithmUI
{
    public partial class uiTemplate : Form
    {
        quickSortingClass sortClass; 
        public uiTemplate()
        {
            sortClass = new quickSortingClass();
            InitializeComponent();
            userInput.Click += new EventHandler(userInput_Click);
        }

        private void userInput_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int c = Int32.Parse(textBox3.Text);
            int d = Int32.Parse(textBox4.Text);
            int v = Int32.Parse(textBox5.Text);
            int f = Int32.Parse(textBox6.Text);

            int[] arr = new int[6] { a, b, c, d, v, f };
            sortClass.QuickSorter(arr);
            resultbox.Text = sortClass.Answer;
        }
    }
}
