namespace TP_MOD3_1302213038
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.labInput = new System.Windows.Forms.Label();
            this.labOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(176, 149);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 32);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(176, 86);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(222, 36);
            this.txtInput.TabIndex = 1;
            // 
            // labInput
            // 
            this.labInput.AutoSize = true;
            this.labInput.Location = new System.Drawing.Point(56, 89);
            this.labInput.Name = "labInput";
            this.labInput.Size = new System.Drawing.Size(159, 29);
            this.labInput.TabIndex = 2;
            this.labInput.Text = "Input Nama :";
            // 
            // labOutput
            // 
            this.labOutput.AutoSize = true;
            this.labOutput.Location = new System.Drawing.Point(134, 215);
            this.labOutput.Name = "labOutput";
            this.labOutput.Size = new System.Drawing.Size(0, 29);
            this.labOutput.TabIndex = 3;
            this.labOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.labOutput);
            this.Controls.Add(this.labInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "TP_MOD3_1302213038";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label labInput;
        private System.Windows.Forms.Label labOutput;
    }
}

