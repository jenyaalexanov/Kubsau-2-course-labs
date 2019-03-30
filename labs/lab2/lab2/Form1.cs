using lab2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var students = new List<Student>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                var student = new Student();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    switch (cell.ColumnIndex)
                    {
                        case 0:
                            try
                            {
                                student.FIO = cell.Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                student.FIO = "";
                                MessageBox.Show("Ошибка при конвертированнии ФИО " + ex.Message);
                            }
                            continue;
                        case 1:
                            try
                            {
                                student.Year = Convert.ToInt32(cell.Value);
                            }
                            catch (Exception ex)
                            {
                                student.Year = 0;
                                MessageBox.Show("Ошибка при конвертированнии возраста " + ex.Message);
                            }
                            continue;
                        case 2:
                            try
                            {
                                student.Contry = cell.Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                student.Contry = "";
                                MessageBox.Show("Ошибка при конвертированнии региона " + ex.Message);
                            }
                            continue;

                        case 3:
                            try
                            {
                                student.Faculty = cell.Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                student.Faculty = "";
                                MessageBox.Show("Ошибка при конвертированнии факультета " + ex.Message);
                            }
                            continue;
                    }
                }
                students.Add(student);
            }
            var groupResults = new List<GroupResult>();

            var groupByContry = students.GroupBy(x => x.Contry).Select(x => x.ToList());

            foreach (var contry in groupByContry)
            {
                groupResults.Add(new GroupResult()
                {
                    Contry = contry.First().Contry,
                    StudentCount = contry.Count()
                });   
            }
            new FormResult(groupResults).ShowDialog();
        }
    }
}
