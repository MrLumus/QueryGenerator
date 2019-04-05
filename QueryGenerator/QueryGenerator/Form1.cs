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

            //Если нажата радио-кнопка "Нет" в условиях, то форма с условиями деактивируется
            bool where = false;
            if (cbSelectYes.Checked)
            {
                where = true;
            }
            else
            {
                where = false;
            }
            if (!where)
            {
                txtSelectFirstWhere.Enabled = false;
                txtSelectOperand.Enabled = false;
                txtSelectSecondWhere.Enabled = false;
                btnSelectAddWhere.Enabled = false;
                lbSelectWhere.Enabled = false;
                txtSelectOperand.Text = txtSelectOperand.Items[1].ToString();
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
                        string query = Query.CreateQueryWhere(items, tables, wheres);
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
                    string query = Query.CreateQueryNonWhere(items, tables);
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
            if(IsNullTest.TextBox(txtSelectFirstWhere,txtSelectSecondWhere) && IsNullTest.ComboBox(txtSelectOperand))
            {
                lbSelectWhere.BackColor = System.Drawing.Color.White;
                where = $"{txtSelectFirstWhere.Text} {txtSelectOperand.Text} {txtSelectSecondWhere.Text}";
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
    }
}
