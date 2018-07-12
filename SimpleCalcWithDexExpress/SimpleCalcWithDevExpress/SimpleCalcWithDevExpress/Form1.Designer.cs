namespace SimpleCalcWithDevExpress
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.EvalButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.notesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseForSimpleCalcDataSet = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExpression = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateAndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditButton = new DevExpress.XtraEditors.SimpleButton();
            this.notesTableAdapter = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(769, 26);
            this.textEdit1.TabIndex = 0;
            // 
            // EvalButton
            // 
            this.EvalButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EvalButton.Appearance.Options.UseFont = true;
            this.EvalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EvalButton.Location = new System.Drawing.Point(787, 10);
            this.EvalButton.Name = "EvalButton";
            this.EvalButton.Size = new System.Drawing.Size(75, 28);
            this.EvalButton.TabIndex = 1;
            this.EvalButton.Text = "Расчет";
            this.EvalButton.Click += new System.EventHandler(this.EvalButton_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridControl1.DataSource = this.notesBindingSource2;
            this.gridControl1.Location = new System.Drawing.Point(12, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.gridControl1.Size = new System.Drawing.Size(931, 573);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // notesBindingSource2
            // 
            this.notesBindingSource2.DataMember = "Notes";
            this.notesBindingSource2.DataSource = this.dataBaseForSimpleCalcDataSet;
            // 
            // dataBaseForSimpleCalcDataSet
            // 
            this.dataBaseForSimpleCalcDataSet.DataSetName = "DataBaseForSimpleCalcDataSet";
            this.dataBaseForSimpleCalcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExpression,
            this.colResult,
            this.DateAndTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DateAndTime, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colExpression
            // 
            this.colExpression.Caption = "Выражение";
            this.colExpression.FieldName = "Expression";
            this.colExpression.Name = "colExpression";
            this.colExpression.Visible = true;
            this.colExpression.VisibleIndex = 0;
            // 
            // colResult
            // 
            this.colResult.Caption = "Результат";
            this.colResult.FieldName = "Message";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.ShowInCustomizationForm = false;
            this.colResult.OptionsColumn.ShowInExpressionEditor = false;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 1;
            // 
            // DateAndTime
            // 
            this.DateAndTime.FieldName = "DateAndTime";
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // EditButton
            // 
            this.EditButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Appearance.Options.UseFont = true;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Location = new System.Drawing.Point(868, 10);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 28);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Изменить";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 629);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.EvalButton);
            this.Controls.Add(this.textEdit1);
            this.Name = "Form1";
            this.Text = "SimpleCalcWithDevExpress";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton EvalButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colExpression;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.SimpleButton EditButton;
        private DataBaseForSimpleCalcDataSet dataBaseForSimpleCalcDataSet;
        private System.Windows.Forms.BindingSource notesBindingSource2;
        private DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn DateAndTime;
    }
}

