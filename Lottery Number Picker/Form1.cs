using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Number_Picker
{
    public partial class Form1 : Form
    {
        int[] lottoNumbers = { 0, 0, 0, 0, 0, 0 };
        Random randGen = new Random();
        int numb = 0;
        int notSameCheck = 0;
        int arrayReset = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            foreach (int i in lottoNumbers)
            {
                lottoNumbers[arrayReset] = 0;
                arrayReset++;
            }
            arrayReset = 0;
            numb = 0;
            outputLabel.Text = "";
            while (numb <= 5)
            {
                notSameCheck = randGen.Next(1, 7);
                if (lottoNumbers.Contains(notSameCheck))
                {
                    continue;
                }
                lottoNumbers[numb] = notSameCheck;
                numb++;
            }
            foreach (int i in lottoNumbers)
            {
                outputLabel.Text += (i) + " ";
            }
        }
    }
}
