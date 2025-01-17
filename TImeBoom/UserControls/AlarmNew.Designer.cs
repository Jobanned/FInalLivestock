namespace TImeBoom.UserControls
{
    partial class AlarmNew
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmNew));
            lblTime = new Label();
            chxSat = new CheckBox();
            chxFri = new CheckBox();
            chxThur = new CheckBox();
            chxWed = new CheckBox();
            chxTue = new CheckBox();
            chxMon = new CheckBox();
            chxSu = new CheckBox();
            lblName = new Label();
            checkBox1 = new CheckBox();
            ptxEditBtn = new PictureBox();
            lblNotif = new Label();
            ((System.ComponentModel.ISupportInitialize)ptxEditBtn).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(93, 123);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(236, 89);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00";
            // 
            // chxSat
            // 
            chxSat.Appearance = Appearance.Button;
            chxSat.AutoSize = true;
            chxSat.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxSat.ForeColor = Color.DimGray;
            chxSat.Location = new Point(363, 238);
            chxSat.Name = "chxSat";
            chxSat.Size = new Size(43, 29);
            chxSat.TabIndex = 38;
            chxSat.Text = "Sat";
            chxSat.UseVisualStyleBackColor = true;
            // 
            // chxFri
            // 
            chxFri.Appearance = Appearance.Button;
            chxFri.AutoSize = true;
            chxFri.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxFri.ForeColor = Color.DimGray;
            chxFri.Location = new Point(318, 238);
            chxFri.Name = "chxFri";
            chxFri.Size = new Size(39, 29);
            chxFri.TabIndex = 37;
            chxFri.Text = "Fri";
            chxFri.UseVisualStyleBackColor = true;
            // 
            // chxThur
            // 
            chxThur.Appearance = Appearance.Button;
            chxThur.AutoSize = true;
            chxThur.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxThur.ForeColor = Color.DimGray;
            chxThur.Location = new Point(260, 238);
            chxThur.Name = "chxThur";
            chxThur.Size = new Size(52, 29);
            chxThur.TabIndex = 36;
            chxThur.Text = "Thur";
            chxThur.UseVisualStyleBackColor = true;
            // 
            // chxWed
            // 
            chxWed.Appearance = Appearance.Button;
            chxWed.AutoSize = true;
            chxWed.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxWed.ForeColor = Color.DimGray;
            chxWed.Location = new Point(200, 238);
            chxWed.Name = "chxWed";
            chxWed.Size = new Size(54, 29);
            chxWed.TabIndex = 35;
            chxWed.Text = "Wed";
            chxWed.UseVisualStyleBackColor = true;
            // 
            // chxTue
            // 
            chxTue.Appearance = Appearance.Button;
            chxTue.AutoSize = true;
            chxTue.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxTue.ForeColor = Color.DimGray;
            chxTue.Location = new Point(149, 238);
            chxTue.Name = "chxTue";
            chxTue.Size = new Size(45, 29);
            chxTue.TabIndex = 34;
            chxTue.Text = "Tue";
            chxTue.UseVisualStyleBackColor = true;
            // 
            // chxMon
            // 
            chxMon.Appearance = Appearance.Button;
            chxMon.AutoSize = true;
            chxMon.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxMon.ForeColor = Color.DimGray;
            chxMon.Location = new Point(93, 238);
            chxMon.Name = "chxMon";
            chxMon.Size = new Size(50, 29);
            chxMon.TabIndex = 33;
            chxMon.Text = "Mon";
            chxMon.UseVisualStyleBackColor = true;
            // 
            // chxSu
            // 
            chxSu.Appearance = Appearance.Button;
            chxSu.AutoSize = true;
            chxSu.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxSu.ForeColor = Color.DimGray;
            chxSu.Location = new Point(48, 238);
            chxSu.Name = "chxSu";
            chxSu.Size = new Size(39, 29);
            chxSu.TabIndex = 32;
            chxSu.Text = "Su";
            chxSu.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(48, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(157, 35);
            lblName.TabIndex = 39;
            lblName.Text = "New Alarm";
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.DimGray;
            checkBox1.Location = new Point(327, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 29);
            checkBox1.TabIndex = 40;
            checkBox1.Text = "ON/OFF";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ptxEditBtn
            // 
            ptxEditBtn.Image = (Image)resources.GetObject("ptxEditBtn.Image");
            ptxEditBtn.Location = new Point(437, 3);
            ptxEditBtn.Name = "ptxEditBtn";
            ptxEditBtn.Size = new Size(39, 36);
            ptxEditBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxEditBtn.TabIndex = 41;
            ptxEditBtn.TabStop = false;
            ptxEditBtn.Click += ptxEditBtn_Click;
            // 
            // lblNotif
            // 
            lblNotif.AutoSize = true;
            lblNotif.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotif.ForeColor = Color.White;
            lblNotif.Location = new Point(327, 92);
            lblNotif.Name = "lblNotif";
            lblNotif.Size = new Size(0, 19);
            lblNotif.TabIndex = 42;
            // 
            // AlarmNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNotif);
            Controls.Add(ptxEditBtn);
            Controls.Add(checkBox1);
            Controls.Add(lblName);
            Controls.Add(chxSat);
            Controls.Add(chxFri);
            Controls.Add(chxThur);
            Controls.Add(chxWed);
            Controls.Add(chxTue);
            Controls.Add(chxMon);
            Controls.Add(chxSu);
            Controls.Add(lblTime);
            Name = "AlarmNew";
            Size = new Size(479, 323);
            Load += AlarmNew_Load;
            ((System.ComponentModel.ISupportInitialize)ptxEditBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private CheckBox chxSat;
        private CheckBox chxFri;
        private CheckBox chxThur;
        private CheckBox chxWed;
        private CheckBox chxTue;
        private CheckBox chxMon;
        private CheckBox chxSu;
        private Label lblName;
        private CheckBox checkBox1;
        private PictureBox ptxEditBtn;
        private Label lblNotif;
    }
}
