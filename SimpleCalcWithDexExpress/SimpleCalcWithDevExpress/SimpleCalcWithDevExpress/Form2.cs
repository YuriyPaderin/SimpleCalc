using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalcWithDevExpress
{
    public partial class Form2 : Form
    {
        public DataRowView View { get; private set; }

        public Form2(DataRowView view)
        {
            InitializeComponent();

            View = view;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textEdit1.EditValue = View.Row["Expression"];
            textEdit2.EditValue = View.Row["Result"];
            textEdit3.EditValue = View.Row["DateAndTime"];
            textEdit4.EditValue = View.Row["HostName"];
            textEdit5.EditValue = View.Row["ErrorCode"];
            textEdit6.EditValue = View.Row["Message"];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            View.BeginEdit();
            View.Row["Expression"] = textEdit1.EditValue;
            View.Row["Result"] = textEdit2.EditValue;
            View.Row["DateAndTime"] = textEdit3.EditValue;
            View.Row["HostName"] = textEdit4.EditValue;
            View.Row["ErrorCode"] = textEdit5.EditValue;
            View.Row["Message"] = textEdit6.EditValue;
            View.EndEdit();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
