namespace ControlClock
{
    partial class ClockAndIndicator
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fullIndicator3 = new ControlClock.FullIndicator();
            this.fullIndicator2 = new ControlClock.FullIndicator();
            this.fullIndicator1 = new ControlClock.FullIndicator();
            this.clock1 = new ControlClock.Clock();
            this.SuspendLayout();
            // 
            // fullIndicator3
            // 
            this.fullIndicator3.Indicator = ControlClock.FullIndicator.IndicatorMode.Left;
            this.fullIndicator3.Location = new System.Drawing.Point(-99, 76);
            this.fullIndicator3.Margin = new System.Windows.Forms.Padding(2);
            //this.fullIndicator3.MaxValue = 100;
            //this.fullIndicator3.MinValue = 0;
            this.fullIndicator3.Name = "fullIndicator3";
            this.fullIndicator3.Size = new System.Drawing.Size(242, 132);
            this.fullIndicator3.TabIndex = 3;
            //this.fullIndicator3.Value = 0;
            // 
            // fullIndicator2
            // 
            this.fullIndicator2.Indicator = ControlClock.FullIndicator.IndicatorMode.Right;
            this.fullIndicator2.Location = new System.Drawing.Point(185, 76);
            this.fullIndicator2.Margin = new System.Windows.Forms.Padding(2);
            //this.fullIndicator2.MaxValue = 100;
           // this.fullIndicator2.MinValue = 0;
            this.fullIndicator2.Name = "fullIndicator2";
            this.fullIndicator2.Size = new System.Drawing.Size(243, 132);
            this.fullIndicator2.TabIndex = 2;
           // this.fullIndicator2.Value = 0;
            // 
            // fullIndicator1
            // 
            this.fullIndicator1.Indicator = ControlClock.FullIndicator.IndicatorMode.Full;
            this.fullIndicator1.Location = new System.Drawing.Point(451, 23);
            this.fullIndicator1.Margin = new System.Windows.Forms.Padding(2);
           // this.fullIndicator1.MaxValue = 100;
           // this.fullIndicator1.MinValue = 0;
            this.fullIndicator1.Name = "fullIndicator1";
            this.fullIndicator1.Size = new System.Drawing.Size(279, 185);
            this.fullIndicator1.TabIndex = 1;
            //this.fullIndicator1.Value = 0;
            // 
            // clock1
            // 
            this.clock1.Location = new System.Drawing.Point(261, 236);
            this.clock1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(232, 197);
            this.clock1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 467);
            this.Controls.Add(this.fullIndicator3);
            this.Controls.Add(this.fullIndicator2);
            this.Controls.Add(this.fullIndicator1);
            this.Controls.Add(this.clock1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Clock clock1;
        private FullIndicator fullIndicator1;
        private FullIndicator fullIndicator2;
        private FullIndicator fullIndicator3;
    }
}

