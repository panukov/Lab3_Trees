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
                if (isValid)
                {
                    rowIndex++;

                    if (row.Cells["nodesKey"].Value == null)
                    {
                        isValid = false;
                        errorMsg = $"Ошибка: пустая строка {rowIndex}";
                    }

                    else if (!int.TryParse(row.Cells["nodesKey"].Value.ToString(), out keyValue))
                    {
                        isValid = false;
                        errorMsg = $"Ошибка: ключ в строке {rowIndex}";
                    }

                    else if (isValid && keys.Contains($"|{keyValue}|"))
                    {
                        isValid = false;
                        errorMsg = $"Ошибка: ключ {keyValue} не уникален";
                    }

                    else keys += $"|{keyValue}|";

                    if (isValid)
                    {
                        if (row.Cells["nodesInfo"].Value == null)
                        {
                            isValid = false;
                            errorMsg = $"Ошибка: пустое инфо поле в строке {rowIndex}";
                        }
                        else
                        {
                            string info = row.Cells["nodesInfo"].Value.ToString();
                            if (info.Length != 1)
                            {
                                isValid = false;
                                errorMsg = $"Ошибка: инфо поле в строке {rowIndex} (нужен 1 символ)";
                            }
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
