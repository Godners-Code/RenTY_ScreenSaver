using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTYSS
{
    internal partial class WinSS : Form
    {
        private static class MouseEvents
        {
            private const Double MaxOpacity = 1D, MinOpacity = 0.3D; private static Object LastObject;
            private static Point FormLocation; private static Boolean OnMoving, LastMove;
            private static Double Between(Double Value, Double Max, Double Min) =>
                Math.Min(Max, Math.Max(Min, Value));
            private static Point MoveLocation(Object O, Point Mouse) =>
                new Point(Mouse.X - FormLocation.X - ((O is Form) ? 0 : (O as Control).Left),
                    Mouse.Y - FormLocation.Y - ((O is Form) ? 0 : (O as Control).Top));
            private static Form FindForm(Object O) => (O as Control).FindForm();
            internal static void MouseDown(Object O, MouseEventArgs E)
            { FormLocation = E.Location; OnMoving = true; }
            internal static void MouseMove(Object O, MouseEventArgs E)
            {
                if (!OnMoving) return; LastMove = true; LastObject = O;
                FindForm(O).DesktopLocation = MoveLocation(O, MousePosition);
            }
            internal static void MouseUp(Object O, MouseEventArgs E)
            { FindForm(O).DesktopLocation = MoveLocation(O, MousePosition); OnMoving = false; }
            internal static void MouseWheel(Object O, MouseEventArgs E)
            {
                Double D = FindForm(O).Opacity + Math.Sign(E.Delta) * 0.05D;
                FindForm(O).Opacity = Between(D, MaxOpacity, MinOpacity);
            }
            internal static void MouseClick(Object O, Action A)
            { if (LastMove && LastObject == O) { LastMove = false; LastObject = O; } else A(); }
        }
        private void OnMouseDown(Object O, MouseEventArgs E) => MouseEvents.MouseDown(O, E);
        private void OnMouseMove(Object O, MouseEventArgs E) => MouseEvents.MouseMove(O, E);
        private void OnMouseUp(Object O, MouseEventArgs E) => MouseEvents.MouseUp(O, E);
        private void OnMouseWheel(Object O, MouseEventArgs E) => MouseEvents.MouseWheel(O, E);
        private void OnMouseClick(Object O, MouseEventArgs E)
        {
            if (E.Button == MouseButtons.Right) MouseEvents.MouseClick(O, Application.Exit);
        }
        private Color ColorBW(Color C) => C == Color.Black ? Color.White : Color.Black;
        private void SetFormColor() { ForeColor = ColorBW(ForeColor); BackColor = ColorBW(BackColor); }



    }
}
