namespace Lab3_Trees
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            заданиеToolStripMenuItem = new ToolStripMenuItem();
            создатьДеревоToolStripMenuItem = new ToolStripMenuItem();
            найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem = new ToolStripMenuItem();
            разрушитьДеревоToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { заданиеToolStripMenuItem, оПрограммеToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // заданиеToolStripMenuItem
            // 
            заданиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьДеревоToolStripMenuItem, найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem, разрушитьДеревоToolStripMenuItem });
            заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            заданиеToolStripMenuItem.Size = new Size(81, 24);
            заданиеToolStripMenuItem.Text = "Задание";
            // 
            // создатьДеревоToolStripMenuItem
            // 
            создатьДеревоToolStripMenuItem.Name = "создатьДеревоToolStripMenuItem";
            создатьДеревоToolStripMenuItem.Size = new Size(392, 26);
            создатьДеревоToolStripMenuItem.Text = "Создать дерево";
            создатьДеревоToolStripMenuItem.Click += создатьДеревоToolStripMenuItem_Click;
            // 
            // найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem
            // 
            найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem.Name = "найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem";
            найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem.Size = new Size(392, 26);
            найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem.Text = "Найти узел по заданному значению ключа";
            найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem.Click += найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem_Click;
            // 
            // разрушитьДеревоToolStripMenuItem
            // 
            разрушитьДеревоToolStripMenuItem.Name = "разрушитьДеревоToolStripMenuItem";
            разрушитьДеревоToolStripMenuItem.Size = new Size(392, 26);
            разрушитьДеревоToolStripMenuItem.Text = "Разрушить дерево";
            разрушитьДеревоToolStripMenuItem.Click += разрушитьДеревоToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(67, 24);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem заданиеToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem создатьДеревоToolStripMenuItem;
        private ToolStripMenuItem найтиУзелПоЗаданномуЗначениюКлючаToolStripMenuItem;
        private ToolStripMenuItem разрушитьДеревоToolStripMenuItem;
    }
}
