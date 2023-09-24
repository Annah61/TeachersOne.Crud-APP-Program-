using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachersOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teachersDataSet.tb_Teachers' table. You can move, or remove it, as needed.
            this.tb_TeachersTableAdapter.Fill(this.teachersDataSet.tb_Teachers);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbTeachersBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbTeachersBindingSource.EndEdit();
            tb_TeachersTableAdapter.Update(teachersDataSet.tb_Teachers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbTeachersBindingSource.RemoveCurrent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbTeachersBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbTeachersBindingSource.MoveLast();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tbTeachersBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbTeachersBindingSource.MoveNext();
        }
    }
}
