namespace TImeBoom.UserControls
{
    partial class AlarmEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numHr = new NumericUpDown();
            numMin = new NumericUpDown();
            txtName = new TextBox();
            label1 = new Label();
            listAMPM = new ListBox();
            chxSu = new CheckBox();
            chxMon = new CheckBox();
            chxWed = new CheckBox();
            chxTue = new CheckBox();
            chxFri = new CheckBox();
            chxThur = new CheckBox();
            chxSat = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnDel = new Button();
            cbxRepeat = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numHr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            SuspendLayout();
            // 
            // numHr
            // 
            numHr.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numHr.Location = new Point(84, 93);
            numHr.Name = "numHr";
            numHr.Size = new Size(88, 62);
            numHr.TabIndex = 0;
            // 
            // numMin
            // 
            numMin.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMin.Location = new Point(178, 93);
            numMin.Name = "numMin";
            numMin.Size = new Size(88, 62);
            numMin.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(77, 230);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 42);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 200);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Set Name";
            // 
            // listAMPM
            // 
            listAMPM.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listAMPM.FormattingEnabled = true;
            listAMPM.ItemHeight = 38;
            listAMPM.Items.AddRange(new object[] { "AM", "PM" });
            listAMPM.Location = new Point(282, 102);
            listAMPM.Name = "listAMPM";
            listAMPM.Size = new Size(90, 42);
            listAMPM.TabIndex = 24;
            // 
            // chxSu
            // 
            chxSu.Appearance = Appearance.Button;
            chxSu.AutoSize = true;
            chxSu.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxSu.Location = new Point(39, 341);
            chxSu.Name = "chxSu";
            chxSu.Size = new Size(39, 29);
            chxSu.TabIndex = 25;
            chxSu.Text = "Su";
            chxSu.UseVisualStyleBackColor = true;
            // 
            // chxMon
            // 
            chxMon.Appearance = Appearance.Button;
            chxMon.AutoSize = true;
            chxMon.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxMon.Location = new Point(84, 341);
            chxMon.Name = "chxMon";
            chxMon.Size = new Size(50, 29);
            chxMon.TabIndex = 26;
            chxMon.Text = "Mon";
            chxMon.UseVisualStyleBackColor = true;
            // 
            // chxWed
            // 
            chxWed.Appearance = Appearance.Button;
            chxWed.AutoSize = true;
            chxWed.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxWed.Location = new Point(191, 341);
            chxWed.Name = "chxWed";
            chxWed.Size = new Size(54, 29);
            chxWed.TabIndex = 28;
            chxWed.Text = "Wed";
            chxWed.UseVisualStyleBackColor = true;
            // 
            // chxTue
            // 
            chxTue.Appearance = Appearance.Button;
            chxTue.AutoSize = true;
            chxTue.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxTue.Location = new Point(140, 341);
            chxTue.Name = "chxTue";
            chxTue.Size = new Size(45, 29);
            chxTue.TabIndex = 27;
            chxTue.Text = "Tue";
            chxTue.UseVisualStyleBackColor = true;
            // 
            // chxFri
            // 
            chxFri.Appearance = Appearance.Button;
            chxFri.AutoSize = true;
            chxFri.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxFri.Location = new Point(309, 341);
            chxFri.Name = "chxFri";
            chxFri.Size = new Size(39, 29);
            chxFri.TabIndex = 30;
            chxFri.Text = "Fri";
            chxFri.UseVisualStyleBackColor = true;
            // 
            // chxThur
            // 
            chxThur.Appearance = Appearance.Button;
            chxThur.AutoSize = true;
            chxThur.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxThur.Location = new Point(251, 341);
            chxThur.Name = "chxThur";
            chxThur.Size = new Size(52, 29);
            chxThur.TabIndex = 29;
            chxThur.Text = "Thur";
            chxThur.UseVisualStyleBackColor = true;
            // 
            // chxSat
            // 
            chxSat.Appearance = Appearance.Button;
            chxSat.AutoSize = true;
            chxSat.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxSat.Location = new Point(354, 341);
            chxSat.Name = "chxSat";
            chxSat.Size = new Size(43, 29);
            chxSat.TabIndex = 31;
            chxSat.Text = "Sat";
            chxSat.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(39, 424);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 56);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(264, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 56);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(282, 12);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(115, 37);
            btnDel.TabIndex = 34;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // cbxRepeat
            // 
            cbxRepeat.AutoSize = true;
            cbxRepeat.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxRepeat.Location = new Point(39, 302);
            cbxRepeat.Name = "cbxRepeat";
            cbxRepeat.Size = new Size(128, 23);
            cbxRepeat.TabIndex = 35;
            cbxRepeat.Text = "Repeat Alarm";
            cbxRepeat.UseVisualStyleBackColor = true;
            // 
            // AlarmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 509);
            Controls.Add(cbxRepeat);
            Controls.Add(btnDel);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chxSat);
            Controls.Add(chxFri);
            Controls.Add(chxThur);
            Controls.Add(chxWed);
            Controls.Add(chxTue);
            Controls.Add(chxMon);
            Controls.Add(chxSu);
            Controls.Add(listAMPM);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(numMin);
            Controls.Add(numHr);
            Name = "AlarmEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlarmEditor";
            Load += AlarmEditor_Load;
            ((System.ComponentModel.ISupportInitialize)numHr).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numHr;
        private NumericUpDown numMin;
        private TextBox txtName;
        private Label label1;
        private ListBox listAMPM;
        private CheckBox chxSu;
        private CheckBox chxMon;
        private CheckBox chxWed;
        private CheckBox chxTue;
        private CheckBox chxFri;
        private CheckBox chxThur;
        private CheckBox chxSat;
        private Button btnSave;
        private Button btnCancel;
        private Button btnDel;
        private CheckBox cbxRepeat;
    }
}