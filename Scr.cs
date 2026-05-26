namespace RTYSS
{
    internal class Scr
    {
        private readonly Dictionary<Int32, Screen> I = []; // Items
        internal Scr()
        { Int32 I = 0; foreach (Screen S in Screen.AllScreens) this.I.Add(I++, S); }
        internal Screen this[Int32 Index] => I[Index];
        internal Int32 Count => I.Count;
        internal String Pixel(Int32 Index) => $"{I[Index].Bounds.Width} x {I[Index].Bounds.Height}";
    }
}
