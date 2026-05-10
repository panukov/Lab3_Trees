using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Trees
{
    public partial class DestroyTree : Form
    {
        DichotomyTree _tree;
        public DestroyTree(DichotomyTree tree)
        {
            InitializeComponent();
            _tree = tree;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Вы уверены, что хотите разрушить дерево?",
              "Подтверждение разрушения",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) _tree.Destroy(); ;
        }
    }
}
