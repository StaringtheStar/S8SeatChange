using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S8SeatChange
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Icon = S8SeatChange.Properties.Resources.S8;
        }

        //From https://stackoverflow.com/a/24879511
        //By Christian Moser

        public class ScreenCapture
        {
            [DllImport("user32.dll")]
            private static extern IntPtr GetForegroundWindow();

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr GetDesktopWindow();

            [StructLayout(LayoutKind.Sequential)]
            private struct Rect
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
            }

            [DllImport("user32.dll")]
            private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

            public static Image CaptureDesktop()
            {
                return CaptureWindow(GetDesktopWindow());
            }

            public static Bitmap CaptureActiveWindow()
            {
                return CaptureWindow(GetForegroundWindow());
            }

            public static Bitmap CaptureWindow(IntPtr handle)
            {
                var rect = new Rect();
                GetWindowRect(handle, ref rect);
                var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
                var result = new Bitmap(bounds.Width, bounds.Height);

                using (var graphics = Graphics.FromImage(result))
                {
                    graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }

                return result;
            }
        }

        //use as below:
        //var image=ScreenCapture.CaptureActiveWindow();
        //image.Save(@"C:\temp\~~.jpg", ImageFormat.Jpeg);


        public string[] arr = {



        };
        
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        bool isDrag = false;
        Point mousePos;
        //Point 

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
                mousePos = e.Location;
            }
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Point temp = new Point(this.Location.X + e.Location.X - mousePos.X, this.Location.Y + e.Location.Y - mousePos.Y);
                this.Location = temp;
            }

        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = false;
            }
        }
        
        


        public void ApplytoTextbox()
        {
            string[] str = System.IO.File.ReadAllText("Classmates.txt").Split('\n');
            MessageBox.Show(str[1]);
            MessageBox.Show(str.Length.ToString());
            MessageBox.Show(str[str.Length-1]);

        }

        private void btnInitTxt_Click(object sender, EventArgs e)
        {
            string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            System.IO.File.WriteAllText("Classmates.txt", Properties.Resources.S8InitNames);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Classmates.txt"))
            {
                MessageBox.Show("Yay");
                ApplytoTextbox();
            }
        }
    }
}
