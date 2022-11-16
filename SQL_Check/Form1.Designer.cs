namespace SQL_Check
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_change = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.IndianRed;
            this.btn_change.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_change.Location = new System.Drawing.Point(146, 62);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(121, 34);
            this.btn_change.TabIndex = 0;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_status.Location = new System.Drawing.Point(403, 65);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(80, 31);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 148);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_change);
            this.Name = "Form1";
            this.Text = "Open/Closed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_change;
        private Label lbl_status;
    }
}