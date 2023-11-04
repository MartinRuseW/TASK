namespace BBlockingUI
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
            bGetQotD = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bGetQotD
            // 
            bGetQotD.Location = new Point(22, 25);
            bGetQotD.Name = "bGetQotD";
            bGetQotD.Size = new Size(273, 29);
            bGetQotD.TabIndex = 0;
            bGetQotD.Text = "Get Quote of the Day";
            bGetQotD.UseVisualStyleBackColor = true;
            bGetQotD.Click += bGetQotD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 110);
            label1.Name = "label1";
            label1.Size = new Size(117, 46);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(bGetQotD);
            Name = "MainForm";
            Text = "Blocking UI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bGetQotD;
        private Label label1;
    }
}