namespace S8SeatChange
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnChangeSeat = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배치초기화RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배치불러오기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.텍스트로저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지로저장IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.textBox05 = new System.Windows.Forms.TextBox();
            this.textBox06 = new System.Windows.Forms.TextBox();
            this.textBox07 = new System.Windows.Forms.TextBox();
            this.textBox08 = new System.Windows.Forms.TextBox();
            this.textBox09 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.tmrFadeOut = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeSeat
            // 
            this.btnChangeSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChangeSeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.btnChangeSeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(183)))), ((int)(((byte)(229)))));
            this.btnChangeSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSeat.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChangeSeat.Location = new System.Drawing.Point(474, 349);
            this.btnChangeSeat.Name = "btnChangeSeat";
            this.btnChangeSeat.Size = new System.Drawing.Size(114, 38);
            this.btnChangeSeat.TabIndex = 40;
            this.btnChangeSeat.Text = "자리 바꾸기";
            this.btnChangeSeat.UseVisualStyleBackColor = false;
            this.btnChangeSeat.Click += new System.EventHandler(this.btnChangeSeat_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Image = global::S8SeatChange.Properties.Resources.imgClose;
            this.btnClose.Location = new System.Drawing.Point(575, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseForm);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Location = new System.Drawing.Point(354, 349);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 38);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.ReOpen);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(533, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(36, 36);
            this.btnInfo.TabIndex = 37;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.btnInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(623, 40);
            this.menu.TabIndex = 46;
            this.menu.Text = "menuStrip1";
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배치초기화RToolStripMenuItem,
            this.배치불러오기OToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.파일ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 36);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 배치초기화RToolStripMenuItem
            // 
            this.배치초기화RToolStripMenuItem.Name = "배치초기화RToolStripMenuItem";
            this.배치초기화RToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.배치초기화RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.배치초기화RToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.배치초기화RToolStripMenuItem.Text = "배치 초기화(&R)";
            this.배치초기화RToolStripMenuItem.Click += new System.EventHandler(this.배치초기화RToolStripMenuItem_Click);
            // 
            // 배치불러오기OToolStripMenuItem
            // 
            this.배치불러오기OToolStripMenuItem.Name = "배치불러오기OToolStripMenuItem";
            this.배치불러오기OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.배치불러오기OToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.배치불러오기OToolStripMenuItem.Text = "배치 불러오기(&O)";
            this.배치불러오기OToolStripMenuItem.Click += new System.EventHandler(this.배치불러오기OToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.저장SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.텍스트로저장SToolStripMenuItem,
            this.이미지로저장IToolStripMenuItem});
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(58, 36);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            // 
            // 텍스트로저장SToolStripMenuItem
            // 
            this.텍스트로저장SToolStripMenuItem.Name = "텍스트로저장SToolStripMenuItem";
            this.텍스트로저장SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.텍스트로저장SToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.텍스트로저장SToolStripMenuItem.Text = "텍스트로 저장(&T)";
            this.텍스트로저장SToolStripMenuItem.Click += new System.EventHandler(this.텍스트로저장SToolStripMenuItem_Click);
            // 
            // 이미지로저장IToolStripMenuItem
            // 
            this.이미지로저장IToolStripMenuItem.Name = "이미지로저장IToolStripMenuItem";
            this.이미지로저장IToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.이미지로저장IToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.이미지로저장IToolStripMenuItem.Text = "이미지로 저장(&I)";
            this.이미지로저장IToolStripMenuItem.Click += new System.EventHandler(this.이미지로저장IToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            this.도움말HToolStripMenuItem.Click += new System.EventHandler(this.도움말HToolStripMenuItem_Click);
            // 
            // textBox01
            // 
            this.textBox01.BackColor = System.Drawing.Color.White;
            this.textBox01.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox01.Location = new System.Drawing.Point(0, 58);
            this.textBox01.MaxLength = 5;
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(75, 29);
            this.textBox01.TabIndex = 1;
            this.textBox01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox02
            // 
            this.textBox02.BackColor = System.Drawing.Color.White;
            this.textBox02.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox02.Location = new System.Drawing.Point(81, 58);
            this.textBox02.MaxLength = 5;
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(75, 29);
            this.textBox02.TabIndex = 2;
            this.textBox02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox03
            // 
            this.textBox03.BackColor = System.Drawing.Color.White;
            this.textBox03.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox03.Location = new System.Drawing.Point(162, 58);
            this.textBox03.MaxLength = 5;
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(75, 29);
            this.textBox03.TabIndex = 3;
            this.textBox03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox04
            // 
            this.textBox04.BackColor = System.Drawing.Color.White;
            this.textBox04.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox04.Location = new System.Drawing.Point(0, 93);
            this.textBox04.MaxLength = 5;
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(75, 29);
            this.textBox04.TabIndex = 4;
            this.textBox04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox05
            // 
            this.textBox05.BackColor = System.Drawing.Color.White;
            this.textBox05.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox05.Location = new System.Drawing.Point(81, 93);
            this.textBox05.MaxLength = 5;
            this.textBox05.Name = "textBox05";
            this.textBox05.Size = new System.Drawing.Size(75, 29);
            this.textBox05.TabIndex = 5;
            this.textBox05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox06
            // 
            this.textBox06.BackColor = System.Drawing.Color.White;
            this.textBox06.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox06.Location = new System.Drawing.Point(162, 93);
            this.textBox06.MaxLength = 5;
            this.textBox06.Name = "textBox06";
            this.textBox06.Size = new System.Drawing.Size(75, 29);
            this.textBox06.TabIndex = 6;
            this.textBox06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox07
            // 
            this.textBox07.BackColor = System.Drawing.Color.White;
            this.textBox07.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox07.Location = new System.Drawing.Point(0, 128);
            this.textBox07.MaxLength = 5;
            this.textBox07.Name = "textBox07";
            this.textBox07.Size = new System.Drawing.Size(75, 29);
            this.textBox07.TabIndex = 7;
            this.textBox07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox08
            // 
            this.textBox08.BackColor = System.Drawing.Color.White;
            this.textBox08.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox08.Location = new System.Drawing.Point(81, 128);
            this.textBox08.MaxLength = 5;
            this.textBox08.Name = "textBox08";
            this.textBox08.Size = new System.Drawing.Size(75, 29);
            this.textBox08.TabIndex = 8;
            this.textBox08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox09
            // 
            this.textBox09.BackColor = System.Drawing.Color.White;
            this.textBox09.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox09.Location = new System.Drawing.Point(162, 128);
            this.textBox09.MaxLength = 5;
            this.textBox09.Name = "textBox09";
            this.textBox09.Size = new System.Drawing.Size(75, 29);
            this.textBox09.TabIndex = 9;
            this.textBox09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox10.Location = new System.Drawing.Point(0, 163);
            this.textBox10.MaxLength = 5;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(75, 29);
            this.textBox10.TabIndex = 10;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox11.Location = new System.Drawing.Point(81, 163);
            this.textBox11.MaxLength = 5;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(75, 29);
            this.textBox11.TabIndex = 11;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox12.Location = new System.Drawing.Point(162, 163);
            this.textBox12.MaxLength = 5;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(75, 29);
            this.textBox12.TabIndex = 12;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox15.Location = new System.Drawing.Point(162, 198);
            this.textBox15.MaxLength = 5;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(75, 29);
            this.textBox15.TabIndex = 15;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.White;
            this.textBox14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox14.Location = new System.Drawing.Point(81, 198);
            this.textBox14.MaxLength = 5;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(75, 29);
            this.textBox14.TabIndex = 14;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox13.Location = new System.Drawing.Point(0, 198);
            this.textBox13.MaxLength = 5;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(75, 29);
            this.textBox13.TabIndex = 13;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.White;
            this.textBox18.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox18.Location = new System.Drawing.Point(162, 233);
            this.textBox18.MaxLength = 5;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(75, 29);
            this.textBox18.TabIndex = 18;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.White;
            this.textBox17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox17.Location = new System.Drawing.Point(81, 233);
            this.textBox17.MaxLength = 5;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(75, 29);
            this.textBox17.TabIndex = 17;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox16.Location = new System.Drawing.Point(0, 233);
            this.textBox16.MaxLength = 5;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(75, 29);
            this.textBox16.TabIndex = 16;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.Color.White;
            this.textBox36.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox36.Location = new System.Drawing.Point(478, 233);
            this.textBox36.MaxLength = 5;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(75, 29);
            this.textBox36.TabIndex = 36;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.Color.White;
            this.textBox35.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox35.Location = new System.Drawing.Point(397, 233);
            this.textBox35.MaxLength = 5;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(75, 29);
            this.textBox35.TabIndex = 35;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.Color.White;
            this.textBox34.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox34.Location = new System.Drawing.Point(316, 233);
            this.textBox34.MaxLength = 5;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(75, 29);
            this.textBox34.TabIndex = 34;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.Color.White;
            this.textBox33.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox33.Location = new System.Drawing.Point(478, 198);
            this.textBox33.MaxLength = 5;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(75, 29);
            this.textBox33.TabIndex = 33;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.Color.White;
            this.textBox32.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox32.Location = new System.Drawing.Point(397, 198);
            this.textBox32.MaxLength = 5;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(75, 29);
            this.textBox32.TabIndex = 32;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.Color.White;
            this.textBox31.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox31.Location = new System.Drawing.Point(316, 198);
            this.textBox31.MaxLength = 5;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(75, 29);
            this.textBox31.TabIndex = 31;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.Color.White;
            this.textBox30.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox30.Location = new System.Drawing.Point(478, 163);
            this.textBox30.MaxLength = 5;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(75, 29);
            this.textBox30.TabIndex = 30;
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.Color.White;
            this.textBox29.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox29.Location = new System.Drawing.Point(397, 163);
            this.textBox29.MaxLength = 5;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(75, 29);
            this.textBox29.TabIndex = 29;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.White;
            this.textBox28.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox28.Location = new System.Drawing.Point(316, 163);
            this.textBox28.MaxLength = 5;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(75, 29);
            this.textBox28.TabIndex = 28;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.White;
            this.textBox27.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox27.Location = new System.Drawing.Point(478, 128);
            this.textBox27.MaxLength = 5;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(75, 29);
            this.textBox27.TabIndex = 27;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.White;
            this.textBox26.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox26.Location = new System.Drawing.Point(397, 128);
            this.textBox26.MaxLength = 5;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(75, 29);
            this.textBox26.TabIndex = 26;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.White;
            this.textBox25.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox25.Location = new System.Drawing.Point(316, 128);
            this.textBox25.MaxLength = 5;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(75, 29);
            this.textBox25.TabIndex = 25;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.White;
            this.textBox24.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox24.Location = new System.Drawing.Point(478, 93);
            this.textBox24.MaxLength = 5;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(75, 29);
            this.textBox24.TabIndex = 24;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.White;
            this.textBox23.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox23.Location = new System.Drawing.Point(397, 93);
            this.textBox23.MaxLength = 5;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(75, 29);
            this.textBox23.TabIndex = 23;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.White;
            this.textBox22.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox22.Location = new System.Drawing.Point(316, 93);
            this.textBox22.MaxLength = 5;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(75, 29);
            this.textBox22.TabIndex = 22;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.White;
            this.textBox21.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox21.Location = new System.Drawing.Point(478, 58);
            this.textBox21.MaxLength = 5;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(75, 29);
            this.textBox21.TabIndex = 21;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.White;
            this.textBox20.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox20.Location = new System.Drawing.Point(397, 58);
            this.textBox20.MaxLength = 5;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(75, 29);
            this.textBox20.TabIndex = 20;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.White;
            this.textBox19.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox19.Location = new System.Drawing.Point(316, 58);
            this.textBox19.MaxLength = 5;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(75, 29);
            this.textBox19.TabIndex = 19;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Enabled = true;
            this.tmrFadeIn.Interval = 1;
            this.tmrFadeIn.Tick += new System.EventHandler(this.tmrFadeIn_Tick);
            // 
            // tmrFadeOut
            // 
            this.tmrFadeOut.Interval = 1;
            this.tmrFadeOut.Tick += new System.EventHandler(this.tmrFadeOut_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(81, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "칠 판";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.textBox01);
            this.panel1.Controls.Add(this.textBox02);
            this.panel1.Controls.Add(this.textBox03);
            this.panel1.Controls.Add(this.textBox04);
            this.panel1.Controls.Add(this.textBox19);
            this.panel1.Controls.Add(this.textBox05);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.textBox06);
            this.panel1.Controls.Add(this.textBox21);
            this.panel1.Controls.Add(this.textBox07);
            this.panel1.Controls.Add(this.textBox22);
            this.panel1.Controls.Add(this.textBox08);
            this.panel1.Controls.Add(this.textBox23);
            this.panel1.Controls.Add(this.textBox09);
            this.panel1.Controls.Add(this.textBox24);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox25);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox26);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox27);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.textBox28);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox29);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox30);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.textBox31);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.textBox32);
            this.panel1.Controls.Add(this.textBox36);
            this.panel1.Controls.Add(this.textBox33);
            this.panel1.Controls.Add(this.textBox35);
            this.panel1.Controls.Add(this.textBox34);
            this.panel1.Location = new System.Drawing.Point(35, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 262);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Classmates.jpg";
            this.saveFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            this.saveFileDialog1.InitialDirectory = "System.Windows.Forms.Application.StartupPath";
            this.saveFileDialog1.Title = "그림으로 저장";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Classmates.txt";
            this.openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "System.Windows.Forms.Application.StartupPath";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(203)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeSeat);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::S8SeatChange.Properties.Resources.S8;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Opacity = 0D;
            this.Text = "S8";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChangeSeat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배치초기화RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배치불러오기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 텍스트로저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지로저장IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.TextBox textBox03;
        private System.Windows.Forms.TextBox textBox04;
        private System.Windows.Forms.TextBox textBox05;
        private System.Windows.Forms.TextBox textBox06;
        private System.Windows.Forms.TextBox textBox07;
        private System.Windows.Forms.TextBox textBox08;
        private System.Windows.Forms.TextBox textBox09;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.Timer tmrFadeOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

