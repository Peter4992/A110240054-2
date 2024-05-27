using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        List<int> scoresList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }


        private void getScoresButton_Click(object sender, EventArgs e)
        {
            //List<int> scoresList = new List<int>();
            double average;
            int numAboveAverage;
            int numBelowAverage;

            GetScoreFromFile(scoresList);

            foreach (int value in scoresList)
            {
                testScoresListBox.Items.Add(value);
            }

            average = Average(scoresList);
            averageLabel.Text = average.ToString("n1");

            numAboveAverage = AboveAverage(scoresList, average);
            aboveAverageLabel.Text = numAboveAverage.ToString("n1");

            numBelowAverage = BelowAverage(scoresList, average);
            belowAverageLabel.Text = numBelowAverage.ToString("n1");
        }

        private void GetScoreFromFile(List<int> scores)
        {
            StreamReader inputFile = null;
          
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);

                while (!inputFile.EndOfStream)
                {
                    scores.Add(int.Parse(inputFile.ReadLine()));
                }
            }
            else
            {
                MessageBox.Show("已取消");
            }

            inputFile.Close();
        }

        private double Average(List<int> scores)
        {
            int sum = 0;
            /*for (int i = 0; i < scores.Count; i++)
            {
                sum += scores[i];
            }*/

            foreach(int value in scores)
            {
                sum += value;
            }

            return (double)sum / scores.Count;
        }

        private int AboveAverage(List<int> scores, double average)
        {
            //double average = Average(scores);
            int numAbove = 0;

            foreach (int value in scores)
            {
                if(value > average)
                {
                    numAbove++;
                }
            }

            return numAbove;
        }

        private int BelowAverage(List<int> scores, double average)
        {
            int numAbelow = 0;

            foreach (int value in scores)
            {
                if (value < average)
                {
                    numAbelow++;
                }
            }

            return numAbelow;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(indexTestbox.Text);
            if(pos >=0 && pos < scoresList.Count)
            {
                scoresList.RemoveAt(pos);
                testScoresListBox.Items.Clear();

                foreach (int value in scoresList)
                {
                    testScoresListBox.Items.Add(value);
                }

            }
        }
    }
}
