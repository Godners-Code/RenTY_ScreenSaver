namespace RTYSS
{
    internal partial class WinSS
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
            TLP = new TableLayoutPanel();
            LT = new Label();
            LD = new Label();
            LI = new Label();
            TLPE = new TableLayoutPanel();
            LE = new Label();
            LA = new Label();
            LV = new Label();
            TD = new System.Windows.Forms.Timer(components);
            TH = new System.Windows.Forms.Timer(components);
            TS = new System.Windows.Forms.Timer(components);
            TLP.SuspendLayout();
            TLPE.SuspendLayout();
            SuspendLayout();
            // 
            // TLP
            // 
            TLP.ColumnCount = 3;
            TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.54369F));
            TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.9126244F));
            TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.54369F));
            TLP.Controls.Add(LT, 1, 3);
            TLP.Controls.Add(LD, 1, 1);
            TLP.Controls.Add(LI, 2, 4);
            TLP.Controls.Add(TLPE, 2, 0);
            TLP.Controls.Add(LA, 0, 4);
            TLP.Controls.Add(LV, 0, 0);
            TLP.Dock = DockStyle.Fill;
            TLP.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TLP.Location = new Point(0, 0);
            TLP.Margin = new Padding(0);
            TLP.Name = "TLP";
            TLP.RowCount = 5;
            TLP.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1F));
            TLP.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6F));
            TLP.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6F));
            TLP.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6F));
            TLP.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1F));
            TLP.Size = new Size(800, 450);
            TLP.TabIndex = 0;
            // 
            // LTime
            // 
            LT.AutoSize = true;
            LT.Dock = DockStyle.Fill;
            LT.Location = new Point(148, 269);
            LT.Margin = new Padding(0);
            LT.Name = "LTime";
            LT.Size = new Size(503, 92);
            LT.TabIndex = 1;
            LT.Text = "00:00:00.00 +00";
            LT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LDate
            // 
            LD.AutoSize = true;
            LD.Dock = DockStyle.Fill;
            LD.Location = new Point(148, 85);
            LD.Margin = new Padding(0);
            LD.Name = "LDate";
            LD.Size = new Size(503, 92);
            LD.TabIndex = 0;
            LD.Text = "2020-02-02  SUN";
            LD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LID
            // 
            LI.Dock = DockStyle.Fill;
            LI.ImageAlign = ContentAlignment.MiddleRight;
            LI.Location = new Point(651, 361);
            LI.Margin = new Padding(0);
            LI.Name = "LID";
            LI.Size = new Size(149, 89);
            LI.TabIndex = 2;
            LI.Text = "xxx";
            LI.TextAlign = ContentAlignment.BottomRight;
            // 
            // TLPE
            // 
            TLPE.ColumnCount = 2;
            TLPE.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            TLPE.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLPE.Controls.Add(LE, 1, 0);
            TLPE.Dock = DockStyle.Fill;
            TLPE.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TLPE.Location = new Point(651, 0);
            TLPE.Margin = new Padding(0);
            TLPE.Name = "TLPE";
            TLPE.RowCount = 2;
            TLPE.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TLPE.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            TLPE.Size = new Size(149, 85);
            TLPE.TabIndex = 3;
            // 
            // LE
            // 
            LE.AutoSize = true;
            LE.Dock = DockStyle.Fill;
            LE.Location = new Point(119, 0);
            LE.Margin = new Padding(0);
            LE.Name = "LE";
            LE.Size = new Size(30, 17);
            LE.TabIndex = 0;
            LE.Text = "X";
            LE.TextAlign = ContentAlignment.MiddleCenter;
            LE.Click += LExit_Click;
            // 
            // LA
            // 
            LA.AutoSize = true;
            LA.Dock = DockStyle.Fill;
            LA.ImageAlign = ContentAlignment.BottomLeft;
            LA.Location = new Point(0, 361);
            LA.Margin = new Padding(0);
            LA.Name = "LA";
            LA.Size = new Size(148, 89);
            LA.TabIndex = 4;
            LA.Text = " Godners Code\r\n Copyright (c) 2026.\r\n All rights reserved.\r\n";
            LA.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LV
            // 
            LV.AutoSize = true;
            LV.Dock = DockStyle.Fill;
            LV.ImageAlign = ContentAlignment.TopLeft;
            LV.Location = new Point(0, 0);
            LV.Margin = new Padding(0);
            LV.Name = "LV";
            LV.Size = new Size(148, 85);
            LV.TabIndex = 5;
            LV.Text = "label1";
            // 
            // TmrDraw
            // 
            TD.Interval = 10;
            TD.Tick += DrawTick;
            // 
            // TmrHue
            // 
            TH.Interval = 10;
            TH.Tick += HueTick;
            // 
            // TmrSaturation
            // 
            TS.Interval = 10;
            TS.Tick += SaturationTick;
            // 
            // WinSS
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(TLP);
            DoubleBuffered = true;
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Properties.Resources.WinSS;
            ImeMode = ImeMode.Disable;
            Name = "WinSS";
            StartPosition = FormStartPosition.Manual;
            Text = "RenTY ScreenSaver";
            TLP.ResumeLayout(false);
            TLP.PerformLayout();
            TLPE.ResumeLayout(false);
            TLPE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP;
        private Label LD;
        private Label LT;
        private System.Windows.Forms.Timer TD;
        private Label LI;
        private TableLayoutPanel TLPE;
        private Label LA;
        private System.Windows.Forms.Timer TH;
        private Label LV;
        private System.Windows.Forms.Timer TS;
        private Label LE;
    }
}
