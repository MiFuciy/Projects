namespace NetUI
{
    partial class Form_Ip_Options
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
            this.UsedIPList = new System.Windows.Forms.ListBox();
            this.used_ip = new System.Windows.Forms.Label();
            this.tb_trace_ip = new System.Windows.Forms.TextBox();
            this.Trace_add = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsedIPList
            // 
            this.UsedIPList.FormattingEnabled = true;
            this.UsedIPList.Location = new System.Drawing.Point(12, 38);
            this.UsedIPList.Name = "UsedIPList";
            this.UsedIPList.Size = new System.Drawing.Size(350, 212);
            this.UsedIPList.TabIndex = 1;
            // 
            // used_ip
            // 
            this.used_ip.AutoSize = true;
            this.used_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.used_ip.Location = new System.Drawing.Point(124, 11);
            this.used_ip.Name = "used_ip";
            this.used_ip.Size = new System.Drawing.Size(125, 24);
            this.used_ip.TabIndex = 3;
            this.used_ip.Text = "List of used IP";
            // 
            // tb_trace_ip
            // 
            this.tb_trace_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_trace_ip.Location = new System.Drawing.Point(377, 38);
            this.tb_trace_ip.Name = "tb_trace_ip";
            this.tb_trace_ip.Size = new System.Drawing.Size(169, 26);
            this.tb_trace_ip.TabIndex = 4;
            this.tb_trace_ip.Text = "192.168.0.104";
            // 
            // Trace_add
            // 
            this.Trace_add.Location = new System.Drawing.Point(377, 70);
            this.Trace_add.Name = "Trace_add";
            this.Trace_add.Size = new System.Drawing.Size(169, 42);
            this.Trace_add.TabIndex = 5;
            this.Trace_add.Text = "Add Ip to use list";
            this.Trace_add.UseVisualStyleBackColor = true;
            this.Trace_add.Click += new System.EventHandler(this.Trace_add_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(377, 208);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(169, 42);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form_Ip_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 268);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Trace_add);
            this.Controls.Add(this.tb_trace_ip);
            this.Controls.Add(this.used_ip);
            this.Controls.Add(this.UsedIPList);
            this.Name = "Form_Ip_Options";
            this.Text = "IP Options";
            this.Load += new System.EventHandler(this.Form_Ip_Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox UsedIPList;
        private System.Windows.Forms.Label used_ip;
        private System.Windows.Forms.TextBox tb_trace_ip;
        private System.Windows.Forms.Button Trace_add;
        private System.Windows.Forms.Button Back;
    }
}