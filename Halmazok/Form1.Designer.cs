namespace Halmazok
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
            ahalmaz = new ListBox();
            bhalmaz = new ListBox();
            metszetform = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            minimum = new NumericUpDown();
            maximum = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            mennyit = new NumericUpDown();
            label6 = new Label();
            generate = new Button();
            unionform = new ListBox();
            label7 = new Label();
            AcomplementB = new ListBox();
            label8 = new Label();
            BcomplementA = new ListBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)minimum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mennyit).BeginInit();
            SuspendLayout();
            // 
            // ahalmaz
            // 
            ahalmaz.FormattingEnabled = true;
            ahalmaz.ItemHeight = 15;
            ahalmaz.Location = new Point(12, 51);
            ahalmaz.Name = "ahalmaz";
            ahalmaz.Size = new Size(161, 289);
            ahalmaz.TabIndex = 0;
            ahalmaz.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // bhalmaz
            // 
            bhalmaz.FormattingEnabled = true;
            bhalmaz.ItemHeight = 15;
            bhalmaz.Location = new Point(189, 51);
            bhalmaz.Name = "bhalmaz";
            bhalmaz.Size = new Size(166, 289);
            bhalmaz.TabIndex = 1;
            // 
            // metszetform
            // 
            metszetform.FormattingEnabled = true;
            metszetform.ItemHeight = 15;
            metszetform.Location = new Point(376, 51);
            metszetform.Name = "metszetform";
            metszetform.Size = new Size(163, 289);
            metszetform.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "\"A\" halmaz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 33);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "\"B\" halmaz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 33);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "\"A\" metszet \"B\"";
            // 
            // minimum
            // 
            minimum.Location = new Point(12, 374);
            minimum.Maximum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            minimum.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            minimum.Name = "minimum";
            minimum.Size = new Size(83, 23);
            minimum.TabIndex = 6;
            minimum.Value = new decimal(new int[] { 100, 0, 0, int.MinValue });
            // 
            // maximum
            // 
            maximum.Location = new Point(145, 374);
            maximum.Name = "maximum";
            maximum.Size = new Size(83, 23);
            maximum.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 356);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Mettől";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 356);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "Meddig";
            // 
            // mennyit
            // 
            mennyit.Location = new Point(12, 425);
            mennyit.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            mennyit.Name = "mennyit";
            mennyit.Size = new Size(83, 23);
            mennyit.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 403);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Mennyit";
            // 
            // generate
            // 
            generate.Location = new Point(161, 424);
            generate.Name = "generate";
            generate.Size = new Size(75, 23);
            generate.TabIndex = 12;
            generate.Text = "generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // unionform
            // 
            unionform.FormattingEnabled = true;
            unionform.ItemHeight = 15;
            unionform.Location = new Point(558, 51);
            unionform.Name = "unionform";
            unionform.Size = new Size(163, 289);
            unionform.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(609, 33);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 14;
            label7.Text = "unio";
            // 
            // AcomplementB
            // 
            AcomplementB.FormattingEnabled = true;
            AcomplementB.ItemHeight = 15;
            AcomplementB.Location = new Point(744, 51);
            AcomplementB.Name = "AcomplementB";
            AcomplementB.Size = new Size(163, 289);
            AcomplementB.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(815, 33);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 16;
            label8.Text = "A-B";
            // 
            // BcomplementA
            // 
            BcomplementA.FormattingEnabled = true;
            BcomplementA.ItemHeight = 15;
            BcomplementA.Location = new Point(936, 51);
            BcomplementA.Name = "BcomplementA";
            BcomplementA.Size = new Size(163, 289);
            BcomplementA.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1000, 33);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 18;
            label9.Text = "B-A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 450);
            Controls.Add(label9);
            Controls.Add(BcomplementA);
            Controls.Add(label8);
            Controls.Add(AcomplementB);
            Controls.Add(label7);
            Controls.Add(unionform);
            Controls.Add(generate);
            Controls.Add(label6);
            Controls.Add(mennyit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maximum);
            Controls.Add(minimum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(metszetform);
            Controls.Add(bhalmaz);
            Controls.Add(ahalmaz);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)minimum).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximum).EndInit();
            ((System.ComponentModel.ISupportInitialize)mennyit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ahalmaz;
        private ListBox bhalmaz;
        private ListBox metszetform;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown minimum;
        private NumericUpDown maximum;
        private Label label4;
        private Label label5;
        private NumericUpDown mennyit;
        private Label label6;
        private Button generate;
        private ListBox unionform;
        private Label label7;
        private ListBox AcomplementB;
        private Label label8;
        private ListBox BcomplementA;
        private Label label9;
    }
}
