using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateAndUpdate1
{
    public partial class CreateForm : Form
    {
        private StudentManagement business;
        public CreateForm()
        {
            InitializeComponent();
            this.business = new StudentManagement();
      
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            business.CreateStudent(txtCode, txtName, Gender, RTXTHomeTown);
        }

     
    }
}
