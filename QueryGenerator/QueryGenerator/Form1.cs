using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryGenerator
{
    public partial class FormQueryGenerator : Form
    {
        public FormQueryGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Контекстное меню для лист-боксов
            lbSelectColumns.ContextMenuStrip = cmsSelectColumn;
            lbSelectTables.ContextMenuStrip = cmsSelectTable;
            lbSelectWhere.ContextMenuStrip = cmsSelectWhere;
            lbInsertColumns.ContextMenuStrip = cmsInsertColumn;
            lbInsertValues.ContextMenuStrip = cmsInsertValue;
            lbInsertWhere.ContextMenuStrip = cmsInsertWhere;

            //Если нажата радио-кнопка "Нет" в условиях, то форма с условиями деактивируется
            bool check = cbSelectYes.Checked;
            if (!check)
            {
                txtSelectFirstWhere.Enabled = false;
                txtSelectOperand.Enabled = false;
                txtSelectSecondWhere.Enabled = false;
                btnSelectAddWhere.Enabled = false;
                lbSelectWhere.Enabled = false;
                txtSelectOperand.Text = txtSelectOperand.Items[0].ToString();
            }
            check = rbInsertYes.Checked;
            if (!check)
            {
                txtInsertFirstWhere.Enabled = false;
                txtInsertOperand.Enabled = false;
                txtInsertSecondWhere.Enabled = false;
                btnInsertAddWhere.Enabled = false;
                lbInsertWhere.Enabled = false;
                txtInsertOperand.Text = txtInsertOperand.Items[0].ToString();
            }

        }

        private void btnSelectAddColumn_Click(object sender, EventArgs e)
        {
            //Проверка на заполненность поля ввода
            if(IsNullTest.TextBox(txtSelectAddColumn))
            {
                lbSelectColumns.BackColor = System.Drawing.Color.White;
                lbSelectColumns.Items.Add(txtSelectAddColumn.Text);
                txtSelectAddColumn.Text = "";
            }
            else
            {
                MessageBox.Show("Введите выбираемые данные!");
            }
        }

        private void toolStripDeleteColumn_Click(object sender, EventArgs e)
        {
            //Удаление выбранного элемента 
            if (lbSelectColumns.SelectedItem != null)
            {
                int index = lbSelectColumns.SelectedIndex;
                lbSelectColumns.Items.RemoveAt(index);
            }
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            //Удаление выбранного элемента
            if (lbSelectTables.SelectedItem != null)
            {
                int index = lbSelectTables.SelectedIndex;
                lbSelectTables.Items.RemoveAt(index);
            }
        }

        private void btnSelectAddTable_Click(object sender, EventArgs e)
        {
            //Проверка на заполненность поля ввода таблицы
            if (IsNullTest.TextBox(txtSelectAddTable))
            {
                lbSelectTables.BackColor = System.Drawing.Color.White;
                lbSelectTables.Items.Add(txtSelectAddTable.Text);
                txtSelectAddTable.Text = "";
            }
            else
            {
                MessageBox.Show("Введите название таблицы!");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (IsNullTest.ListBox(lbSelectColumns, lbSelectTables))
            {
                bool where = false;

                GetValues selected = new GetValues();
                CreateScript Query = new CreateScript();
                string items = selected.GetValue(selected.ParseList(lbSelectColumns));
                string tables = selected.GetValue(selected.ParseList(lbSelectTables));

                if (cbSelectYes.Checked)
                {
                    where = true;
                }
                else
                {
                    where = false;
                }

                if (where)
                {
                    if (IsNullTest.ListBox(lbSelectWhere))
                    {
                        // КОД С УСЛОВИЯМИ
                        string wheres = selected.GetWhere(selected.ParseList(lbSelectWhere));
                        string query = Query.CreateQuerySelectWhere(items, tables, wheres);
                        MessageBox.Show(query);
                    }
                    else
                    {
                        MessageBox.Show("Минимум одно условие!");
                    }
                    
                }
                else
                {
                    // КОД БЕЗ УСЛОВИЙ
                    string query = Query.CreateQuerySelectNonWhere(items, tables);
                    MessageBox.Show(query);
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void btnSelectAddWhere_Click(object sender, EventArgs e)
        {
            string where = null;
            var res = 0;
            if (IsNullTest.TextBox(txtSelectFirstWhere,txtSelectSecondWhere) && IsNullTest.ComboBox(txtSelectOperand))
            {
                lbSelectWhere.BackColor = System.Drawing.Color.White;
                if (Int32.TryParse(txtSelectSecondWhere.Text, out res))
                {
                    where = $"{txtSelectFirstWhere.Text} {txtSelectOperand.Text} {txtSelectSecondWhere.Text}";
                }
                else
                {
                    where = $"{txtSelectFirstWhere.Text} {txtSelectOperand.Text} '{txtSelectSecondWhere.Text}'";
                }
                lbSelectWhere.Items.Add(where);
                txtSelectFirstWhere.Text = "";
                txtSelectSecondWhere.Text = "";
                txtSelectOperand.Text = "";
            }
            else
            {
                MessageBox.Show("Заполните поля условия!");
            }
        }

        private void toolStripDeleteWhere_Click(object sender, EventArgs e)
        {
            //Удаление выбранного элемента
            if (lbSelectWhere.SelectedItem != null)
            {
                int index = lbSelectWhere.SelectedIndex;
                lbSelectWhere.Items.RemoveAt(index);
            }
        }

        private void cbSelectYes_CheckedChanged(object sender, EventArgs e)
        {
            bool check = cbSelectYes.Checked;
            if (!check)
            {
                txtSelectFirstWhere.Enabled = false;
                txtSelectOperand.Enabled = false;
                txtSelectSecondWhere.Enabled = false;
                btnSelectAddWhere.Enabled = false;
                lbSelectWhere.Enabled = false;
            }
            else
            {
                txtSelectFirstWhere.Enabled = true;
                txtSelectOperand.Enabled = true;
                txtSelectSecondWhere.Enabled = true;
                btnSelectAddWhere.Enabled = true;
                lbSelectWhere.Enabled = true;
            }
        }

        private void tsInsertValueDelete_Click(object sender, EventArgs e)
        {
            if (lbInsertValues.SelectedItem != null)
            {
                int index = lbInsertValues.SelectedIndex;
                lbInsertValues.Items.RemoveAt(index);
            }
        }

        private void tlInsertColumnDelete_Click(object sender, EventArgs e)
        {
            if (lbInsertColumns.SelectedItem != null)
            {
                int index = lbInsertColumns.SelectedIndex;
                lbInsertColumns.Items.RemoveAt(index);
            }
        }

        private void tsInsertWhereDelete_Click(object sender, EventArgs e)
        {
            if (lbInsertWhere.SelectedItem != null)
            {
                int index = lbInsertWhere.SelectedIndex;
                lbInsertWhere.Items.RemoveAt(index);
            }
        }

        private void txtInsertTableName_TextChanged(object sender, EventArgs e)
        {
            txtInsertTableName.BackColor = System.Drawing.Color.White;
        }

        private void txtInsertAddColumn_TextChanged(object sender, EventArgs e)
        {
            txtInsertAddColumn.BackColor = System.Drawing.Color.White;
        }

        private void txtInsertAddValue_TextChanged(object sender, EventArgs e)
        {
            txtInsertAddValue.BackColor = System.Drawing.Color.White;
        }

        private void btnInsertAddColumn_Click(object sender, EventArgs e)
        {
            if (IsNullTest.TextBox(txtInsertAddColumn))
            {
                lbInsertColumns.BackColor = System.Drawing.Color.White;
                lbInsertColumns.Items.Add(txtInsertAddColumn.Text);
                txtInsertAddColumn.Text = "";
            }
            else
            {
                MessageBox.Show("Введите поле таблицы!");
            }
        }

        private void btnInsertAddValue_Click(object sender, EventArgs e)
        {
            if (IsNullTest.TextBox(txtInsertAddValue))
            {
                lbInsertValues.BackColor = System.Drawing.Color.White;
                lbInsertValues.Items.Add(txtInsertAddValue.Text);
                txtInsertAddValue.Text = "";
            }
            else
            {
                MessageBox.Show("Введите значение поля!");
            }
        }

        private void btnInsertAddWhee_Click(object sender, EventArgs e)
        {
            string where = null;
            var res = 0;
            if (IsNullTest.TextBox(txtInsertFirstWhere, txtInsertSecondWhere) && IsNullTest.ComboBox(txtInsertOperand))
            {
                lbInsertWhere.BackColor = System.Drawing.Color.White;
                if (Int32.TryParse(txtInsertSecondWhere.Text, out res))
                {
                    where = $"{txtInsertFirstWhere.Text} {txtInsertOperand.Text} {txtInsertSecondWhere.Text}";
                }
                else
                {
                    where = $"{txtInsertFirstWhere.Text} {txtInsertOperand.Text} '{txtInsertSecondWhere.Text}'";
                }
                lbInsertWhere.Items.Add(where);
                txtInsertFirstWhere.Text = "";
                txtInsertSecondWhere.Text = "";
                txtInsertOperand.Text = "";
            }
            else
            {
                MessageBox.Show("Введите значение поля!");
            }
        }

        private void btnInsertCreateQuery_Click(object sender, EventArgs e)
        {
            if (IsNullTest.ListBox(lbInsertColumns,lbInsertValues) && IsNullTest.TextBox(txtInsertTableName))
            {
                GetValues values = new GetValues();
                CreateScript Query = new CreateScript();
                string tableName = txtInsertTableName.Text;
                string column = values.GetValue(values.ParseList(lbInsertColumns));
                string value = values.GetValue(values.ParseList(lbInsertValues));
                bool where = rbInsertYes.Checked;
                if (where)
                {
                    if (IsNullTest.ListBox(lbInsertWhere)){
                        string wheres = values.GetWhere(values.ParseList(lbInsertWhere));
                        string query_string = Query.CreateQueryInsertWhere(tableName, column, value, wheres);
                        MessageBox.Show(query_string);
                    }
                    else
                    {
                        MessageBox.Show("Минимум одно условие!");
                    }
                }
                else
                {
                    string query_string = Query.CreateQueryInsertNonWhere(tableName, column, value);
                    MessageBox.Show(query_string);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля и списки!");
            }
        }

        private void rbInsertYes_CheckedChanged(object sender, EventArgs e)
        {
            bool check = rbInsertYes.Checked;
            if (!check)
            {
                txtInsertFirstWhere.Enabled = false;
                txtInsertOperand.Enabled = false;
                txtInsertSecondWhere.Enabled = false;
                btnInsertAddWhere.Enabled = false;
                lbInsertWhere.Enabled = false;
            }
            else
            {
                txtInsertFirstWhere.Enabled = true;
                txtInsertOperand.Enabled = true;
                txtInsertSecondWhere.Enabled = true;
                btnInsertAddWhere.Enabled = true;
                lbInsertWhere.Enabled = true;
            }
        }
    }
}
