namespace RTYSS
{
    internal class Screens
    {
        private readonly Dictionary<Int32, Screen> Items = [];
        internal Screens()
        { Int32 I = 0; foreach (Screen S in Screen.AllScreens) Items.Add(I++, S); }
        internal Screen this[Int32 Index] => Items[Index];           
        internal Int32 Count => Items.Count;   
        
    }
}
