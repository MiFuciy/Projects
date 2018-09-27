namespace NetUI
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.Net_List = new System.Windows.Forms.Button();
            this.Start_Al = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.cmbInterfaces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ip_options = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Label();
            this.Red_text = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Main_page = new System.Windows.Forms.TabPage();
            this.Graph_page = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tabs.SuspendLayout();
            this.Main_page.SuspendLayout();
            this.Graph_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Net_List
            // 
            this.Net_List.Location = new System.Drawing.Point(537, 11);
            this.Net_List.Name = "Net_List";
            this.Net_List.Size = new System.Drawing.Size(170, 38);
            this.Net_List.TabIndex = 1;
            this.Net_List.Text = "Network List";
            this.Net_List.UseVisualStyleBackColor = true;
            this.Net_List.Click += new System.EventHandler(this.Net_List_Click);
            // 
            // Start_Al
            // 
            this.Start_Al.Location = new System.Drawing.Point(537, 107);
            this.Start_Al.Name = "Start_Al";
            this.Start_Al.Size = new System.Drawing.Size(170, 38);
            this.Start_Al.TabIndex = 2;
            this.Start_Al.Text = "Start Analyse";
            this.Start_Al.UseVisualStyleBackColor = true;
            this.Start_Al.Click += new System.EventHandler(this.Start_Al_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(537, 360);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(170, 38);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit Program";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(6, 11);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(525, 387);
            this.treeView.TabIndex = 4;
            // 
            // cmbInterfaces
            // 
            this.cmbInterfaces.FormattingEnabled = true;
            this.cmbInterfaces.Location = new System.Drawing.Point(537, 80);
            this.cmbInterfaces.Name = "cmbInterfaces";
            this.cmbInterfaces.Size = new System.Drawing.Size(170, 21);
            this.cmbInterfaces.TabIndex = 5;
            this.cmbInterfaces.SelectedIndexChanged += new System.EventHandler(this.cmbInterfaces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose IP Address";
            // 
            // Ip_options
            // 
            this.Ip_options.Location = new System.Drawing.Point(537, 164);
            this.Ip_options.Name = "Ip_options";
            this.Ip_options.Size = new System.Drawing.Size(170, 38);
            this.Ip_options.TabIndex = 7;
            this.Ip_options.Text = "IP Options";
            this.Ip_options.UseVisualStyleBackColor = true;
            this.Ip_options.Click += new System.EventHandler(this.Ip_options_Click);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Red.Location = new System.Drawing.Point(536, 303);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(89, 20);
            this.Red.TabIndex = 8;
            this.Red.Text = "Red Nodes";
            // 
            // Red_text
            // 
            this.Red_text.AutoSize = true;
            this.Red_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Red_text.Location = new System.Drawing.Point(537, 323);
            this.Red_text.Name = "Red_text";
            this.Red_text.Size = new System.Drawing.Size(152, 34);
            this.Red_text.TabIndex = 9;
            this.Red_text.Text = "are suspicious due it\'s \r\nbig lenght";
            // 
            // time
            // 
            this.time.Interval = 10000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Main_page);
            this.Tabs.Controls.Add(this.Graph_page);
            this.Tabs.Location = new System.Drawing.Point(12, 5);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(721, 430);
            this.Tabs.TabIndex = 11;
            // 
            // Main_page
            // 
            this.Main_page.Controls.Add(this.treeView);
            this.Main_page.Controls.Add(this.Exit);
            this.Main_page.Controls.Add(this.Red_text);
            this.Main_page.Controls.Add(this.Net_List);
            this.Main_page.Controls.Add(this.Red);
            this.Main_page.Controls.Add(this.Start_Al);
            this.Main_page.Controls.Add(this.Ip_options);
            this.Main_page.Controls.Add(this.cmbInterfaces);
            this.Main_page.Controls.Add(this.label1);
            this.Main_page.Location = new System.Drawing.Point(4, 22);
            this.Main_page.Name = "Main_page";
            this.Main_page.Padding = new System.Windows.Forms.Padding(3);
            this.Main_page.Size = new System.Drawing.Size(713, 404);
            this.Main_page.TabIndex = 0;
            this.Main_page.Text = "Main";
            this.Main_page.UseVisualStyleBackColor = true;
            // 
            // Graph_page
            // 
            this.Graph_page.Controls.Add(this.chart);
            this.Graph_page.Location = new System.Drawing.Point(4, 22);
            this.Graph_page.Name = "Graph_page";
            this.Graph_page.Padding = new System.Windows.Forms.Padding(3);
            this.Graph_page.Size = new System.Drawing.Size(713, 404);
            this.Graph_page.TabIndex = 1;
            this.Graph_page.Text = "Graph";
            this.Graph_page.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(3, 6);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(704, 392);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 440);
            this.Controls.Add(this.Tabs);
            this.Name = "Form_Main";
            this.Text = "Net UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnifferForm_FormClosing);
            this.Load += new System.EventHandler(this.SnifferForm_Load);
            this.Tabs.ResumeLayout(false);
            this.Main_page.ResumeLayout(false);
            this.Main_page.PerformLayout();
            this.Graph_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Net_List;
        private System.Windows.Forms.Button Start_Al;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ComboBox cmbInterfaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ip_options;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Red_text;
        public System.Windows.Forms.Timer time;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Main_page;
        private System.Windows.Forms.TabPage Graph_page;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}