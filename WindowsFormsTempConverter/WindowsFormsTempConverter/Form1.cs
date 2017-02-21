using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double temp = Double.Parse(this.tempTextBox.Text);
            TempUnits original = (TempUnits) Enum.Parse(typeof(TempUnits), this.originalDropDown.Text, true);
            TempUnits converted = (TempUnits) Enum.Parse(typeof(TempUnits), this.convertedDropDown.Text, true);
            this.answerLabel.Text = Utilities.universalConverter(original, converted, temp).ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
