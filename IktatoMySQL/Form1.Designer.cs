namespace IktatoMySQL
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            iktatóKönyvToolStripMenuItem = new ToolStripMenuItem();
            levelezésiTémákToolStripMenuItem = new ToolStripMenuItem();
            iktatásToolStripMenuItem = new ToolStripMenuItem();
            iktatásTallózóToolStripMenuItem = new ToolStripMenuItem();
            személyekToolStripMenuItem = new ToolStripMenuItem();
            osztályokToolStripMenuItem = new ToolStripMenuItem();
            beosztásokToolStripMenuItem = new ToolStripMenuItem();
            kimutatásokToolStripMenuItem = new ToolStripMenuItem();
            címzettekLeveleiToolStripMenuItem = new ToolStripMenuItem();
            levelekSzűréseIktatásiDátumSzerintToolStripMenuItem = new ToolStripMenuItem();
            levelekSzűréseNaptárralToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iktatóKönyvToolStripMenuItem, személyekToolStripMenuItem, osztályokToolStripMenuItem, beosztásokToolStripMenuItem, kimutatásokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // iktatóKönyvToolStripMenuItem
            // 
            iktatóKönyvToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { levelezésiTémákToolStripMenuItem, iktatásToolStripMenuItem, iktatásTallózóToolStripMenuItem });
            iktatóKönyvToolStripMenuItem.Name = "iktatóKönyvToolStripMenuItem";
            iktatóKönyvToolStripMenuItem.Size = new Size(84, 20);
            iktatóKönyvToolStripMenuItem.Text = "Iktató könyv";
            // 
            // levelezésiTémákToolStripMenuItem
            // 
            levelezésiTémákToolStripMenuItem.Name = "levelezésiTémákToolStripMenuItem";
            levelezésiTémákToolStripMenuItem.Size = new Size(162, 22);
            levelezésiTémákToolStripMenuItem.Text = "Levelezési témák";
            // 
            // iktatásToolStripMenuItem
            // 
            iktatásToolStripMenuItem.Name = "iktatásToolStripMenuItem";
            iktatásToolStripMenuItem.Size = new Size(162, 22);
            iktatásToolStripMenuItem.Text = "Iktatás";
            // 
            // iktatásTallózóToolStripMenuItem
            // 
            iktatásTallózóToolStripMenuItem.Name = "iktatásTallózóToolStripMenuItem";
            iktatásTallózóToolStripMenuItem.Size = new Size(162, 22);
            iktatásTallózóToolStripMenuItem.Text = "Iktatás tallózó";
            // 
            // személyekToolStripMenuItem
            // 
            személyekToolStripMenuItem.Name = "személyekToolStripMenuItem";
            személyekToolStripMenuItem.Size = new Size(74, 20);
            személyekToolStripMenuItem.Text = "Személyek";
            // 
            // osztályokToolStripMenuItem
            // 
            osztályokToolStripMenuItem.Name = "osztályokToolStripMenuItem";
            osztályokToolStripMenuItem.Size = new Size(70, 20);
            osztályokToolStripMenuItem.Text = "Osztályok";
            // 
            // beosztásokToolStripMenuItem
            // 
            beosztásokToolStripMenuItem.Name = "beosztásokToolStripMenuItem";
            beosztásokToolStripMenuItem.Size = new Size(77, 20);
            beosztásokToolStripMenuItem.Text = "Beosztások";
            // 
            // kimutatásokToolStripMenuItem
            // 
            kimutatásokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { címzettekLeveleiToolStripMenuItem, levelekSzűréseIktatásiDátumSzerintToolStripMenuItem, levelekSzűréseNaptárralToolStripMenuItem });
            kimutatásokToolStripMenuItem.Name = "kimutatásokToolStripMenuItem";
            kimutatásokToolStripMenuItem.Size = new Size(85, 20);
            kimutatásokToolStripMenuItem.Text = "Kimutatások";
            // 
            // címzettekLeveleiToolStripMenuItem
            // 
            címzettekLeveleiToolStripMenuItem.Name = "címzettekLeveleiToolStripMenuItem";
            címzettekLeveleiToolStripMenuItem.Size = new Size(269, 22);
            címzettekLeveleiToolStripMenuItem.Text = "Címzettek levelei";
            // 
            // levelekSzűréseIktatásiDátumSzerintToolStripMenuItem
            // 
            levelekSzűréseIktatásiDátumSzerintToolStripMenuItem.Name = "levelekSzűréseIktatásiDátumSzerintToolStripMenuItem";
            levelekSzűréseIktatásiDátumSzerintToolStripMenuItem.Size = new Size(269, 22);
            levelekSzűréseIktatásiDátumSzerintToolStripMenuItem.Text = "Levelek szűrése iktatási dátum szerint";
            // 
            // levelekSzűréseNaptárralToolStripMenuItem
            // 
            levelekSzűréseNaptárralToolStripMenuItem.Name = "levelekSzűréseNaptárralToolStripMenuItem";
            levelekSzűréseNaptárralToolStripMenuItem.Size = new Size(269, 22);
            levelekSzűréseNaptárralToolStripMenuItem.Text = "Levelek szűrése naptárral";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "iktatás MySql adatbázissal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iktatóKönyvToolStripMenuItem;
        private ToolStripMenuItem levelezésiTémákToolStripMenuItem;
        private ToolStripMenuItem iktatásToolStripMenuItem;
        private ToolStripMenuItem iktatásTallózóToolStripMenuItem;
        private ToolStripMenuItem személyekToolStripMenuItem;
        private ToolStripMenuItem osztályokToolStripMenuItem;
        private ToolStripMenuItem beosztásokToolStripMenuItem;
        private ToolStripMenuItem kimutatásokToolStripMenuItem;
        private ToolStripMenuItem címzettekLeveleiToolStripMenuItem;
        private ToolStripMenuItem levelekSzűréseIktatásiDátumSzerintToolStripMenuItem;
        private ToolStripMenuItem levelekSzűréseNaptárralToolStripMenuItem;
    }
}
