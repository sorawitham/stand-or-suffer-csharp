namespace StandOrSuffer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numericMinute1;
        private System.Windows.Forms.NumericUpDown numericMinute2;
        private System.Windows.Forms.NumericUpDown numericMinute3;
        private System.Windows.Forms.NumericUpDown numericMinute4;
        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label labelMinuteGroup;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numericMinute1 = new System.Windows.Forms.NumericUpDown();
            this.numericMinute2 = new System.Windows.Forms.NumericUpDown();
            this.numericMinute3 = new System.Windows.Forms.NumericUpDown();
            this.numericMinute4 = new System.Windows.Forms.NumericUpDown();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelMinuteGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericMinute1
            // 
            this.numericMinute1.Location = new System.Drawing.Point(32, 56);
            this.numericMinute1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericMinute1.Name = "numericMinute1";
            this.numericMinute1.Size = new System.Drawing.Size(60, 23);
            this.numericMinute1.TabIndex = 0;
            // 
            // numericMinute2
            // 
            this.numericMinute2.Location = new System.Drawing.Point(108, 56);
            this.numericMinute2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericMinute2.Name = "numericMinute2";
            this.numericMinute2.Size = new System.Drawing.Size(60, 23);
            this.numericMinute2.TabIndex = 1;
            // 
            // numericMinute3
            // 
            this.numericMinute3.Location = new System.Drawing.Point(184, 56);
            this.numericMinute3.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericMinute3.Name = "numericMinute3";
            this.numericMinute3.Size = new System.Drawing.Size(60, 23);
            this.numericMinute3.TabIndex = 2;
            // 
            // numericMinute4
            // 
            this.numericMinute4.Location = new System.Drawing.Point(260, 56);
            this.numericMinute4.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.numericMinute4.Name = "numericMinute4";
            this.numericMinute4.Size = new System.Drawing.Size(60, 23);
            this.numericMinute4.TabIndex = 3;
            // 
            // buttonToggle
            // 
            this.buttonToggle.Location = new System.Drawing.Point(110, 100);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(120, 32);
            this.buttonToggle.TabIndex = 4;
            this.buttonToggle.Text = "Start";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.ButtonToggle_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Stand Reminder";
            this.notifyIcon.Visible = true;
            // 
            // labelMinuteGroup
            // 
            this.labelMinuteGroup.Location = new System.Drawing.Point(28, 24);
            this.labelMinuteGroup.Name = "labelMinuteGroup";
            this.labelMinuteGroup.Size = new System.Drawing.Size(292, 20);
            this.labelMinuteGroup.TabIndex = 5;
            this.labelMinuteGroup.Text = "Alert every hour at minutes:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(352, 156);
            this.Controls.Add(this.labelMinuteGroup);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.numericMinute4);
            this.Controls.Add(this.numericMinute3);
            this.Controls.Add(this.numericMinute2);
            this.Controls.Add(this.numericMinute1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stand or Suffer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute4)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
