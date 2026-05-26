using static System.Math;

namespace RTYSS
{
    internal static class Clr
    {
        private static Color HSV(Double H, Double S, Double V)
        {
            H = Max(0, Min(360, H)); S = Max(0, Min(1, S)); V = Max(0, Min(1, V));
            Double C = V * S, M = V - C, X = C * (1- Abs(H / 60D % 2D -1));
            Double R1, G1, B1;
            if (H < 60) { R1 = C; G1 = X; B1 = 0; }
            else if (H < 120) { R1 = X; G1 = C; B1 = 0; }
            else if (H < 180) { R1 = 0; G1 = C; B1 = X; }
            else if (H < 240) { R1 = 0; G1 = X; B1 = C; }
            else if (H < 300) { R1 = X; G1 = 0; B1 = C; }
            else { R1 = C; G1 = 0; B1 = X; }
            Int32 R = (Int32)Round((R1 + M) * 255, 0);
            Int32 G = (Int32)Round((G1 + M) * 255, 0);
            Int32 B = (Int32)Round((B1 + M) * 255, 0);
            return Color.FromArgb(R, G, B);
        }
        internal static (Color Back, Color Fore) Pair(Double H, Double S, Double V) =>
            (HSV(H, S, V), HSV((180 + H) % 360, S, V));
        
    }
}
