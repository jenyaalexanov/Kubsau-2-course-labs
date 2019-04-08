using lab3.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> a = File.ReadAllLines("Files/a.txt"
               .ToApplicationPath())
               .ToList();
                List<string> b = File.ReadAllLines("Files/b.txt"
                    .ToApplicationPath())
                    .ToList();

                var orderA = a
                    .OrderBy(x => x.Count())
                    .ToList();
                var orderB = b
                    .OrderBy(x => x.Count())
                    .ToList();

                var longA = orderA.Last();

                a[a.IndexOf(longA)] = orderB.First();
                b[b.IndexOf(orderB.First())] = longA;

                File.WriteAllLines("Files/a.txt"
                    .ToApplicationPath(), a);
                File.WriteAllLines("Files/b.txt"
                    .ToApplicationPath(), b);
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка! {ex.Message}");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> a = File.ReadAllLines("Files/a.txt"
               .ToApplicationPath())
               .ToList();
                List<string> b = File.ReadAllLines("Files/b.txt"
                    .ToApplicationPath())
                    .ToList();

                var orderA = a
                    .OrderBy(x => x.Count())
                    .ToList();
                var orderB = b
                    .OrderBy(x => x.Count())
                    .ToList();

                var longB = orderB.Last();


                b[b.IndexOf(longB)] = orderA.First();
                a[a.IndexOf(orderA.First())] = longB;

                File.WriteAllLines("Files/a.txt"
                    .ToApplicationPath(), a);
                File.WriteAllLines("Files/b.txt"
                    .ToApplicationPath(), b);
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка! {ex.Message}");
            }
        }
    }
}
