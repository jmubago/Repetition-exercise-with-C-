using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RepApps
{
    public partial class FrmRepApps : Form
    {
        public FrmRepApps()
        {
            InitializeComponent();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            double radius;
            double area;
            const double PI=3.14;

            while(true)
            {
                radius= Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the Radius","Area","",200,200));

                if (radius<0)
                {
                    MessageBox.Show("no negatives please");
                }
                else
                {
                    area=PI*Math.Pow(radius,2);
                    MessageBox.Show("Area is " + area.ToString("n2"));
                }

                string response = Microsoft.VisualBasic.Interaction.InputBox("Any more entries y/n","Area","",200,200);

                if (response=="n")
                    break;
            }

        }

        private void BtnFahrenheitCelsius_Click(object sender, EventArgs e)
        {
            int celsius = 0;
            double fahrenheit;

            TxtAnswers.Text = "Celsius" + "  " + "Fahrenheit" + Environment.NewLine;

            while (celsius <= 20)
            {
                fahrenheit = celsius * 9.0 / 5 + 32;
                TxtAnswers.Text+= celsius.ToString() + "\t" + fahrenheit.ToString() + Environment.NewLine;
                
                celsius++;
            }

        }

        private void BtnForSum_Click(object sender, EventArgs e)
        {
            double sum=0;

            for (int i = 1; i <= 100; i += 2)
            {
                sum += Math.Pow(i, 3);
            }

            MessageBox.Show("Sum of the cubes of the odd numbers between 1 and 100 " + "\n is " + sum.ToString());
        }

        private void BtnNestFor_Click(object sender, EventArgs e)
        {
            double area;

            TxtAnswers.Text = "Length" + "  " + "Width" + "    " +"Area"  + Environment.NewLine;

            for (int length = 1; length <= 5; length++)
            {
                for (int wid = 5; wid <= 20; wid += 5)
                {
                    area = length * wid;
                    TxtAnswers.Text += length.ToString() + "\t" + wid.ToString() + "\t" + area.ToString() + Environment.NewLine;
                }
            }
        }

        private void BtnSteamCharge_Click(object sender, EventArgs e)
        {
            for (int i=1; i<=3; i++)
            {
                if (i < 3)
                {
                    TxtAnswers.Text += i.ToString() + " Steamboat" + Environment.NewLine;
                }
                else
                {
                    TxtAnswers.Text += "CHARGE !";
                }
            }
        }

        private void BtnGallonsLiters_Click(object sender, EventArgs e)
        {
            double Gallon= 0.264172;

            TxtAnswers.Text = "Litres" + "\t" + "Gallons" + Environment.NewLine;

            for (int Litres= 20; Litres <= 60; Litres= Litres + 4)
            {
                double TotalGallons= Litres * Gallon;
                TxtAnswers.Text += Litres.ToString() + "\t " + TotalGallons.ToString("n2") + Environment.NewLine;
            }
        }

        private void BtnMileKm_Click(object sender, EventArgs e)
        {
            int Mile;
            double Km = 1.61;

            while (true)
            {
                Mile = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce your mileage", "Mile to km conversor", ""));

                if(Mile < 0)
                {
                    TxtAnswers.Text = "Please enter a positive number";
                }
                else
                {
                    double FinalKm = Mile * Km;
                    MessageBox.Show(Mile.ToString() + " miles are " + FinalKm.ToString("n2") + " Kms");
                }
                string response = Microsoft.VisualBasic.Interaction.InputBox("Do you want to keep converting miles to kms, y/n", "", "");
                if (response == "n" || response == "no" || response == "cancelar")
                {
                    break;
                }
            }

        }

        private void FrmRepApps_Load(object sender, EventArgs e)
        {

        }
    }
}