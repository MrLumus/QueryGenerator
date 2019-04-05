namespace QueryGenerator
{
    partial class FormQueryGenerator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueryGenerator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSelect = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbSelectWhere = new System.Windows.Forms.ListBox();
            this.btnSelectAddWhere = new System.Windows.Forms.Button();
            this.txtSelectOperand = new System.Windows.Forms.ComboBox();
            this.txtSelectSecondWhere = new System.Windows.Forms.TextBox();
            this.txtSelectFirstWhere = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSelectNo = new System.Windows.Forms.RadioButton();
            this.cbSelectYes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectAddTable = new System.Windows.Forms.TextBox();
            this.btnSelectAddTable = new System.Windows.Forms.Button();
            this.btnSelectAddColumn = new System.Windows.Forms.Button();
            this.lbSelectTables = new System.Windows.Forms.ListBox();
            this.lbSelectColumns = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelectAddColumn = new System.Windows.Forms.TextBox();
            this.tbInsert = new System.Windows.Forms.TabPage();
            this.tbDelete = new System.Windows.Forms.TabPage();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.cmsSelectColumn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSelectTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSelectWhere = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripDeleteWhere = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpSelect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsSelectColumn.SuspendLayout();
            this.cmsSelectTable.SuspendLayout();
            this.cmsSelectWhere.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSelect);
            this.tabControl1.Controls.Add(this.tbInsert);
            this.tabControl1.Controls.Add(this.tbDelete);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 633);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSelect
            // 
            this.tpSelect.Controls.Add(this.btnSelect);
            this.tpSelect.Controls.Add(this.lbSelectWhere);
            this.tpSelect.Controls.Add(this.btnSelectAddWhere);
            this.tpSelect.Controls.Add(this.txtSelectOperand);
            this.tpSelect.Controls.Add(this.txtSelectSecondWhere);
            this.tpSelect.Controls.Add(this.txtSelectFirstWhere);
            this.tpSelect.Controls.Add(this.groupBox1);
            this.tpSelect.Controls.Add(this.label1);
            this.tpSelect.Controls.Add(this.txtSelectAddTable);
            this.tpSelect.Controls.Add(this.btnSelectAddTable);
            this.tpSelect.Controls.Add(this.btnSelectAddColumn);
            this.tpSelect.Controls.Add(this.lbSelectTables);
            this.tpSelect.Controls.Add(this.lbSelectColumns);
            this.tpSelect.Controls.Add(this.label4);
            this.tpSelect.Controls.Add(this.label2);
            this.tpSelect.Controls.Add(this.label3);
            this.tpSelect.Controls.Add(this.txtSelectAddColumn);
            this.tpSelect.Location = new System.Drawing.Point(4, 33);
            this.tpSelect.Margin = new System.Windows.Forms.Padding(6);
            this.tpSelect.Name = "tpSelect";
            this.tpSelect.Padding = new System.Windows.Forms.Padding(6);
            this.tpSelect.Size = new System.Drawing.Size(651, 596);
            this.tpSelect.TabIndex = 0;
            this.tpSelect.Text = "Select";
            this.tpSelect.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.Location = new System.Drawing.Point(16, 549);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(620, 33);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Сформировать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbSelectWhere
            // 
            this.lbSelectWhere.FormattingEnabled = true;
            this.lbSelectWhere.ItemHeight = 24;
            this.lbSelectWhere.Location = new System.Drawing.Point(329, 370);
            this.lbSelectWhere.Name = "lbSelectWhere";
            this.lbSelectWhere.Size = new System.Drawing.Size(307, 172);
            this.lbSelectWhere.TabIndex = 9;
            // 
            // btnSelectAddWhere
            // 
            this.btnSelectAddWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAddWhere.Location = new System.Drawing.Point(16, 510);
            this.btnSelectAddWhere.Name = "btnSelectAddWhere";
            this.btnSelectAddWhere.Size = new System.Drawing.Size(307, 33);
            this.btnSelectAddWhere.TabIndex = 8;
            this.btnSelectAddWhere.Text = "Добавить";
            this.btnSelectAddWhere.UseVisualStyleBackColor = true;
            this.btnSelectAddWhere.Click += new System.EventHandler(this.btnSelectAddWhere_Click);
            // 
            // txtSelectOperand
            // 
            this.txtSelectOperand.DropDownWidth = 100;
            this.txtSelectOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSelectOperand.FormattingEnabled = true;
            this.txtSelectOperand.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "IN",
            "BETWEEN"});
            this.txtSelectOperand.Location = new System.Drawing.Point(138, 471);
            this.txtSelectOperand.Name = "txtSelectOperand";
            this.txtSelectOperand.Size = new System.Drawing.Size(56, 28);
            this.txtSelectOperand.TabIndex = 7;
            // 
            // txtSelectSecondWhere
            // 
            this.txtSelectSecondWhere.Location = new System.Drawing.Point(200, 471);
            this.txtSelectSecondWhere.Name = "txtSelectSecondWhere";
            this.txtSelectSecondWhere.Size = new System.Drawing.Size(123, 29);
            this.txtSelectSecondWhere.TabIndex = 6;
            // 
            // txtSelectFirstWhere
            // 
            this.txtSelectFirstWhere.Location = new System.Drawing.Point(16, 471);
            this.txtSelectFirstWhere.Name = "txtSelectFirstWhere";
            this.txtSelectFirstWhere.Size = new System.Drawing.Size(116, 29);
            this.txtSelectFirstWhere.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSelectNo);
            this.groupBox1.Controls.Add(this.cbSelectYes);
            this.groupBox1.Location = new System.Drawing.Point(21, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наличие условий";
            // 
            // cbSelectNo
            // 
            this.cbSelectNo.AutoSize = true;
            this.cbSelectNo.Checked = true;
            this.cbSelectNo.Location = new System.Drawing.Point(64, 32);
            this.cbSelectNo.Name = "cbSelectNo";
            this.cbSelectNo.Size = new System.Drawing.Size(62, 28);
            this.cbSelectNo.TabIndex = 1;
            this.cbSelectNo.TabStop = true;
            this.cbSelectNo.Text = "Нет";
            this.cbSelectNo.UseVisualStyleBackColor = true;
            // 
            // cbSelectYes
            // 
            this.cbSelectYes.AutoSize = true;
            this.cbSelectYes.Location = new System.Drawing.Point(6, 32);
            this.cbSelectYes.Name = "cbSelectYes";
            this.cbSelectYes.Size = new System.Drawing.Size(52, 28);
            this.cbSelectYes.TabIndex = 0;
            this.cbSelectYes.Text = "Да";
            this.cbSelectYes.UseVisualStyleBackColor = true;
            this.cbSelectYes.CheckedChanged += new System.EventHandler(this.cbSelectYes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 444);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Условие";
            // 
            // txtSelectAddTable
            // 
            this.txtSelectAddTable.Location = new System.Drawing.Point(329, 47);
            this.txtSelectAddTable.Name = "txtSelectAddTable";
            this.txtSelectAddTable.Size = new System.Drawing.Size(195, 29);
            this.txtSelectAddTable.TabIndex = 4;
            // 
            // btnSelectAddTable
            // 
            this.btnSelectAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAddTable.Location = new System.Drawing.Point(530, 47);
            this.btnSelectAddTable.Name = "btnSelectAddTable";
            this.btnSelectAddTable.Size = new System.Drawing.Size(103, 29);
            this.btnSelectAddTable.TabIndex = 3;
            this.btnSelectAddTable.Text = "Добавить";
            this.btnSelectAddTable.UseVisualStyleBackColor = true;
            this.btnSelectAddTable.Click += new System.EventHandler(this.btnSelectAddTable_Click);
            // 
            // btnSelectAddColumn
            // 
            this.btnSelectAddColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAddColumn.Location = new System.Drawing.Point(220, 47);
            this.btnSelectAddColumn.Name = "btnSelectAddColumn";
            this.btnSelectAddColumn.Size = new System.Drawing.Size(103, 29);
            this.btnSelectAddColumn.TabIndex = 3;
            this.btnSelectAddColumn.Text = "Добавить";
            this.btnSelectAddColumn.UseVisualStyleBackColor = true;
            this.btnSelectAddColumn.Click += new System.EventHandler(this.btnSelectAddColumn_Click);
            // 
            // lbSelectTables
            // 
            this.lbSelectTables.FormattingEnabled = true;
            this.lbSelectTables.ItemHeight = 24;
            this.lbSelectTables.Location = new System.Drawing.Point(329, 85);
            this.lbSelectTables.Name = "lbSelectTables";
            this.lbSelectTables.Size = new System.Drawing.Size(307, 268);
            this.lbSelectTables.TabIndex = 2;
            // 
            // lbSelectColumns
            // 
            this.lbSelectColumns.FormattingEnabled = true;
            this.lbSelectColumns.ItemHeight = 24;
            this.lbSelectColumns.Location = new System.Drawing.Point(16, 85);
            this.lbSelectColumns.Name = "lbSelectColumns";
            this.lbSelectColumns.Size = new System.Drawing.Size(307, 268);
            this.lbSelectColumns.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выбираемые данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 1;
            // 
            // txtSelectAddColumn
            // 
            this.txtSelectAddColumn.Location = new System.Drawing.Point(16, 47);
            this.txtSelectAddColumn.Margin = new System.Windows.Forms.Padding(6);
            this.txtSelectAddColumn.Name = "txtSelectAddColumn";
            this.txtSelectAddColumn.Size = new System.Drawing.Size(195, 29);
            this.txtSelectAddColumn.TabIndex = 0;
            // 
            // tbInsert
            // 
            this.tbInsert.Location = new System.Drawing.Point(4, 33);
            this.tbInsert.Margin = new System.Windows.Forms.Padding(6);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Padding = new System.Windows.Forms.Padding(6);
            this.tbInsert.Size = new System.Drawing.Size(651, 596);
            this.tbInsert.TabIndex = 1;
            this.tbInsert.Text = "Insert";
            this.tbInsert.UseVisualStyleBackColor = true;
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(4, 33);
            this.tbDelete.Margin = new System.Windows.Forms.Padding(6);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(651, 596);
            this.tbDelete.TabIndex = 2;
            this.tbDelete.Text = "Delete";
            this.tbDelete.UseVisualStyleBackColor = true;
            // 
            // tpUpdate
            // 
            this.tpUpdate.Location = new System.Drawing.Point(4, 33);
            this.tpUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Size = new System.Drawing.Size(651, 596);
            this.tpUpdate.TabIndex = 3;
            this.tpUpdate.Text = "Update";
            this.tpUpdate.UseVisualStyleBackColor = true;
            // 
            // cmsSelectColumn
            // 
            this.cmsSelectColumn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDeleteColumn});
            this.cmsSelectColumn.Name = "contextMenuStrip1";
            this.cmsSelectColumn.ShowImageMargin = false;
            this.cmsSelectColumn.Size = new System.Drawing.Size(94, 26);
            // 
            // toolStripDeleteColumn
            // 
            this.toolStripDeleteColumn.Name = "toolStripDeleteColumn";
            this.toolStripDeleteColumn.Size = new System.Drawing.Size(93, 22);
            this.toolStripDeleteColumn.Text = "Удалить";
            this.toolStripDeleteColumn.Click += new System.EventHandler(this.toolStripDeleteColumn_Click);
            // 
            // cmsSelectTable
            // 
            this.cmsSelectTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDelete});
            this.cmsSelectTable.Name = "cmsSelectTable";
            this.cmsSelectTable.Size = new System.Drawing.Size(119, 26);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(118, 22);
            this.toolStripDelete.Text = "Удалить";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // cmsSelectWhere
            // 
            this.cmsSelectWhere.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDeleteWhere});
            this.cmsSelectWhere.Name = "cmsSelectWhere";
            this.cmsSelectWhere.Size = new System.Drawing.Size(119, 26);
            // 
            // toolStripDeleteWhere
            // 
            this.toolStripDeleteWhere.Name = "toolStripDeleteWhere";
            this.toolStripDeleteWhere.Size = new System.Drawing.Size(118, 22);
            this.toolStripDeleteWhere.Text = "Удалить";
            this.toolStripDeleteWhere.Click += new System.EventHandler(this.toolStripDeleteWhere_Click);
            // 
            // FormQueryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 635);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormQueryGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор запросов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSelect.ResumeLayout(false);
            this.tpSelect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsSelectColumn.ResumeLayout(false);
            this.cmsSelectTable.ResumeLayout(false);
            this.cmsSelectWhere.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSelect;
        private System.Windows.Forms.TabPage tbInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectAddColumn;
        private System.Windows.Forms.TabPage tbDelete;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.Button btnSelectAddColumn;
        private System.Windows.Forms.ListBox lbSelectColumns;
        private System.Windows.Forms.TextBox txtSelectAddTable;
        private System.Windows.Forms.Button btnSelectAddTable;
        private System.Windows.Forms.ListBox lbSelectTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSelectWhere;
        private System.Windows.Forms.Button btnSelectAddWhere;
        private System.Windows.Forms.ComboBox txtSelectOperand;
        private System.Windows.Forms.TextBox txtSelectSecondWhere;
        private System.Windows.Forms.TextBox txtSelectFirstWhere;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cbSelectNo;
        private System.Windows.Forms.RadioButton cbSelectYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmsSelectColumn;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteColumn;
        private System.Windows.Forms.ContextMenuStrip cmsSelectTable;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelete;
        private System.Windows.Forms.ContextMenuStrip cmsSelectWhere;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteWhere;
    }
}

