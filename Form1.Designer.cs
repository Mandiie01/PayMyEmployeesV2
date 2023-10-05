namespace PayMyEmployeesV2
{
    partial class Form1
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
            this.lblRPH = new System.Windows.Forms.Label();
            this.lblWHours = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.txtWHours = new System.Windows.Forms.TextBox();
            this.txtRPH = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRPH
            // 
            this.lblRPH.AutoSize = true;
            this.lblRPH.Location = new System.Drawing.Point(39, 73);
            this.lblRPH.Name = "lblRPH";
            this.lblRPH.Size = new System.Drawing.Size(78, 13);
            this.lblRPH.TabIndex = 0;
            this.lblRPH.Text = "Rate Per Hour:";
            // 
            // lblWHours
            // 
            this.lblWHours.AutoSize = true;
            this.lblWHours.Location = new System.Drawing.Point(39, 149);
            this.lblWHours.Name = "lblWHours";
            this.lblWHours.Size = new System.Drawing.Size(72, 13);
            this.lblWHours.TabIndex = 1;
            this.lblWHours.Text = "Work Hour/s:";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(463, 53);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(265, 160);
            this.lstResult.TabIndex = 2;
            // 
            // txtWHours
            // 
            this.txtWHours.Location = new System.Drawing.Point(129, 146);
            this.txtWHours.Name = "txtWHours";
            this.txtWHours.Size = new System.Drawing.Size(156, 20);
            this.txtWHours.TabIndex = 3;
            // 
            // txtRPH
            // 
            this.txtRPH.Location = new System.Drawing.Point(129, 70);
            this.txtRPH.Name = "txtRPH";
            this.txtRPH.Size = new System.Drawing.Size(181, 20);
            this.txtRPH.TabIndex = 4;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(61, 239);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(97, 51);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 53);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pay My Employee v2";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(601, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 51);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtRPH);
            this.Controls.Add(this.txtWHours);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.lblWHours);
            this.Controls.Add(this.lblRPH);
            this.Name = "Form1";
            this.Text = "Pay My Employees V2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRPH;
        private System.Windows.Forms.Label lblWHours;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.TextBox txtWHours;
        private System.Windows.Forms.TextBox txtRPH;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}

