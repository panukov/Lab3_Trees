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

        private void DisplayTreeVisual(DTreeNode node)
        {
            drawPanel.Controls.Clear();

            if (node != null)
            {
                int panelWidth = drawPanel.Width;
                int startX = panelWidth / 2;
                int startY = 20;
                int offsetX = 150;
                int offsetY = 50;

                AddNodeToPanel(node, startX, startY, offsetX, offsetY);
            }
        }

        private void AddNodeToPanel(DTreeNode node, int x, int y, int offsetX, int offsetY)
        {
            if (node != null)
            {
                Label lbl = new Label();
                lbl.Text = $"{node.Key}({node.Info})";
                lbl.AutoSize = true;
                lbl.Location = new Point(x - lbl.Width / 2, y);

                drawPanel.Controls.Add(lbl);

                if (node.Left != null)
                {
                    AddNodeToPanel(node.Left, x - offsetX, y + offsetY, offsetX / 2, offsetY);
                }

                if (node.Right != null)
                {
                    AddNodeToPanel(node.Right, x + offsetX, y + offsetY, offsetX / 2, offsetY);
                }
            }
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

                    DisplayTreeVisual(node);

                }
            }
            else MessageBox.Show("Дерево еще не создано!");
        }
    }
}
