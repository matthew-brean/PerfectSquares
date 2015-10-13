using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Squares
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //variables
            int counter;
            int maxNumber;
            double currentValue;
            double squareRootAsDouble; //variables from flowchart
            int squareRootAsInteger; //"
            int numberOfPerfectSquares = 0;

            this.lstPerfectSquares.Items.Clear();
            currentValue = 0;
            maxNumber = Convert.ToInt32(this.nudNumber.Value);
            counter = 0;

            
                while (currentValue <= maxNumber) 

                {
                    squareRootAsDouble = Math.Sqrt(currentValue);                    squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                    if (squareRootAsInteger == squareRootAsDouble)
                    {
                        numberOfPerfectSquares++;
                        this.lstPerfectSquares.Items.Add(currentValue);
                        currentValue++;
                    }
                    else                    {
                        currentValue++;                    }




                }

        }
    }
}
