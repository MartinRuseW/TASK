namespace AHomeworkColorsDemo
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
            trackBarRed = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            trackBarGreen = new TrackBar();
            label3 = new Label();
            trackBarBlue = new TrackBar();
            pCanvas = new Panel();
            label4 = new Label();
            trackBarAlpha = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAlpha).BeginInit();
            SuspendLayout();
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(131, 40);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(613, 56);
            trackBarRed.TabIndex = 0;
            trackBarRed.ValueChanged += trackBars_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 102);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Green";
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(131, 102);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(613, 56);
            trackBarGreen.TabIndex = 2;
            trackBarGreen.ValueChanged += trackBars_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 164);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 5;
            label3.Text = "Blue";
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(131, 164);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(613, 56);
            trackBarBlue.TabIndex = 4;
            trackBarBlue.ValueChanged += trackBars_ValueChanged;
            // 
            // pCanvas
            // 
            pCanvas.Location = new Point(70, 400);
            pCanvas.Name = "pCanvas";
            pCanvas.Size = new Size(646, 128);
            pCanvas.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 226);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "Alpha";
            // 
            // trackBarAlpha
            // 
            trackBarAlpha.Location = new Point(131, 226);
            trackBarAlpha.Maximum = 255;
            trackBarAlpha.Name = "trackBarAlpha";
            trackBarAlpha.Size = new Size(613, 56);
            trackBarAlpha.TabIndex = 7;
            trackBarAlpha.Value = 255;
            trackBarAlpha.ValueChanged += trackBars_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(pCanvas);
            Controls.Add(label4);
            Controls.Add(trackBarAlpha);
            Controls.Add(label3);
            Controls.Add(trackBarBlue);
            Controls.Add(label2);
            Controls.Add(trackBarGreen);
            Controls.Add(label1);
            Controls.Add(trackBarRed);
            Name = "MainForm";
            Text = "Color Demo";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAlpha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarRed;
        private Label label1;
        private Label label2;
        private TrackBar trackBarGreen;
        private Label label3;
        private TrackBar trackBarBlue;
        private Panel pCanvas;
        private Label label4;
        private TrackBar trackBarAlpha;
    }
}