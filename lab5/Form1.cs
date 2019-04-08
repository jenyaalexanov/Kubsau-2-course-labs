using lab5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var models = new List<ModelForm1>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                var model = new ModelForm1();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    switch (cell.ColumnIndex)
                    {
                        case 0:
                            try
                            {
                                model.FIO = cell.Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                model.FIO = "";
                                MessageBox.Show("Ошибка при конвертированнии ФИО " + ex.Message);
                            }
                            continue;
                        case 1:
                            try
                            {
                                model.Adress = cell.Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                model.Adress = "";
                                MessageBox.Show("Ошибка при конвертированнии адреса " + ex.Message);
                            }
                            continue;
                        case 2:
                            try
                            {
                                model.Car = cell.Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                model.Car = "";
                                MessageBox.Show("Ошибка при конвертированнии марки машины " + ex.Message);
                            }
                            continue;
                    }
                }
                models.Add(model);
            }
            var modelResults = models.Where(x => x.Car.ToLower() == "audi")
                .OrderBy(x => x.FIO)
                .Select(x => x).ToList();

            new Form2(modelResults).ShowDialog();
        }
    }
}
