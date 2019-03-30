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
    public partial class FormResult : Form
    {
        public FormResult(List<GroupResult> groupResults)
        {
            InitializeComponent();
            foreach (var groupResult in groupResults)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                var row = dataGridView1.Rows[dataGridView1.Rows.Count-1];
                row.Cells[0].Value = groupResult.Contry;
                row.Cells[1].Value = groupResult.StudentCount;
            }
        }
    }
}
