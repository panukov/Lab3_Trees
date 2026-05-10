using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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


        public DTreeNode Insert(DTreeNode node, char info, int key)
        {
            if (node == null)
            {
                node = new DTreeNode(info, key);
            }
            else
            {
                if (key < node.Key) node.Left = Insert(node.Left, info, key);

                else if (key > node.Key) node.Right = Insert(node.Right, info, key);
            }
            return node;
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

        public void LKP(DTreeNode node, CycleDoubleLinkList list)
        {
            if (node != null)
            {
                LKP(node.Left, list);

                list.AddNode(node.Info, node.Key);

                LKP(node.Right, list);
            }
        }

        public void Destroy()
        {
            root = null;
        }

        public void FillTreeView(TreeNodeCollection nodes, DTreeNode node)
        {
            if (node != null)
            {
                TreeNode treeNode = new TreeNode($"({node.Key}) {node.Info}");
                nodes.Add(treeNode);

                FillTreeView(treeNode.Nodes, node.Left);
                FillTreeView(treeNode.Nodes, node.Right);
            }
        }
    }
}
