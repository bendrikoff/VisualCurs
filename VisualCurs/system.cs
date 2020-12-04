using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCurs
{
    public partial class system : Form
    {
        public system()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int _int = Convert.ToInt32(textBox1.Text, Convert.ToInt32(comboBox1.SelectedItem.ToString()));

                resultLabel.Text = "Результат: " + Convert.ToString(_int, Convert.ToInt32(comboBox2.SelectedItem.ToString()));

                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(textBox1, "Неправильный формат ввода");
            }
        }
    }
}
