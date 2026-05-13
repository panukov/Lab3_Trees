using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Trees
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }
        public void ShowList(CycleDoubleLinkList list)
        {
            if (ListViewDataGrid.Columns.Count == 0)
            {
                ListViewDataGrid.Columns.Add("Number", "№");
                ListViewDataGrid.Columns.Add("Key", "Ключ");
                ListViewDataGrid.Columns.Add("Info", "Информационное поле");
                ListViewDataGrid.Columns["Number"].Width = 50;
                ListViewDataGrid.Columns["Key"].Width = 100;
                ListViewDataGrid.Columns["Info"].Width = 150;

            }

            list.DisplayInDataGridView(ListViewDataGrid);
            list.Clear();
        }
    }
}
