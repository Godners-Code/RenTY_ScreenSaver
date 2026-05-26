using System.Text;
using static System.Math;

namespace RTYSS
{
    internal static class Str
    {
        private const Single FR = 0.106431181261041F, FG = 0.381966011250105F;
        private const String FN = "Consolas";
        private const FontStyle FS = FontStyle.Bold;
        private const GraphicsUnit GU = GraphicsUnit.Pixel;
        private static (Int32 Lines, Int32 Length) Words(String Input)
        {
            if (String.IsNullOrEmpty(Input)) return (0, 0); Int32 H = 0, W = 0;
            foreach (ReadOnlySpan<Char> Line in Input.AsSpan().EnumerateLines())
            { H++; if (Line.Length > W) W = Line.Length; }
            return (H, W);
        }
        private static (Int32 Height, Int32 Width) Panels(TableLayoutPanel TLP)
            => (TLP.GetRowHeights()[0], TLP.GetColumnWidths()[0]);
        private static Single Size(String Input, TableLayoutPanel TLP)
        {
            (Int32 _, Int32 Length) = Words(Input); (Int32 Height, Int32 Width) = Panels(TLP);
            Single LW = (Single)Width / Length ; Single LH = Height * FR; return Min(LW, LH);
        }
        private static Font Font(String Input, TableLayoutPanel TLP) => new(FN, Size(Input, TLP), FS, GU);
        internal static String LID_S(Int32 ID) => $"Screen ID: {ID} \r\nPixel: {Program.Monitor.Pixel(ID)} \r\n";
        internal static Font LID_F(Label L, TableLayoutPanel TLP) => Font(L.Text, TLP);
        internal static Font LE_F(Label L) => new(FN, Min(L.Width * FG, L.Height * FG), FS, GU);
        internal static Font LA_F(Label L, TableLayoutPanel TLP) => Font(L.Text, TLP);
        private static String Hex(Color C) => $"#{C.R:X2}{C.G:X2}{C.B:X2}";
        internal static String LV_S(Double HB, Double S, Color Back, Color Fore)
        {
            Int32 HF = (180 + (Int32)HB) % 360;
            StringBuilder SB = new("\r\n");
            SB.AppendLine(" HSV Color (Fore / Back)");
            SB.AppendLine($"   Fore Hue = {HF:000}");
            SB.AppendLine($"   Back Hue = {HB:000}");
            SB.AppendLine($"   Saturation = {S * 100F:00.00}%");
            SB.AppendLine($"   Value = 100.00%");
            SB.AppendLine($" RGB Fore: {Hex(Fore)}");
            SB.AppendLine($" RGB Back: {Hex(Back)}");
            return SB.ToString();
        }
        internal static Font LV_F(Label L, TableLayoutPanel TLP) => Font(L.Text, TLP);
    }
}
