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
            tbxID = new TextBox();
            tbxNev = new TextBox();
            tbxJelszo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxAdmin = new CheckBox();
            btnClose = new Button();
            btnCon = new Button();
            btnOpen = new Button();
            btnRead = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // tbxID
            // 
            tbxID.Location = new Point(35, 57);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(100, 23);
            tbxID.TabIndex = 0;
            // 
            // tbxNev
            // 
            tbxNev.Location = new Point(35, 141);
            tbxNev.Name = "tbxNev";
            tbxNev.Size = new Size(100, 23);
            tbxNev.TabIndex = 1;
            // 
            // tbxJelszo
            // 
            tbxJelszo.Location = new Point(35, 222);
            tbxJelszo.Name = "tbxJelszo";
            tbxJelszo.Size = new Size(100, 23);
            tbxJelszo.TabIndex = 2;
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
            // btnClose
            // 
            btnClose.Location = new Point(35, 377);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 26);
            btnClose.TabIndex = 7;
            btnClose.Text = "Kapcsolat bontása";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btxdiscon_Click;
            // 
            // btnCon
            // 
            btnCon.Location = new Point(249, 54);
            btnCon.Name = "btnCon";
            btnCon.Size = new Size(180, 26);
            btnCon.TabIndex = 8;
            btnCon.Text = "Kapcsolodás";
            btnCon.UseVisualStyleBackColor = true;
            btnCon.Click += Connect;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(249, 117);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(180, 26);
            btnOpen.TabIndex = 9;
            btnOpen.Text = "Megnyitás olvasásra";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(249, 184);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(180, 26);
            btnRead.TabIndex = 10;
            btnRead.Text = "Olvas";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(249, 247);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(180, 26);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Beszúrás";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(249, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(180, 26);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Módosítás kezelés";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(249, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 26);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 454);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnRead);
            Controls.Add(btnOpen);
            Controls.Add(btnCon);
            Controls.Add(btnClose);
            Controls.Add(cbxAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxJelszo);
            Controls.Add(tbxNev);
            Controls.Add(tbxID);
            MaximumSize = new Size(470, 493);
            MinimumSize = new Size(470, 493);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxID;
        private TextBox tbxNev;
        private TextBox tbxJelszo;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbxAdmin;
        private Button btnClose;
        private Button btnCon;
        private Button btnOpen;
        private Button btnRead;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
