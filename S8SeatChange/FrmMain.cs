﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace S8SeatChange
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //ScreenCapture Class
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

        //Usage:
        //var image=ScreenCapture.CaptureActiveWindow();
        //(CaptureDesktop: 전체 스크린)
        //image.Save(@"C:\temp\~~.jpg", ImageFormat.Jpeg);
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Focus();
            //btnChangeSeat.Focus();
            if (!System.IO.File.Exists("Classmates.txt")) InitialText();
            ApplytoTextbox(null);
            //MessageBox message = new MessageBox(2343, 52);
        }
        

        /*================Form DragEnabling=================*/
        bool isDrag = false;
        Point mousePos;

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
                this.Location= new Point(this.Location.X + e.Location.X - mousePos.X, this.Location.Y + e.Location.Y - mousePos.Y);
            }

        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) isDrag = false;
        }

        /*==============================================*/
        
        private void btnChangeSeat_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
                textBox01,
                textBox02,
                textBox03,
                textBox04,
                textBox05,
                textBox06,
                textBox07,
                textBox08,
                textBox09,
                textBox10,
                textBox11,
                textBox12,
                textBox13,
                textBox14,
                textBox15,
                textBox16,
                textBox17,
                textBox18,
                textBox19,
                textBox20,
                textBox21,
                textBox22,
                textBox23,
                textBox24,
                textBox25,
                textBox26,
                textBox27,
                textBox28,
                textBox29,
                textBox30,
                textBox31,
                textBox32,
                textBox33,
                textBox34,
                textBox35,
                textBox36
            };
            //textBox01~textBox36
            
            List<string> nameslist = new List<string>();
            foreach (TextBox item in textBoxes) { nameslist.Add(item.Text); }
            
            Random rnd = new Random();
            short i;
            short[] order=new short[36];
            for(i=0; i<36; i++)
            {
                short j, rndnum;
                bool isSame=false;
                while (true)
                {
                    rndnum = (short)rnd.Next(36);
                    for (j = 0; j < i; j++)
                    {
                        if (rndnum == order[j])
                        {
                            isSame = true;
                            break;
                        }
                        else isSame = false;
                    }
                    if (!isSame)
                    {
                        order[i] = rndnum;
                        break;
                    }
                }
            }
            for (i = 0; i < 36; i++) textBoxes[i].Text = nameslist[order[i]];
        }

        private void TextSave(object sender, EventArgs e) { SaveAsText(); }

        void InitialText()
        {
            if (System.IO.File.Exists("Classmates.txt"))
            {
                var result = MessageBox.Show("기존에 저장된 배치가 존재합니다. 덮어씌우시겠습니까?", "S8SeatChange", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.No) return;
            }
            System.IO.File.WriteAllText("Classmates.txt", Properties.Resources.S8InitNames);
        }

        void OpenText()
        {
            if (System.IO.File.Exists("Classmates.txt")) ApplytoTextbox(null);
            else MessageBox.Show("저장된 배치가 없습니다!", "S8SeatChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ApplytoTextbox(string filename)
        {
            if (filename == null) filename = "Classmates.txt";
            List<TextBox> textBoxes = new List<TextBox>
            {
                textBox01,
                textBox02,
                textBox03,
                textBox04,
                textBox05,
                textBox06,
                textBox07,
                textBox08,
                textBox09,
                textBox10,
                textBox11,
                textBox12,
                textBox13,
                textBox14,
                textBox15,
                textBox16,
                textBox17,
                textBox18,
                textBox19,
                textBox20,
                textBox21,
                textBox22,
                textBox23,
                textBox24,
                textBox25,
                textBox26,
                textBox27,
                textBox28,
                textBox29,
                textBox30,
                textBox31,
                textBox32,
                textBox33,
                textBox34,
                textBox35,
                textBox36
            };
            //textBox01~textBox36
            try
            {
                string[] str = System.IO.File.ReadAllText(filename).Split('\n');
                short i;
                for (i = 0; i < 36; i++)
                {
                    if (str[i] != String.Empty) textBoxes[i].Text = str[i];
                    else textBoxes[i].Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러가 발생하였습니다. 배치를 초기화합니다." + Environment.NewLine +
                    "이 창을 캡쳐해서 개발자에게 메일로 보내주세면 과자를 얻을 수 있습니다." +
                    Environment.NewLine + ex.ToString());
                InitialText();
            }
        }
        
        void SaveAsText()
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
                textBox01,
                textBox02,
                textBox03,
                textBox04,
                textBox05,
                textBox06,
                textBox07,
                textBox08,
                textBox09,
                textBox10,
                textBox11,
                textBox12,
                textBox13,
                textBox14,
                textBox15,
                textBox16,
                textBox17,
                textBox18,
                textBox19,
                textBox20,
                textBox21,
                textBox22,
                textBox23,
                textBox24,
                textBox25,
                textBox26,
                textBox27,
                textBox28,
                textBox29,
                textBox30,
                textBox31,
                textBox32,
                textBox33,
                textBox34,
                textBox35,
                textBox36
            };
            //textBox01~textBox36
            try
            {
                string str = string.Empty;
                foreach (TextBox items in textBoxes)
                {
                    str += items.Text + "\n";
                }
                System.IO.File.WriteAllText("Classmates.txt", str);
                MessageBox.Show("성공적으로 저장되었습니다.", "S8SeatChange", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러가 발생하였습니다. 다시 한 번 시도해주세요." + Environment.NewLine +
                    "이 창을 캡쳐해서 개발자에게 메일로 보내주세면 과자를 얻을 수 있습니다." +
                    Environment.NewLine + ex.ToString());
            }
        }

        void SaveAsImage()
        {
            menu.Visible = false;
            btnRefresh.Visible = false;
            btnChangeSeat.Visible = false;
            btnInfo.Visible = false;
            btnClose.Visible = false;
            this.Size = new Size(panel1.Size.Width + 70, panel1.Size.Height + 70);
            panel1.Location = new Point(35, 35);
            saveFileDialog1.ShowDialog();
            Thread.Sleep(500);
            this.Focus();
            var image = ScreenCapture.CaptureActiveWindow();
            
            if (saveFileDialog1.FileName != string.Empty)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                        MessageBox.Show("JPG 파일로 저장하였습니다.", "S8SeatChange");
                        break;
                    case 2:
                        image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                        MessageBox.Show("PNG 파일로 저장되었습니다.", "S8SeatChange");
                        break;
                }
            }
            else { MessageBox.Show("다시 한 번 지정해주세요."); }
            this.Size = new Size(623, 407);
            panel1.Location = new Point(35, 62);
            menu.Visible = true;
            btnRefresh.Visible = true;
            btnChangeSeat.Visible = true;
            btnInfo.Visible = true;
            btnClose.Visible = true;
        }
        
        private void CloseForm(object sender, EventArgs e) { this.Close(); }
        
        bool isClosing = false;
        bool isAllowed = false;
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isAllowed)
            {
                isClosing = true;
                var result = MessageBox.Show("정말로 종료하시겠습니까?", "S8SeatChange", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                e.Cancel = true;
                isClosing = false;
                if (result == DialogResult.Yes) { tmrFadeOut.Enabled = true; }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e) { OpenText(); }

        private void 배치불러오기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
                try
                {
                    ApplytoTextbox(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러가 발생하였습니다. 다시 한 번 시도해주세요." + Environment.NewLine +
                       "이 창을 캡쳐해서 개발자에게 메일로 보내주세면 과자를 얻을 수 있습니다." +
                       Environment.NewLine + ex.ToString());
                }

            

        }

        private void 배치초기화RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitialText();
            ApplytoTextbox(null);
        }

        private void 텍스트로저장SToolStripMenuItem_Click(object sender, EventArgs e) { SaveAsText(); }

        private void 이미지로저장IToolStripMenuItem_Click(object sender, EventArgs e) { SaveAsImage(); }

        
        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;
            if (this.Opacity == 1.0) { tmrFadeIn.Enabled = false; }
        }
        
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isClosing && e.KeyCode == Keys.Escape) this.Close();
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                var result = MessageBox.Show("텍스트로 저장하시겠다면 \"예\"를, 이미지로 저장하시겠다면 \"아니오\"를 클릭해주세요.", "S8SeatChange", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes) SaveAsText();
                else if (result == DialogResult.No) SaveAsImage();
            }
            else if (e.KeyCode==Keys.Q && (e.Modifiers==Keys.Control || e.Modifiers == Keys.Alt)) { this.Close(); }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e) { btnInfo.Image = Properties.Resources.imgInfo_Full; }

        private void button1_MouseUp(object sender, MouseEventArgs e) { btnInfo.Image = Properties.Resources.imgInfo; }

        private void btnImageSave_Click(object sender, EventArgs e) { SaveAsImage(); }

        private void ReOpen(object sender, EventArgs e) { OpenText(); }

        private void tmrFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity<=0.0)
            {
                isAllowed = true;
                Application.Exit();
            }
        }

        private void 도움말HToolStripMenuItem_Click(object sender, EventArgs e){ FormHelpOpen(); }

        private void btnInfo_Click(object sender, EventArgs e) { FormHelpOpen();  }

        void FormHelpOpen()
        {
            FrmHelp Help = new FrmHelp();
            Help.Show();
        }

        
    }
}