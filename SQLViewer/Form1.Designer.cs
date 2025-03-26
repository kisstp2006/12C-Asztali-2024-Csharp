namespace SQLViewer
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
            tbxazon = new TextBox();
            tbxnev = new TextBox();
            tbxjel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxAdmin = new CheckBox();
            btxdiscon = new Button();
            btxkapcsol = new Button();
            btxopenread = new Button();
            btxread = new Button();
            insert = new Button();
            btxchanges = new Button();
            btxdelete = new Button();
            SuspendLayout();
            // 
            // tbxazon
            // 
            tbxazon.Location = new Point(35, 57);
            tbxazon.Name = "tbxazon";
            tbxazon.Size = new Size(100, 23);
            tbxazon.TabIndex = 0;
            // 
            // tbxnev
            // 
            tbxnev.Location = new Point(35, 141);
            tbxnev.Name = "tbxnev";
            tbxnev.Size = new Size(100, 23);
            tbxnev.TabIndex = 1;
            // 
            // tbxjel
            // 
            tbxjel.Location = new Point(35, 222);
            tbxjel.Name = "tbxjel";
            tbxjel.Size = new Size(100, 23);
            tbxjel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Azonosító:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 123);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Név:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 204);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Jelszó";
            // 
            // cbxAdmin
            // 
            cbxAdmin.AutoSize = true;
            cbxAdmin.Location = new Point(35, 299);
            cbxAdmin.Name = "cbxAdmin";
            cbxAdmin.Size = new Size(67, 19);
            cbxAdmin.TabIndex = 6;
            cbxAdmin.Text = "Admin?";
            cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // btxdiscon
            // 
            btxdiscon.Location = new Point(35, 377);
            btxdiscon.Name = "btxdiscon";
            btxdiscon.Size = new Size(120, 26);
            btxdiscon.TabIndex = 7;
            btxdiscon.Text = "Kapcsolat bontása";
            btxdiscon.UseVisualStyleBackColor = true;
            btxdiscon.Click += btxdiscon_Click;
            // 
            // btxkapcsol
            // 
            btxkapcsol.Location = new Point(249, 54);
            btxkapcsol.Name = "btxkapcsol";
            btxkapcsol.Size = new Size(180, 26);
            btxkapcsol.TabIndex = 8;
            btxkapcsol.Text = "Kapcsolodás";
            btxkapcsol.UseVisualStyleBackColor = true;
            btxkapcsol.Click += Connect;
            // 
            // btxopenread
            // 
            btxopenread.Location = new Point(249, 117);
            btxopenread.Name = "btxopenread";
            btxopenread.Size = new Size(180, 26);
            btxopenread.TabIndex = 9;
            btxopenread.Text = "Megnyitás olvasásra";
            btxopenread.UseVisualStyleBackColor = true;
            // 
            // btxread
            // 
            btxread.Location = new Point(249, 184);
            btxread.Name = "btxread";
            btxread.Size = new Size(180, 26);
            btxread.TabIndex = 10;
            btxread.Text = "Olvas";
            btxread.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            insert.Location = new Point(249, 247);
            insert.Name = "insert";
            insert.Size = new Size(180, 26);
            insert.TabIndex = 11;
            insert.Text = "Beszúrás";
            insert.UseVisualStyleBackColor = true;
            // 
            // btxchanges
            // 
            btxchanges.Location = new Point(249, 310);
            btxchanges.Name = "btxchanges";
            btxchanges.Size = new Size(180, 26);
            btxchanges.TabIndex = 12;
            btxchanges.Text = "Módosítás kezelés";
            btxchanges.UseVisualStyleBackColor = true;
            // 
            // btxdelete
            // 
            btxdelete.Location = new Point(249, 377);
            btxdelete.Name = "btxdelete";
            btxdelete.Size = new Size(180, 26);
            btxdelete.TabIndex = 13;
            btxdelete.Text = "Törlés";
            btxdelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 454);
            Controls.Add(btxdelete);
            Controls.Add(btxchanges);
            Controls.Add(insert);
            Controls.Add(btxread);
            Controls.Add(btxopenread);
            Controls.Add(btxkapcsol);
            Controls.Add(btxdiscon);
            Controls.Add(cbxAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxjel);
            Controls.Add(tbxnev);
            Controls.Add(tbxazon);
            MaximumSize = new Size(470, 493);
            MinimumSize = new Size(470, 493);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxazon;
        private TextBox tbxnev;
        private TextBox tbxjel;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbxAdmin;
        private Button btxdiscon;
        private Button btxkapcsol;
        private Button btxopenread;
        private Button btxread;
        private Button insert;
        private Button btxchanges;
        private Button btxdelete;
    }
}
