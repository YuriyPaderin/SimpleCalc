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
            var view = (DataRowView)gridView1.GetFocusedRow();

            var form = new Form2(view);
            form.ShowDialog();
            form.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
            dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
        }
    }
}
