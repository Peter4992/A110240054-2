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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        private const int SIZE = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            int[] scores = new int[SIZE];
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0;
            double medianScore = 0;

            GetScoreFromFile(scores);

            foreach(int value in scores)
            {
                testScoresListBox.Items.Add(value);
            }

            highestScore = Highest(scores);
            highScoreLabel.Text = highestScore.ToString();

            lowestScore = Lowest(scores);
            lowScoreLabel.Text = lowestScore.ToString();

            averageScore = Average(scores);
            averageScoreLabel.Text = averageScore.ToString();

            medianScore = Median(scores);
            medianScoreLabel.Text = medianScore.ToString();
        }

        private void GetScoreFromFile(int[] scores)
        {
            StreamReader inputFile = null;
            int index = 0;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
            }
            else
            {
                MessageBox.Show("已取消");
            }

            inputFile.Close();
        }

        private int Highest(int[] scores)
        {
            int highest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                }
            }
            return highest;
        }

        private int Lowest(int[] scores)
        {
            int lowest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < lowest)
                {
                    lowest = scores[i];
                }
            }
            return lowest;
        }

        private double Average(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            return (double)sum / scores.Length;
        }

        private double Median(int[] scores)
        {
            Array.Sort(scores);

            foreach (int value in scores)
            {
                sortedScoresListBox.Items.Add(value);
            }

            double median = 0;

            if (scores.Length % 2 == 0)
            {
                // 如果陣列長度為偶數，中位數為中間兩個數的平均值
                int middleIndex1 = scores.Length / 2 - 1;
                int middleIndex2 = scores.Length / 2;
                median = (scores[middleIndex1] + scores[middleIndex2]) / 2.0;
            }
            else
            {
                // 如果陣列長度為奇數，中位數為中間那個數
                int middleIndex = scores.Length / 2;
                median = scores[middleIndex];
            }

            return median;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
