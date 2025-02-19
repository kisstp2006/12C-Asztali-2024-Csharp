namespace UIApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn_clickme = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btn_clickme
            // 
            resources.ApplyResources(btn_clickme, "btn_clickme");
            btn_clickme.Name = "btn_clickme";
            btn_clickme.UseVisualStyleBackColor = true;
            btn_clickme.Click += btn_clickme_Click;
            btn_clickme.MouseEnter += btn_hover;
            btn_clickme.MouseLeave += b;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox1);
            Controls.Add(btn_clickme);
            MinimizeBox = false;
            Name = "MainForm";
            Opacity = 0.95D;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clickme;
        private CheckBox checkBox1;
    }
}
