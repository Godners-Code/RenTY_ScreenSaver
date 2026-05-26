namespace RTYSS
{
    internal static class Program
    {
        internal static readonly Scr Monitor = new();
        internal static List<WinSS> FormSS = [];
        [STAThread]
        internal static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            ApplicationConfiguration.Initialize(); Int32 ID = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            for (ID = 0; ID < Monitor.Count; ID++)
            {
                FormSS.Add(new WinSS(ID)); FormSS[ID].Show();
                FormSS[ID].FormClosed += (O, E) => Application.Exit();
            }
            Application.Run();
        }
    }
}