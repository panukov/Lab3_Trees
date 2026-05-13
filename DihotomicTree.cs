using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace Lab3_Trees
{
    public class DTreeNode
    {
        private char info;
        private int key;
        private DTreeNode left;
        private DTreeNode right;
        public char Info { get; set; }
        public int Key { get; set; }
        public DTreeNode Left { get; set; }
        public DTreeNode Right { get; set; }

        public DTreeNode() { }
        public DTreeNode(char info, int key)
        {
            Info = info;
            Key = key;
        }
        public DTreeNode(char info, int key, DTreeNode left, DTreeNode right)
        {
            Info = info;
            Key = key;
            Left = left;
            Right = right;
        }
    }

    public class DichotomyTree
    {
        private DTreeNode root;
        public DTreeNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public DichotomyTree()
        {
            root = null;
        }

        private void AddNodeToPanel(Panel panel, DTreeNode node, int x, int y, int dX, int dY)
        {
            if (node != null)
            {
                Label lbl = new Label();
                lbl.Text = $"{node.Key}({node.Info})";
                lbl.AutoSize = true;
                lbl.Location = new Point(x - lbl.Width / 2, y);
                panel.Controls.Add(lbl);

                if (node.Left != null)
                {
                    AddNodeToPanel(panel, node.Left, x - dX, y + dY, dX / 2, dY);
                }

                if (node.Right != null)
                {
                    AddNodeToPanel(panel, node.Right, x + dX, y + dY, dX / 2, dY);
                }
            }
        }

        public void DisplayTreeVisual(Panel panel, DTreeNode node)
        {
            if (node != null)
            {
                panel.Controls.Clear();

                int panelWidth = panel.Width;
                int startX = panelWidth / 2;
                int startY = 20;
                int dX = 150;
                int dY = 50;

                AddNodeToPanel(panel, node, startX, startY, dX, dY);
            }
        }

        public DTreeNode Insert(DTreeNode treeNode, char info, int key)
        {
            if (treeNode == null)
            {
                treeNode = new DTreeNode(info, key);
            }
            else
            {
                if (key < treeNode.Key) treeNode.Left = Insert(treeNode.Left, info, key);

                else if (key > treeNode.Key) treeNode.Right = Insert(treeNode.Right, info, key);
            }
            return treeNode;
        }

        public DTreeNode Find(DTreeNode root, int key)
        {
            DTreeNode finded;

            if (root == null) finded = null;

            else
            {
                if (key < root.Key) finded = Find(root.Left, key);

                else if (key > root.Key) finded = Find(root.Right, key);

                else finded = root;
            }

            return finded;
        }

        public void LKP(DTreeNode treeNode, CycleDoubleLinkList list)
        {
            if (treeNode != null)
            {
                LKP(treeNode.Left, list);

                list.AddNode(treeNode.Info, treeNode.Key);

                LKP(treeNode.Right, list);
            }
        }

        public void Destroy()
        {
            root = null;
        }

        public void FillTreeView(TreeNodeCollection nodes, DTreeNode treeNode)
        {
            if (treeNode != null)
            {
                TreeNode treeViewNode = new TreeNode($"({treeNode.Key}) {treeNode.Info}");
                nodes.Add(treeViewNode);

                FillTreeView(treeViewNode.Nodes, treeNode.Left);
                FillTreeView(treeViewNode.Nodes, treeNode.Right);
            }
        }

        public DTreeNode FillList(int key, CycleDoubleLinkList list, TreeView treeView)
        {
            DTreeNode treeNode = Find(Root, key);

            if (treeNode == null)
            {
                MessageBox.Show("Узел не найден");
            }
            else
            {
                LKP(treeNode, list);
                treeView.Nodes.Clear();
                FillTreeView(treeView.Nodes, treeNode);
                treeView.ExpandAll();
            }

            return treeNode;
        }
    }
}
