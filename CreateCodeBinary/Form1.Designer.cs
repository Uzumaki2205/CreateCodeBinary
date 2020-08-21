namespace CreateCodeBinary
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTable = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.panelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính hiệu suất từ mã";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxCount
            // 
            this.tbxCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCount.Location = new System.Drawing.Point(168, 77);
            this.tbxCount.Multiline = true;
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(47, 26);
            this.tbxCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số xác suất";
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.panelInput);
            this.panelTable.Location = new System.Drawing.Point(12, 130);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(776, 675);
            this.panelTable.TabIndex = 3;
            // 
            // panelInput
            // 
            this.panelInput.Location = new System.Drawing.Point(18, 296);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(727, 376);
            this.panelInput.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProcess.Location = new System.Drawing.Point(682, 72);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(106, 34);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "OK";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnCal
            // 
            this.btnCal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCal.Location = new System.Drawing.Point(561, 72);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(106, 34);
            this.btnCal.TabIndex = 5;
            this.btnCal.Text = "Calculator";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 817);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Panel panelInput;
    }
}

