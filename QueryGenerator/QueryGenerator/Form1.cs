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
            if(txtSelectAddColumn.Text == "")
            {
                MessageBox.Show("Введите выбираемые данные!");
            }
            else
            {
                lbSelectColumns.Items.Add(txtSelectAddColumn.Text);
                txtSelectAddColumn.Text = "";
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
            if (txtSelectAddTable.Text == "")
            {
                MessageBox.Show("Введите название таблицы!");
            }
            else
            {
                lbSelectTables.Items.Add(txtSelectAddTable.Text);
                txtSelectAddTable.Text = "";
            }
        }
    }
}
