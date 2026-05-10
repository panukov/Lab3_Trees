namespace Lab3_Trees
{
    partial class CreateTree
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
            countLabel = new Label();
            nodeCount = new TextBox();
            nodesData = new DataGridView();
            createDTGBtn = new Button();
            fillDTGlabel = new Label();
            CreateTreeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)nodesData).BeginInit();
            SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(12, 18);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(244, 20);
            countLabel.TabIndex = 0;
            countLabel.Text = "Введите количество узлов дерева";
            // 
            // nodeCount
            // 
            nodeCount.Location = new Point(273, 15);
            nodeCount.Name = "nodeCount";
            nodeCount.Size = new Size(125, 27);
            nodeCount.TabIndex = 1;
            // 
            // nodesData
            // 
            nodesData.AllowUserToAddRows = false;
            nodesData.AllowUserToDeleteRows = false;
            nodesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nodesData.Location = new Point(12, 48);
            nodesData.Name = "nodesData";
            nodesData.RowHeadersWidth = 50;
            nodesData.Size = new Size(486, 390);
            nodesData.TabIndex = 2;
            nodesData.Visible = false;
            // 
            // createDTGBtn
            // 
            createDTGBtn.Location = new Point(404, 13);
            createDTGBtn.Name = "createDTGBtn";
            createDTGBtn.Size = new Size(94, 29);
            createDTGBtn.TabIndex = 3;
            createDTGBtn.Text = "OK";
            createDTGBtn.UseVisualStyleBackColor = true;
            createDTGBtn.Click += createDTGBtn_Click;
            // 
            // fillDTGlabel
            // 
            fillDTGlabel.AutoSize = true;
            fillDTGlabel.Location = new Point(12, 18);
            fillDTGlabel.Name = "fillDTGlabel";
            fillDTGlabel.Size = new Size(271, 20);
            fillDTGlabel.TabIndex = 4;
            fillDTGlabel.Text = "Заполните узлы для вставки в дерево";
            fillDTGlabel.Visible = false;
            // 
            // CreateTreeBtn
            // 
            CreateTreeBtn.Location = new Point(525, 211);
            CreateTreeBtn.Name = "CreateTreeBtn";
            CreateTreeBtn.Size = new Size(148, 29);
            CreateTreeBtn.TabIndex = 5;
            CreateTreeBtn.Text = "Создать дерево";
            CreateTreeBtn.UseVisualStyleBackColor = true;
            CreateTreeBtn.Visible = false;
            CreateTreeBtn.Click += CreateTreeBtn_Click;
            // 
            // CreateTree
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateTreeBtn);
            Controls.Add(fillDTGlabel);
            Controls.Add(createDTGBtn);
            Controls.Add(nodesData);
            Controls.Add(nodeCount);
            Controls.Add(countLabel);
            Name = "CreateTree";
            Text = "CreateTree";
            ((System.ComponentModel.ISupportInitialize)nodesData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label countLabel;
        private TextBox nodeCount;
        private DataGridView nodesData;
        private Button createDTGBtn;
        private Label fillDTGlabel;
        private Button CreateTreeBtn;
    }
}