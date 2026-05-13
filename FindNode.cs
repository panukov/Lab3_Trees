using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Trees
{
    public partial class FindNode : Form
    {
        CycleDoubleLinkList _list;
        DichotomyTree _tree;
        public FindNode(DichotomyTree tree, CycleDoubleLinkList list)
        {
            InitializeComponent();
            _tree = tree;
            _list = list;

            if (_tree != null && _tree.Root != null)
            {
                treeView1.Nodes.Clear();
                _tree.FillTreeView(treeView1.Nodes, _tree.Root);
                treeView1.ExpandAll();
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if (_tree != null)
            {
                if (int.TryParse(keyValueBox.Text, out int value))
                {
                    DTreeNode node = _tree.FillList(value, _list, treeView1);

                    if (node != null)
                    {
                        _tree.DisplayTreeVisual(drawPanel, node);

                        ListView listForm = new ListView();
                        listForm.ShowList(_list);
                        listForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода!");
                }
            }
            else
            {
                MessageBox.Show("Дерево не создано");
            }
        }
    }
}
