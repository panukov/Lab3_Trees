namespace Lab3_Trees
{
    public partial class Form1 : Form
    {
        DichotomyTree tree;
        CycleDoubleLinkList list;
        public Form1()
        {
            InitializeComponent();
            list = new CycleDoubleLinkList();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Вы уверены, что хотите закрыть приложение?",
              "Подтверждение закрытия",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) Application.Exit();
        }

        private void найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindNode findNode = new FindNode(tree, list);
            findNode.ShowDialog();
        }

        private void создатьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTree createTree = new CreateTree();
            createTree.ShowDialog();

            tree = createTree.Tree;
            list.Clear();
        }

        private void разрушитьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestroyTree destroyTree = new DestroyTree(tree);
            destroyTree.ShowDialog();
        }
    }
}
