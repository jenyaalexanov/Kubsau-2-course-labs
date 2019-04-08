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
    public partial class Form2 : Form
    {
        public Form2(List<ModelForm1> modelForm1s)
        {
            InitializeComponent();

            dataGridView1.Rows.Add(modelForm1s.Count);

            var index = 0;
            foreach (var modelForm1 in modelForm1s)
            {
                var row = dataGridView1.Rows[index++];
                row.Cells[0].Value = modelForm1.FIO;
                row.Cells[1].Value = modelForm1.Adress;
                row.Cells[2].Value = modelForm1.Car;
            }
        }
    }
}
