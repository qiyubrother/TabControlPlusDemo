using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlPlusDemo
{
    public delegate void CloseButtonClickedEventHandle(int tabPageIndex);
    public class TabControlPlus : TabControl
    {
        Image imgDefault = null;
        public event CloseButtonClickedEventHandle closeButtonClicked;
        public TabControlPlus()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Multiline = false;
            ItemSize = new Size(120, 24);
            SizeMode = TabSizeMode.Fixed;
            //MainTabControl.Font = new Font("微软雅黑", 9, FontStyle.Regular);
            //imgDefault = Image.FromFile(@"d:\close_default.png");
            //imgHover = Image.FromFile(@"d:\close_hover.png");
            //TabPages[2].Text = "人民日报人民论坛：“不懂装懂”与“懂装不懂”.docx";
            //var g = CreateGraphics();
            //var sz = g.MeasureString(TabPages[2].Text, Font);
        }
        public Image CloseButtonImage { get => imgDefault; set => imgDefault = value; }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            try
            {
                Rectangle myTabRect = GetTabRect(e.Index);

                Color recColor = e.State == DrawItemState.Selected ? Color.FromArgb(255, 79, 196, 123) : SystemColors.Control;
                using (Brush b = new SolidBrush(recColor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }
                var sz = e.Graphics.MeasureString(TabPages[e.Index].Text, Font);
                if (sz.Width > myTabRect.Width)
                {
                    sz.Width = myTabRect.Width - 18;
                }
                e.Graphics.DrawString(TabPages[e.Index].Text, Font, new SolidBrush(Color.Black), new RectangleF(myTabRect.X + 2, myTabRect.Y + (myTabRect.Height - sz.Height) / 2, sz.Width, sz.Height));

                var bound = GetDrawItemBound(e.Index);
                e.Graphics.DrawImage(imgDefault, new Rectangle(bound.X, bound.Y, 16, 16));
                e.Graphics.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private Rectangle GetDrawItemBound(int tabIndex)
        {
            Rectangle myTabRect = GetTabRect(tabIndex);
            return new Rectangle(myTabRect.X + myTabRect.Width - 20, myTabRect.Y + (myTabRect.Height - 16) / 2, 16, 16);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            for (var i = 0; i < TabCount; i++)
            {
                var bound = GetDrawItemBound(i);
                if (bound.Contains(e.X, e.Y))
                {
                    closeButtonClicked?.Invoke(i);
                    break;
                }
            }
        }
    }
}
