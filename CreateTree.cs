using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Trees
{
    public partial class CreateTree : Form
    {
        DichotomyTree _tree;
        public DichotomyTree Tree { get { return _tree; } }

        public CreateTree()
        {
            InitializeComponent();
        }

        private void createDTGBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(nodeCount.Text, out int nodesCount) || nodesCount <= 0)
                MessageBox.Show("Ошибка ввода");
            else
            {
                countLabel.Visible = false;
                nodeCount.Visible = false;
                createDTGBtn.Visible = false;

                nodesData.Visible = true;
                fillDTGlabel.Visible = true;
                CreateTreeBtn.Visible = true;

                nodesData.Columns.Add("nodesInfo", "Информацинное поле(символ/char)");
                nodesData.Columns.Add("nodesKey", "Ключ(целое число/int)");

                nodesData.Columns["nodesInfo"].Width = 200;
                nodesData.Columns["nodesKey"].Width = 100;

                for (int i = 0; i < nodesCount; i++)
                {
                    nodesData.Rows.Add();
                }
            }
        }

        private void CreateTreeBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string errorMsg = "";
            string keys = "";
            int keyValue;
            int rowIndex = 0;

            foreach (DataGridViewRow row in nodesData.Rows)
            {
                if (!row.IsNewRow && isValid)
                {
                    rowIndex++;

                    if (!int.TryParse(row.Cells["nodesKey"].Value?.ToString(), out keyValue))
                    {
                        isValid = false;
                        errorMsg = $"Ошибка: ключ в строке {rowIndex}";
                    }

                    if (isValid && keys.Contains($"|{keyValue}|"))
                    {
                        isValid = false;
                        errorMsg = $"Ошибка: ключ {keyValue} не уникален";
                    }
                    keys += $"|{keyValue}|";

                    if (isValid)
                    {
                        string info = row.Cells["nodesInfo"].Value?.ToString();
                        if (string.IsNullOrEmpty(info) || info.Length != 1)
                        {
                            isValid = false;
                            errorMsg = $"Ошибка: инфо поле в строке {rowIndex} (нужен 1 символ)";
                        }
                    }
                }
            }

            if (!isValid)
                MessageBox.Show(errorMsg);
            else
            {
                _tree = new DichotomyTree();
                for (int i = 0; i < nodesData.Rows.Count; i++)
                {
                    char info = Convert.ToChar(nodesData.Rows[i].Cells["nodesInfo"].Value);
                    int key = Convert.ToInt32(nodesData.Rows[i].Cells["nodesKey"].Value);

                    _tree.Root = _tree.Insert(_tree.Root, info, key);

                }
                MessageBox.Show("Дерево успешно создано!");
            }
        }
    }
}
