using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleCalc;

namespace SimpleCalcWithDevExpress
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private bool _dataModificationStage = false;
        private string[] _errorTable = { "Вы ввели неизвестную операцию.", "Неверный формат строки.", "Неверное соотношение цифр и операций.", "Неизвестный тип ошибки" };

        public Form1()
        {
            InitializeComponent();
        }

        private void EvalButton_Click(object sender, EventArgs e)
        {
            if (textEdit1.EditValue != null)
            {
                int errorCode;
                var result = new Calculator().Evaluate(textEdit1.EditValue.ToString(), out errorCode);
                var expression = textEdit1.EditValue.ToString();
                var message = errorCode == 0 ? result.ToString() : _errorTable[errorCode - 1];

                textEdit1.EditValue = errorCode == 0 ? textEdit1.EditValue + " = " + result.ToString() : _errorTable[errorCode - 1];

                this.dataBaseForSimpleCalcDataSet.Notes.AddNotesRow(new Guid(), expression, result, DateTime.Now, "localhost", errorCode, message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseForSimpleCalcDataSet.Notes' table. You can move, or remove it, as needed.
            this.notesTableAdapter.Fill(this.dataBaseForSimpleCalcDataSet.Notes);
            foreach (var note in this.dataBaseForSimpleCalcDataSet.Notes)
                if(!note.IsResultNull() || note.ErrorCode != 0)
                    note.Message = note.ErrorCode == 0 ? note.Result.ToString() : _errorTable[note.ErrorCode - 1];
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _dataModificationStage = !_dataModificationStage;
            EditButton.ForeColor = _dataModificationStage ? Color.Blue : Color.Black;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (_dataModificationStage)
            {
                var view = (DataRowView)gridView1.GetFocusedRow();

                var form = new Form2(view);
                form.Show();

                view = form.View;
            }
        }
    }
}
