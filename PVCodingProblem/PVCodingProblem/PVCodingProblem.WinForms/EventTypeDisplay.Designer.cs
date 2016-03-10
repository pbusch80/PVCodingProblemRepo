namespace PVCodingProblem.WinForms
{
    partial class EventTypeDisplay
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
            this.eventTypeResultsGv = new System.Windows.Forms.DataGridView();
            this.registerBtn = new System.Windows.Forms.Button();
            this.diagnoseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeResultsGv)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTypeResultsGv
            // 
            this.eventTypeResultsGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventTypeResultsGv.Location = new System.Drawing.Point(12, 102);
            this.eventTypeResultsGv.Name = "eventTypeResultsGv";
            this.eventTypeResultsGv.Size = new System.Drawing.Size(863, 585);
            this.eventTypeResultsGv.TabIndex = 0;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(12, 73);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // diagnoseBtn
            // 
            this.diagnoseBtn.Location = new System.Drawing.Point(93, 73);
            this.diagnoseBtn.Name = "diagnoseBtn";
            this.diagnoseBtn.Size = new System.Drawing.Size(75, 23);
            this.diagnoseBtn.TabIndex = 2;
            this.diagnoseBtn.Text = "Diagnose";
            this.diagnoseBtn.UseVisualStyleBackColor = true;
            this.diagnoseBtn.Click += new System.EventHandler(this.diagnoseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which Event Type Would you like to see output?";
            // 
            // EventTypeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagnoseBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.eventTypeResultsGv);
            this.Name = "EventTypeDisplay";
            this.Text = "EventTypeDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeResultsGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView eventTypeResultsGv;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button diagnoseBtn;
        private System.Windows.Forms.Label label1;
    }
}