namespace Lab3_Trees
{
    partial class FindNode
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
            keyValueBox = new TextBox();
            label1 = new Label();
            findBtn = new Button();
            treeView1 = new TreeView();
            drawPanel = new Panel();
            SuspendLayout();
            // 
            // keyValueBox
            // 
            keyValueBox.Location = new Point(222, 18);
            keyValueBox.Name = "keyValueBox";
            keyValueBox.Size = new Size(125, 27);
            keyValueBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите значение ключа";
            // 
            // findBtn
            // 
            findBtn.Location = new Point(392, 16);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(94, 29);
            findBtn.TabIndex = 2;
            findBtn.Text = "Найти";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Right;
            treeView1.Location = new Point(770, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(308, 541);
            treeView1.TabIndex = 3;
            // 
            // drawPanel
            // 
            drawPanel.Dock = DockStyle.Bottom;
            drawPanel.Location = new Point(0, 166);
            drawPanel.Name = "drawPanel";
            drawPanel.Size = new Size(770, 375);
            drawPanel.TabIndex = 4;
            // 
            // FindNode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 541);
            Controls.Add(drawPanel);
            Controls.Add(treeView1);
            Controls.Add(findBtn);
            Controls.Add(label1);
            Controls.Add(keyValueBox);
            Name = "FindNode";
            Text = "FindNode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox keyValueBox;
        private Label label1;
        private Button findBtn;
        private TreeView treeView1;
        private Panel drawPanel;
    }
}