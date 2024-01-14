using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MayorYMenor
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int edad = Convert.ToInt32(textBox1.Text);
                if (edad >= 80)
                {
                    label1.Text = "Usted es de la tercera edad";
                }
                else if (edad >= 18)
                {
                    label1.Text = "Usted es mayor";
                }
                else if (edad < 18)
                {
                    label1.Text = "Usted es menor";
                }
            }
            else
            {
                label1.Text = "No se ingreso ningun valor";
            }
        }

    }

}



