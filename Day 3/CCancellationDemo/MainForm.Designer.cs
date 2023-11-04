namespace CCancellationDemo
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
            bStartSorting = new Button();
            panelSortUI = new Panel();
            label1 = new Label();
            bCancel = new Button();
            progressBar = new ProgressBar();
            panelSortUI.SuspendLayout();
            SuspendLayout();
            // 
            // bStartSorting
            // 
            bStartSorting.Location = new Point(12, 12);
            bStartSorting.Name = "bStartSorting";
            bStartSorting.Size = new Size(202, 29);
            bStartSorting.TabIndex = 0;
            bStartSorting.Text = "Start Sorting";
            bStartSorting.UseVisualStyleBackColor = true;
            bStartSorting.Click += bStartSorting_Click;
            // 
            // panelSortUI
            // 
            panelSortUI.Controls.Add(label1);
            panelSortUI.Controls.Add(bCancel);
            panelSortUI.Controls.Add(progressBar);
            panelSortUI.Location = new Point(12, 106);
            panelSortUI.Name = "panelSortUI";
            panelSortUI.Size = new Size(776, 125);
            panelSortUI.TabIndex = 1;
            panelSortUI.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 2;
            label1.Text = "Sort in progress.  Please wait...";
            // 
            // bCancel
            // 
            bCancel.Location = new Point(330, 82);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(94, 29);
            bCancel.TabIndex = 1;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(15, 36);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(743, 29);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 280);
            Controls.Add(panelSortUI);
            Controls.Add(bStartSorting);
            Name = "MainForm";
            Text = "Sorting with Cancellation";
            panelSortUI.ResumeLayout(false);
            panelSortUI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bStartSorting;
        private Panel panelSortUI;
        private Label label1;
        private Button bCancel;
        private ProgressBar progressBar;
    }
}