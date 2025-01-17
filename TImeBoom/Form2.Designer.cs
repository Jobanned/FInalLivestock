namespace TImeBoom
{
    partial class Form2
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
            numSec = new NumericUpDown();
            txtName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numHr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSec).BeginInit();
            SuspendLayout();
            // 
            // numHr
            // 
            numHr.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numHr.Location = new Point(25, 105);
            numHr.Name = "numHr";
            numHr.Size = new Size(124, 76);
            numHr.TabIndex = 0;
            numHr.ValueChanged += numHr_ValueChanged;
            // 
            // numMin
            // 
            numMin.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMin.Location = new Point(155, 105);
            numMin.Name = "numMin";
            numMin.Size = new Size(124, 76);
            numMin.TabIndex = 1;
            numMin.ValueChanged += numMin_ValueChanged;
            // 
            // numSec
            // 
            numSec.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSec.Location = new Point(285, 105);
            numSec.Name = "numSec";
            numSec.Size = new Size(124, 76);
            numSec.TabIndex = 2;
            numSec.ValueChanged += numSec_ValueChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(104, 281);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 41);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(25, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(181, 55);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(181, 55);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 242);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 8;
            label1.Text = "Set Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(309, 27);
            button1.Name = "button1";
            button1.Size = new Size(100, 39);
            button1.TabIndex = 9;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 509);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(numSec);
            Controls.Add(numMin);
            Controls.Add(numHr);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Timer";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numHr).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numHr;
        private NumericUpDown numMin;
        private NumericUpDown numSec;
        private TextBox txtName;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Button button1;
    }
}