namespace Lab3_Trees
{
    partial class ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ListViewDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ListViewDataGrid
            // 
            ListViewDataGrid.AllowUserToAddRows = false;
            ListViewDataGrid.AllowUserToDeleteRows = false;
            ListViewDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListViewDataGrid.Dock = DockStyle.Fill;
            ListViewDataGrid.Location = new Point(0, 0);
            ListViewDataGrid.Name = "ListViewDataGrid";
            ListViewDataGrid.ReadOnly = true;
            ListViewDataGrid.RowHeadersWidth = 51;
            ListViewDataGrid.Size = new Size(800, 450);
            ListViewDataGrid.TabIndex = 0;
            // 
            // ListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListViewDataGrid);
            Name = "ListView";
            Text = "ListView";
            ((System.ComponentModel.ISupportInitialize)ListViewDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListViewDataGrid;
    }
}