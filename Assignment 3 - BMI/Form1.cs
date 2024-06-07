using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3___BMI
{
    public partial class Form1 : Form
    {
        bool USAunit = false;
        private double bmi;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method gets the Users name.
        /// </summary>
        /// <returns>The Users input for name</returns>
        private string getResultName()
        {
            if (txt1.Text == string.Empty) 
            {
                return "Incognito";
            }
            return txt1.Text;
        }

        /// <summary>
        /// This method gets the Users height.
        /// </summary>
        /// <returns>The Users input for height</returns>
        private string getTall()
        {
            return txt2.Text;
        }

        /// <summary>
        /// This method get Users weight.
        /// </summary>
        /// <returns>The Users input for weight</returns>
        private string getHeavy()
        {
            return txt3.Text;
        }

        /// <summary>
        /// This mathod sets the name of the groupbox.
        /// </summary>
        /// <param name="name"></param>
        private void setResultName(string name)
        {
            resultBox.Text = ($"Results for {name}");
            
        }

        /// <summary>
        /// This method sets the Users BMI value for display.
        /// </summary>
        /// <param name="value"></param>
        private void setResult1(string value)
        {
            resultTxt1.Text = value;
        }

        /// <summary>
        /// This method sets the Users BMI category for display.
        /// </summary>
        /// <param name="value"></param>
        private void setResult2(string value)
        {
            resultTxt2.Text = value;
        }

        /// <summary>
        /// This method places th User into the Users BMI categorys based on the calculated BMI.
        /// </summary>
        /// <param name="i"></param>
        private void nutritionalStatus(double i)
        {
            setResult1(i.ToString());

            if (i < 18.5)
            {

                setResult2("Underweight");

            } 
            else if (i >= 18.5 && i <= 24.9)
                {

                setResult2("Normal weight");
            }
            else if (i >= 25.0 && i <= 29.9)
            {
                
                setResult2("Overweight (Pre-obesity)");
            }
            else if (i >= 30.5 && i <= 34.9)
            {
                
                setResult2("Overweight (Obesity class I)");
            }
            else if (i >= 35.5 && i <= 39.9)
            {
               
                setResult2("Overweight (Obesity class II)");
            }
            else if (i >= 40.0)
            {
                
                setResult2("Overweight (Obesity class III)");
            }
        }

        /// <summary>
        /// This method calculates the Users BMI deppending on metric or imperial units using h for weight and t for height.
        /// </summary>
        /// <param name="h"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        private string calcBMI(double h, double t)
        {
            

            if (USAunit)
            {
                t = t * 12;

                bmi = 703 * (h / (t * t));
            }
            else
            {
                t = t/ 100;
               bmi = h / (t * t);
            }
            

            return string.Format("{0:0.##}", bmi);
        }

        /// <summary>
        /// This changes the labels and example texts to the metric system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EUunitbtn_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Height (cm)";
            label3.Text = "Weight (kg)";
            label7.Text = "e.g. 183cm = 1.83";
            label8.Text = "e.g. 100kg = 100";
            USAunit = false;
        }

        /// <summary>
        /// This changes the labels and example texts to the imperial system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void USunitBtn_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Height (foot)";
            label3.Text = "Weight (lbs)";
            label7.Text = "e.g. 5\"0 = 5.0";
            label8.Text = "e.g. 99.5lbs = 99.5";
            USAunit = true;
        }

        /// <summary>
        /// This method gets executed with the button <code>Calculate</code> gets clicked and starts the nutritionalStatus() method inside the try-catch 
        /// to calculate the Users weight and height using the getters.
        /// The strings from the getters is using the <code>Replace()</code> to adjust the "." to "," to avoid invalid input fromt he user.
        /// If a exception occurs, a message is showed in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nutritionalStatus(double.Parse(calcBMI(double.Parse($"{getHeavy().Replace(".", ",")}"), double.Parse($"{getTall().Replace(".", ",")}"))));
                resultBox.Text = ($"Results for {getResultName()}");
            }
            catch (Exception ex)
            {
                resultTxt1.Text = "";
                setResult2("Invalid input values! Retry...");
            }
        }
    }
}
