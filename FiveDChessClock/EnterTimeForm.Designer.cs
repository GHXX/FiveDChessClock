namespace FiveDChessClock
{
    partial class EnterTimeForm
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
            this.NumHrs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumMins = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NumSecs = new System.Windows.Forms.NumericUpDown();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSaveTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // NumHrs
            // 
            this.NumHrs.Location = new System.Drawing.Point(15, 42);
            this.NumHrs.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumHrs.Name = "NumHrs";
            this.NumHrs.Size = new System.Drawing.Size(48, 20);
            this.NumHrs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter the desired time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(69, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minutes";
            // 
            // NumMins
            // 
            this.NumMins.Location = new System.Drawing.Point(15, 68);
            this.NumMins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumMins.Name = "NumMins";
            this.NumMins.Size = new System.Drawing.Size(48, 20);
            this.NumMins.TabIndex = 5;
            this.NumMins.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(69, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seconds";
            // 
            // NumSecs
            // 
            this.NumSecs.Location = new System.Drawing.Point(15, 94);
            this.NumSecs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumSecs.Name = "NumSecs";
            this.NumSecs.Size = new System.Drawing.Size(48, 20);
            this.NumSecs.TabIndex = 7;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(77, 136);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSaveTime
            // 
            this.BtnSaveTime.Location = new System.Drawing.Point(158, 136);
            this.BtnSaveTime.Name = "BtnSaveTime";
            this.BtnSaveTime.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveTime.TabIndex = 10;
            this.BtnSaveTime.Text = "Set Time";
            this.BtnSaveTime.UseVisualStyleBackColor = true;
            this.BtnSaveTime.Click += new System.EventHandler(this.BtnSaveTime_Click);
            // 
            // EnterTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 171);
            this.Controls.Add(this.BtnSaveTime);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumSecs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumMins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumHrs);
            this.Name = "EnterTimeForm";
            this.Text = "Change Time";
            this.Load += new System.EventHandler(this.EnterTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSecs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumHrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumMins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumSecs;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSaveTime;
    }
}