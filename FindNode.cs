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

            treeView1.Nodes.Clear();
            _tree.FillTreeView(treeView1.Nodes, _tree.Root);
            treeView1.ExpandAll();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if (_tree != null)
            {
                if (!int.TryParse(keyValueBox.Text, out int value))
                    MessageBox.Show("Ошибка ввода!");
                else
                {
                    DTreeNode node = _tree.Find(_tree.Root, value);

                    if (node == null) MessageBox.Show("Узел не найден");

                    else
                    {
                        _tree.LKP(node, _list);

                        MessageBox.Show(_list.PrintList());
                    }
                    treeView1.Nodes.Clear();
                    _tree.FillTreeView(treeView1.Nodes, node);
                    treeView1.ExpandAll();

                }
            }
            else MessageBox.Show("Дерево еще не создано!");
        }
    }
}
