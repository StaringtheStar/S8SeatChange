using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S8SeatChange
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        bool isDrag = false;
        Point mousePos;
        
        private void FrmHelp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
                mousePos = e.Location;
            }
        }

        private void FrmHelp_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                this.Location = new Point(this.Location.X + e.Location.X - mousePos.X, this.Location.Y + e.Location.Y - mousePos.Y);
            }
        }

        private void FrmHelp_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) isDrag = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { System.Diagnostics.Process.Start(linkLabel1.Text); }
            catch (Exception ex)
            {
                MessageBox.Show("에러가 발생하였습니다. 이 창을 캡쳐해서 개발자에게 메일로 보내주세면 과자를 얻을 수 있습니다." + Environment.NewLine + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity >= 1.00) tmrFadeIn.Enabled = false;

        }

        bool isAllowed = false;

        private void tmrFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                tmrFadeOut.Enabled = false;
                this.Close();
            }
        }

        private void FrmHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isAllowed)
            {
                e.Cancel = true;
                isAllowed = true;
                tmrFadeOut.Enabled = true;
            }
        }
    }
}
