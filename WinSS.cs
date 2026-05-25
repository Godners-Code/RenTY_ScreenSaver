using System.Globalization;
using static System.Math;
using static System.DateTime;

namespace RTYSS
{
    internal partial class WinSS : Form
    {
        private const Single FR = 1.381966011250105F;
        private const FontStyle FS = FontStyle.Bold;
        private const GraphicsUnit GU = GraphicsUnit.Pixel;
        private const ContentAlignment MC = ContentAlignment.MiddleCenter,
            TC = ContentAlignment.TopCenter, BC = ContentAlignment.BottomCenter;
        private const String FN = "Consolas", DF = "yyyy-MM-dd  ddd", TF = "HH:mm:ss.ff zz";

        private CultureInfo CI = new CultureInfo(1033);
        internal Int32 ID = 0;
        internal WinSS(Int32 ID)
        {
            InitializeComponent(); this.ID = ID; ReDraw();
            LDate.Text = LL; TmrSS.Enabled = true;
        }
        private void ReDraw()
        {
            // Size = Program.Monitor[ID].Bounds.Size;
            Size = Program.Monitor[ID].WorkingArea.Size;
            Location = Program.Monitor[ID].Bounds.Location;
            Text = $"RenTY ScreenSaver - {ID}";
            LDate.Font = LF(); LTime.Font = LF();
            LDate.TextAlign = Width > Height ? MC : BC;
            LTime.TextAlign = Width > Height ? MC : TC;
        }
        private Int32 LW => LDate.Width; private Int32 LH => LDate.Height;
        private Font LF() => new(FN, Min(LW * FR / 15F, LH * FR), FS, GU);
        private String LL => Now.ToString(DF, CI).ToUpper();
        private void OnTick(Object O, EventArgs E) { ReTime(); ReColor(); }
        private void ReTime()
        { 
            String L = LL; if (LDate.Text != L) LDate.Text = L; LTime.Text = Now.ToString(TF);

            /*
            1、右下角显示屏幕编号、分辨率
            2、左下角显示About信息
            */
        }
        private void ReColor()
        {
            /*
            1、N个屏幕，将HSV色彩模型N等分；
            2、取一[0, 360]随机数，作为第一个屏幕颜色的起点，其余屏幕按N等分顺延
            3、文字色按照H对边色
            4、V值始终取100%
            5、S值在[80%, 100%]间往返
            6、S值、H值周期相同
            7、S值完成往返后，H值切换顺时针/逆时针旋转

            8、默认初始速度，鼠标滚轮调节整体速度
            9、左上角显示前景色（RGB、HSV）、背景色（RGB、HSV）、速度（H角速度、S往返Hz频率）
            10、左上角限时退出按钮
            
            */

        }
    }
}
