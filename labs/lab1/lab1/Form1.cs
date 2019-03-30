using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class form : Form
    {

        public string[] female = new string[]
        {
            "ова",
            "ева",
            "на",
            "ина",
            "ая",
            "яя"
        };

        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе фамилии " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (string item in listBox1.Items)
            {
                try
                {
                    if (female.Any(x => item.EndsWith(x)))
                    {
                        listBox2.Items.Add(item);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при фильтрации фамилии {item.ToString()}. Ошибка " + ex.Message);
                }
               
            }
        }
    }
}
