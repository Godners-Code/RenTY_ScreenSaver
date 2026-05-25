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
            LTime = new Label();
            LDate = new Label();
            TmrSS = new System.Windows.Forms.Timer(components);
            TLP.SuspendLayout();
            SuspendLayout();
            // 
            // TLP
            // 
            TLP.ColumnCount = 3;
            TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.54369F));
            TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.9126244F));
            TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.54369F));
            TLP.Controls.Add(LTime, 1, 3);
            TLP.Controls.Add(LDate, 1, 1);
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
            LTime.AutoSize = true;
            LTime.Dock = DockStyle.Fill;
            LTime.Location = new Point(148, 269);
            LTime.Margin = new Padding(0);
            LTime.Name = "LTime";
            LTime.Size = new Size(503, 92);
            LTime.TabIndex = 1;
            LTime.Text = "00:00:00.00 +00";
            LTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LDate
            // 
            LDate.AutoSize = true;
            LDate.Dock = DockStyle.Fill;
            LDate.Location = new Point(148, 85);
            LDate.Margin = new Padding(0);
            LDate.Name = "LDate";
            LDate.Size = new Size(503, 92);
            LDate.TabIndex = 0;
            LDate.Text = "2020-02-02  SUN";
            LDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TmrSS
            // 
            TmrSS.Interval = 10;
            TmrSS.Tick += OnTick;
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
            TopMost = true;
            TLP.ResumeLayout(false);
            TLP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP;
        private Label LDate;
        private Label LTime;
        private System.Windows.Forms.Timer TmrSS;
    }
}
