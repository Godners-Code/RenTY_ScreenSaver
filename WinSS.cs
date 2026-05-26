using System.Globalization;
using static System.DateTime;
using static System.Math;

namespace RTYSS
{
    internal partial class WinSS : Form
    {
        private const Single FR = 1.381966011250105F;
        private const FontStyle FS = FontStyle.Bold;
        private const GraphicsUnit GU = GraphicsUnit.Pixel;
        private const ContentAlignment MC = ContentAlignment.MiddleCenter,
            TC = ContentAlignment.TopCenter, BC = ContentAlignment.BottomCenter;
        private const String FN = "Consolas", DF = "yyyy-MM-dd  ddd", TF = "HH:mm:ss.ff zz",
            TT = "RenTY ScreenSaver - ";
        private readonly CultureInfo CI = new(1033);
        internal Int32 ID = 0;
        internal WinSS(Int32 ID)
        {
            InitializeComponent(); this.ID = ID; ReDraw(); LD.Text = LL;
            TD.Enabled = true; TH.Enabled = true; TS.Enabled = true;
        }
        private Rectangle MB(Int32 ID) => Program.Monitor[ID].Bounds;
        private void ReDraw()
        {
            Size = MB(ID).Size; Location = MB(ID).Location; Text = $"{TT}{ID}"; LD.Font = LF; LT.Font = LF;
            LD.TextAlign = Width > Height ? MC : BC; LT.TextAlign = Width > Height ? MC : TC;
            LI.Text = Str.LID_S(ID); LI.Font = Str.LID_F(LI, TLP); LE.Font = Str.LE_F(LE);
            LA.Font = Str.LA_F(LA, TLP); LV.Text = Str.LV_S(Hue, Saturation, BackColor, ForeColor);
            LV.Font = Str.LV_F(LV, TLP);
        }
        private Int32 LW => LD.Width; private Int32 LH => LD.Height;
        private Font LF => new(FN, Min(LW * FR / 15F, LH * FR), FS, GU);
        private String LL => Now.ToString(DF, CI).ToUpper();
        private void DrawTick(Object O, EventArgs E) { ReTime(); ReColor(); }
        private void ReTime()
        {
            String L = LL; if (LD.Text != L) LD.Text = L; LT.Text = Now.ToString(TF);
            LV.Text = Str.LV_S(Hue, Saturation, BackColor, ForeColor);
        }
        private Double Hue = 0D, Saturation = 1D;
        private void HueTick(Object O, EventArgs E) => Hue = Now.Second * 6D + Now.Millisecond / 100D;
        private void SaturationTick(Object O, EventArgs E) => Saturation = Round(Now.Second / 300D + 0.8D, 4);
        private void ReColor() => (BackColor, ForeColor) = Clr.Pair(Hue, Saturation, 1);
        private void LExit_Click(Object O, EventArgs E) => Application.Exit();
    }
}
