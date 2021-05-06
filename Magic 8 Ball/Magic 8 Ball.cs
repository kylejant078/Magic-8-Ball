using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_Ball
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int value;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button8Ball_Click(object sender, EventArgs e)
        {
            value = randGen.Next(1, 7);
            switch (value)
            {
                case 1:
                    outputLabel.Text = "Very likely";
                    break;
                case 2:
                    outputLabel.Text = "Certain";
                    break;
                case 3:
                    outputLabel.Text = "Probably not";
                    break;
                case 4:
                    outputLabel.Text = "Not a chance";
                    break;
                case 5:
                    outputLabel.Text = "Maybe";
                    break;
                case 6:
                    outputLabel.Text = "Likely";
                    break;

            }
        }
    }
}
