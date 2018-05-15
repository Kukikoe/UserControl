namespace ControlClock
{
    partial class Clock
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripForClock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondArrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minuteArrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.hourArrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTimezoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC0200KievRigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC0200KievRigaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC0430AfghanistanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC0430AfghanistanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC0430AfghanistanToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC0430AfghanistanToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.uTC0430AfghanistanToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // contextMenuStripForClock
            // 
            this.contextMenuStripForClock.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForClock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeTimezoneToolStripMenuItem});
            this.contextMenuStripForClock.Name = "contextMenuStrip1";
            this.contextMenuStripForClock.Size = new System.Drawing.Size(251, 80);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondArrowToolStripMenuItem,
            this.minuteArrowToolStripMenuItem,
            this.hourArrowToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.changeColorToolStripMenuItem.Text = "Change color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // secondArrowToolStripMenuItem
            // 
            this.secondArrowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.brownToolStripMenuItem});
            this.secondArrowToolStripMenuItem.Name = "secondArrowToolStripMenuItem";
            this.secondArrowToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.secondArrowToolStripMenuItem.Tag = "second";
            this.secondArrowToolStripMenuItem.Text = "Second arrow";
            this.secondArrowToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.redToolStripMenuItem.Tag = "second";
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.redToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.blackToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.blackToolStripMenuItem.Tag = "second";
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.blueToolStripMenuItem.Tag = "second";
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.pinkToolStripMenuItem.Tag = "second";
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.yellowToolStripMenuItem.Tag = "second";
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.greenToolStripMenuItem.Tag = "second";
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // brownToolStripMenuItem
            // 
            this.brownToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            this.brownToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.brownToolStripMenuItem.Tag = "second";
            this.brownToolStripMenuItem.Text = "Brown";
            this.brownToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brownToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // minuteArrowToolStripMenuItem
            // 
            this.minuteArrowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.minuteArrowToolStripMenuItem.Name = "minuteArrowToolStripMenuItem";
            this.minuteArrowToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.minuteArrowToolStripMenuItem.Tag = "minute";
            this.minuteArrowToolStripMenuItem.Text = "Minute arrow";
            this.minuteArrowToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Red;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem1.Tag = "minute";
            this.toolStripMenuItem1.Text = "Red";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem2.Tag = "minute";
            this.toolStripMenuItem2.Text = "Black";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem3.Tag = "minute";
            this.toolStripMenuItem3.Text = "Blue";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem4.Tag = "minute";
            this.toolStripMenuItem4.Text = "Pink";
            this.toolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem5.Tag = "minute";
            this.toolStripMenuItem5.Text = "Yellow";
            this.toolStripMenuItem5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem5.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem6.Tag = "minute";
            this.toolStripMenuItem6.Text = "Green";
            this.toolStripMenuItem6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem6.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.SaddleBrown;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem7.Tag = "minute";
            this.toolStripMenuItem7.Text = "Brown";
            this.toolStripMenuItem7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem7.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // hourArrowToolStripMenuItem
            // 
            this.hourArrowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.hourArrowToolStripMenuItem.Name = "hourArrowToolStripMenuItem";
            this.hourArrowToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hourArrowToolStripMenuItem.Tag = "hour";
            this.hourArrowToolStripMenuItem.Text = "Hour arrow";
            this.hourArrowToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.Red;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem8.Tag = "hour";
            this.toolStripMenuItem8.Text = "Red";
            this.toolStripMenuItem8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem8.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem9.Tag = "hour";
            this.toolStripMenuItem9.Text = "Black";
            this.toolStripMenuItem9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem9.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem10.Tag = "hour";
            this.toolStripMenuItem10.Text = "Blue";
            this.toolStripMenuItem10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem10.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem11.Tag = "hour";
            this.toolStripMenuItem11.Text = "Pink";
            this.toolStripMenuItem11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem11.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem12.Tag = "hour";
            this.toolStripMenuItem12.Text = "Yellow";
            this.toolStripMenuItem12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem12.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem13.Tag = "hour";
            this.toolStripMenuItem13.Text = "Green";
            this.toolStripMenuItem13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem13.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.BackColor = System.Drawing.Color.SaddleBrown;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(127, 26);
            this.toolStripMenuItem14.Tag = "hour";
            this.toolStripMenuItem14.Text = "Brown";
            this.toolStripMenuItem14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem14.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // changeTimezoneToolStripMenuItem
            // 
            this.changeTimezoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTC2ToolStripMenuItem,
            this.uTC0200KievRigaToolStripMenuItem,
            this.uTC0200KievRigaToolStripMenuItem1,
            this.uTC0430AfghanistanToolStripMenuItem,
            this.uTC0430AfghanistanToolStripMenuItem1,
            this.uTC0430AfghanistanToolStripMenuItem2,
            this.uTC0430AfghanistanToolStripMenuItem3,
            this.uTC0430AfghanistanToolStripMenuItem4});
            this.changeTimezoneToolStripMenuItem.Name = "changeTimezoneToolStripMenuItem";
            this.changeTimezoneToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.changeTimezoneToolStripMenuItem.Text = "(UTC + 04:30) Afghanistan";
            this.changeTimezoneToolStripMenuItem.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC2ToolStripMenuItem
            // 
            this.uTC2ToolStripMenuItem.Name = "uTC2ToolStripMenuItem";
            this.uTC2ToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.uTC2ToolStripMenuItem.Tag = "-8";
            this.uTC2ToolStripMenuItem.Text = "(UTC - 08:00) Nevada";
            this.uTC2ToolStripMenuItem.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC0200KievRigaToolStripMenuItem
            // 
            this.uTC0200KievRigaToolStripMenuItem.Name = "uTC0200KievRigaToolStripMenuItem";
            this.uTC0200KievRigaToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.uTC0200KievRigaToolStripMenuItem.Tag = "-6";
            this.uTC0200KievRigaToolStripMenuItem.Text = "(UTC - 06:00) Costa Rica";
            this.uTC0200KievRigaToolStripMenuItem.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC0200KievRigaToolStripMenuItem1
            // 
            this.uTC0200KievRigaToolStripMenuItem1.Name = "uTC0200KievRigaToolStripMenuItem1";
            this.uTC0200KievRigaToolStripMenuItem1.Size = new System.Drawing.Size(256, 26);
            this.uTC0200KievRigaToolStripMenuItem1.Tag = "-5";
            this.uTC0200KievRigaToolStripMenuItem1.Text = "(UTC - 05:00) Haiti";
            this.uTC0200KievRigaToolStripMenuItem1.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC0430AfghanistanToolStripMenuItem
            // 
            this.uTC0430AfghanistanToolStripMenuItem.Name = "uTC0430AfghanistanToolStripMenuItem";
            this.uTC0430AfghanistanToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.uTC0430AfghanistanToolStripMenuItem.Tag = "-1";
            this.uTC0430AfghanistanToolStripMenuItem.Text = "(UTC - 01:00) Portugal";
            this.uTC0430AfghanistanToolStripMenuItem.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC0430AfghanistanToolStripMenuItem1
            // 
            this.uTC0430AfghanistanToolStripMenuItem1.Name = "uTC0430AfghanistanToolStripMenuItem1";
            this.uTC0430AfghanistanToolStripMenuItem1.Size = new System.Drawing.Size(256, 26);
            this.uTC0430AfghanistanToolStripMenuItem1.Tag = "2";
            this.uTC0430AfghanistanToolStripMenuItem1.Text = "(UTC + 02:00) Kiev, Riga";
            this.uTC0430AfghanistanToolStripMenuItem1.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC0430AfghanistanToolStripMenuItem2
            // 
            this.uTC0430AfghanistanToolStripMenuItem2.Name = "uTC0430AfghanistanToolStripMenuItem2";
            this.uTC0430AfghanistanToolStripMenuItem2.Size = new System.Drawing.Size(256, 26);
            this.uTC0430AfghanistanToolStripMenuItem2.Tag = "3";
            this.uTC0430AfghanistanToolStripMenuItem2.Text = "(UTC + 03:00) Moscow";
            this.uTC0430AfghanistanToolStripMenuItem2.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC0430AfghanistanToolStripMenuItem3
            // 
            this.uTC0430AfghanistanToolStripMenuItem3.Name = "uTC0430AfghanistanToolStripMenuItem3";
            this.uTC0430AfghanistanToolStripMenuItem3.Size = new System.Drawing.Size(256, 26);
            this.uTC0430AfghanistanToolStripMenuItem3.Tag = "4,3";
            this.uTC0430AfghanistanToolStripMenuItem3.Text = "(UTC + 04:30) Afghanistan";
            this.uTC0430AfghanistanToolStripMenuItem3.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // uTC0430AfghanistanToolStripMenuItem4
            // 
            this.uTC0430AfghanistanToolStripMenuItem4.Name = "uTC0430AfghanistanToolStripMenuItem4";
            this.uTC0430AfghanistanToolStripMenuItem4.Size = new System.Drawing.Size(256, 26);
            this.uTC0430AfghanistanToolStripMenuItem4.Tag = "6";
            this.uTC0430AfghanistanToolStripMenuItem4.Text = "(UTC + 06:00) Kyrgyzstan";
            this.uTC0430AfghanistanToolStripMenuItem4.Click += new System.EventHandler(this.changeTimezoneToolStripMenuItem_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStripForClock;
            this.DoubleBuffered = true;
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(347, 332);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Clock_Paint);
            this.contextMenuStripForClock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForClock;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondArrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minuteArrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourArrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTimezoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem uTC2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTC0200KievRigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTC0200KievRigaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uTC0430AfghanistanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTC0430AfghanistanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uTC0430AfghanistanToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uTC0430AfghanistanToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem uTC0430AfghanistanToolStripMenuItem4;
    }
}
