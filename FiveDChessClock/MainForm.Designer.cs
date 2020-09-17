namespace FiveDChessClock
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblStaticHeader = new System.Windows.Forms.Label();
            this.LblStaticBlack = new System.Windows.Forms.Label();
            this.LblStaticWhite = new System.Windows.Forms.Label();
            this.LblTimeRemainingWhite = new System.Windows.Forms.Label();
            this.LblTimeRemainingBlack = new System.Windows.Forms.Label();
            this.BtnSetTime = new System.Windows.Forms.Button();
            this.TmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblStaticHeader
            // 
            this.LblStaticHeader.AutoSize = true;
            this.LblStaticHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaticHeader.Location = new System.Drawing.Point(36, 9);
            this.LblStaticHeader.Name = "LblStaticHeader";
            this.LblStaticHeader.Size = new System.Drawing.Size(325, 44);
            this.LblStaticHeader.TabIndex = 0;
            this.LblStaticHeader.Text = "5D Chess - Clock";
            // 
            // LblStaticBlack
            // 
            this.LblStaticBlack.AutoSize = true;
            this.LblStaticBlack.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaticBlack.Location = new System.Drawing.Point(12, 78);
            this.LblStaticBlack.Name = "LblStaticBlack";
            this.LblStaticBlack.Size = new System.Drawing.Size(133, 44);
            this.LblStaticBlack.TabIndex = 1;
            this.LblStaticBlack.Text = "Black:";
            // 
            // LblStaticWhite
            // 
            this.LblStaticWhite.AutoSize = true;
            this.LblStaticWhite.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaticWhite.Location = new System.Drawing.Point(12, 122);
            this.LblStaticWhite.Name = "LblStaticWhite";
            this.LblStaticWhite.Size = new System.Drawing.Size(134, 44);
            this.LblStaticWhite.TabIndex = 2;
            this.LblStaticWhite.Text = "White:";
            // 
            // LblTimeRemainingWhite
            // 
            this.LblTimeRemainingWhite.AutoSize = true;
            this.LblTimeRemainingWhite.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeRemainingWhite.Location = new System.Drawing.Point(151, 122);
            this.LblTimeRemainingWhite.Name = "LblTimeRemainingWhite";
            this.LblTimeRemainingWhite.Size = new System.Drawing.Size(249, 44);
            this.LblTimeRemainingWhite.TabIndex = 4;
            this.LblTimeRemainingWhite.Text = "99h:99m:99s";
            // 
            // LblTimeRemainingBlack
            // 
            this.LblTimeRemainingBlack.AutoSize = true;
            this.LblTimeRemainingBlack.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeRemainingBlack.Location = new System.Drawing.Point(151, 78);
            this.LblTimeRemainingBlack.Name = "LblTimeRemainingBlack";
            this.LblTimeRemainingBlack.Size = new System.Drawing.Size(249, 44);
            this.LblTimeRemainingBlack.TabIndex = 3;
            this.LblTimeRemainingBlack.Text = "99h:99m:99s";
            // 
            // BtnSetTime
            // 
            this.BtnSetTime.Location = new System.Drawing.Point(278, 181);
            this.BtnSetTime.Name = "BtnSetTime";
            this.BtnSetTime.Size = new System.Drawing.Size(112, 41);
            this.BtnSetTime.TabIndex = 5;
            this.BtnSetTime.Text = "Set Time...";
            this.BtnSetTime.UseVisualStyleBackColor = true;
            this.BtnSetTime.Click += new System.EventHandler(this.BtnSetTime_Click);
            // 
            // TmrUpdate
            // 
            this.TmrUpdate.Tick += new System.EventHandler(this.TmrUpdate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 234);
            this.Controls.Add(this.BtnSetTime);
            this.Controls.Add(this.LblTimeRemainingWhite);
            this.Controls.Add(this.LblTimeRemainingBlack);
            this.Controls.Add(this.LblStaticWhite);
            this.Controls.Add(this.LblStaticBlack);
            this.Controls.Add(this.LblStaticHeader);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStaticHeader;
        private System.Windows.Forms.Label LblStaticBlack;
        private System.Windows.Forms.Label LblStaticWhite;
        private System.Windows.Forms.Label LblTimeRemainingWhite;
        private System.Windows.Forms.Label LblTimeRemainingBlack;
        private System.Windows.Forms.Button BtnSetTime;
        private System.Windows.Forms.Timer TmrUpdate;
    }
}

