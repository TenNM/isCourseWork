namespace isCourseWork
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePortfolio = new System.Windows.Forms.TabPage();
            this.buttonDoRequest = new System.Windows.Forms.Button();
            this.checkedListBoxAdapters = new System.Windows.Forms.CheckedListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageAdapters = new System.Windows.Forms.TabPage();
            this.buttonInitAll = new System.Windows.Forms.Button();
            this.buttonDelAdapter = new System.Windows.Forms.Button();
            this.buttonAddAdapter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCheckConnAll = new System.Windows.Forms.Button();
            this.checkedListBoxAssets = new System.Windows.Forms.CheckedListBox();
            this.buttonSetPass = new System.Windows.Forms.Button();
            this.labelAdapters = new System.Windows.Forms.Label();
            this.labelAssets = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePortfolio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageAdapters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePortfolio);
            this.tabControl1.Controls.Add(this.tabPageAdapters);
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 419);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePortfolio
            // 
            this.tabPagePortfolio.Controls.Add(this.comboBox1);
            this.tabPagePortfolio.Controls.Add(this.labelAssets);
            this.tabPagePortfolio.Controls.Add(this.labelAdapters);
            this.tabPagePortfolio.Controls.Add(this.checkedListBoxAssets);
            this.tabPagePortfolio.Controls.Add(this.buttonDoRequest);
            this.tabPagePortfolio.Controls.Add(this.checkedListBoxAdapters);
            this.tabPagePortfolio.Controls.Add(this.chart1);
            this.tabPagePortfolio.Location = new System.Drawing.Point(4, 29);
            this.tabPagePortfolio.Name = "tabPagePortfolio";
            this.tabPagePortfolio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePortfolio.Size = new System.Drawing.Size(797, 386);
            this.tabPagePortfolio.TabIndex = 0;
            this.tabPagePortfolio.Text = "Portfolio";
            this.tabPagePortfolio.UseVisualStyleBackColor = true;
            // 
            // buttonDoRequest
            // 
            this.buttonDoRequest.Location = new System.Drawing.Point(673, 101);
            this.buttonDoRequest.Name = "buttonDoRequest";
            this.buttonDoRequest.Size = new System.Drawing.Size(100, 100);
            this.buttonDoRequest.TabIndex = 2;
            this.buttonDoRequest.Text = "Do request";
            this.buttonDoRequest.UseVisualStyleBackColor = true;
            this.buttonDoRequest.Click += new System.EventHandler(this.buttonDoRequest_Click);
            // 
            // checkedListBoxAdapters
            // 
            this.checkedListBoxAdapters.FormattingEnabled = true;
            this.checkedListBoxAdapters.Location = new System.Drawing.Point(421, 29);
            this.checkedListBoxAdapters.Name = "checkedListBoxAdapters";
            this.checkedListBoxAdapters.Size = new System.Drawing.Size(120, 349);
            this.checkedListBoxAdapters.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(400, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPageAdapters
            // 
            this.tabPageAdapters.Controls.Add(this.buttonSetPass);
            this.tabPageAdapters.Controls.Add(this.buttonCheckConnAll);
            this.tabPageAdapters.Controls.Add(this.buttonInitAll);
            this.tabPageAdapters.Controls.Add(this.buttonDelAdapter);
            this.tabPageAdapters.Controls.Add(this.buttonAddAdapter);
            this.tabPageAdapters.Controls.Add(this.dataGridView1);
            this.tabPageAdapters.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdapters.Name = "tabPageAdapters";
            this.tabPageAdapters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdapters.Size = new System.Drawing.Size(797, 386);
            this.tabPageAdapters.TabIndex = 1;
            this.tabPageAdapters.Text = "Adapters";
            this.tabPageAdapters.UseVisualStyleBackColor = true;
            // 
            // buttonInitAll
            // 
            this.buttonInitAll.Location = new System.Drawing.Point(578, 247);
            this.buttonInitAll.Name = "buttonInitAll";
            this.buttonInitAll.Size = new System.Drawing.Size(100, 100);
            this.buttonInitAll.TabIndex = 3;
            this.buttonInitAll.Text = "Init All";
            this.buttonInitAll.UseVisualStyleBackColor = true;
            this.buttonInitAll.Click += new System.EventHandler(this.buttonInitAll_Click);
            // 
            // buttonDelAdapter
            // 
            this.buttonDelAdapter.Location = new System.Drawing.Point(684, 141);
            this.buttonDelAdapter.Name = "buttonDelAdapter";
            this.buttonDelAdapter.Size = new System.Drawing.Size(100, 100);
            this.buttonDelAdapter.TabIndex = 2;
            this.buttonDelAdapter.Text = "Del";
            this.buttonDelAdapter.UseVisualStyleBackColor = true;
            this.buttonDelAdapter.Click += new System.EventHandler(this.buttonDelAdapter_Click);
            // 
            // buttonAddAdapter
            // 
            this.buttonAddAdapter.Location = new System.Drawing.Point(578, 141);
            this.buttonAddAdapter.Name = "buttonAddAdapter";
            this.buttonAddAdapter.Size = new System.Drawing.Size(100, 100);
            this.buttonAddAdapter.TabIndex = 1;
            this.buttonAddAdapter.Text = "Add";
            this.buttonAddAdapter.UseVisualStyleBackColor = true;
            this.buttonAddAdapter.Click += new System.EventHandler(this.buttonAddAdapter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(564, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCheckConnAll
            // 
            this.buttonCheckConnAll.Location = new System.Drawing.Point(684, 247);
            this.buttonCheckConnAll.Name = "buttonCheckConnAll";
            this.buttonCheckConnAll.Size = new System.Drawing.Size(100, 100);
            this.buttonCheckConnAll.TabIndex = 4;
            this.buttonCheckConnAll.Text = "Check connection All";
            this.buttonCheckConnAll.UseVisualStyleBackColor = true;
            this.buttonCheckConnAll.Click += new System.EventHandler(this.buttonCheckConnAll_Click);
            // 
            // checkedListBoxAssets
            // 
            this.checkedListBoxAssets.FormattingEnabled = true;
            this.checkedListBoxAssets.Location = new System.Drawing.Point(547, 29);
            this.checkedListBoxAssets.Name = "checkedListBoxAssets";
            this.checkedListBoxAssets.Size = new System.Drawing.Size(120, 349);
            this.checkedListBoxAssets.TabIndex = 3;
            // 
            // buttonSetPass
            // 
            this.buttonSetPass.Location = new System.Drawing.Point(578, 6);
            this.buttonSetPass.Name = "buttonSetPass";
            this.buttonSetPass.Size = new System.Drawing.Size(100, 100);
            this.buttonSetPass.TabIndex = 5;
            this.buttonSetPass.Text = "Set Pass";
            this.buttonSetPass.UseVisualStyleBackColor = true;
            this.buttonSetPass.Click += new System.EventHandler(this.buttonSetPass_Click);
            // 
            // labelAdapters
            // 
            this.labelAdapters.AutoSize = true;
            this.labelAdapters.Location = new System.Drawing.Point(417, 6);
            this.labelAdapters.Name = "labelAdapters";
            this.labelAdapters.Size = new System.Drawing.Size(74, 20);
            this.labelAdapters.TabIndex = 4;
            this.labelAdapters.Text = "Adapters";
            // 
            // labelAssets
            // 
            this.labelAssets.AutoSize = true;
            this.labelAssets.Location = new System.Drawing.Point(543, 6);
            this.labelAssets.Name = "labelAssets";
            this.labelAssets.Size = new System.Drawing.Size(58, 20);
            this.labelAssets.TabIndex = 5;
            this.labelAssets.Text = "Assets";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(680, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormIsCourceWorkTen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePortfolio.ResumeLayout(false);
            this.tabPagePortfolio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageAdapters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePortfolio;
        private System.Windows.Forms.TabPage tabPageAdapters;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddAdapter;
        private System.Windows.Forms.Button buttonDelAdapter;
        internal System.Windows.Forms.CheckedListBox checkedListBoxAdapters;
        private System.Windows.Forms.Button buttonDoRequest;
        private System.Windows.Forms.Button buttonInitAll;
        private System.Windows.Forms.Button buttonCheckConnAll;
        private System.Windows.Forms.CheckedListBox checkedListBoxAssets;
        private System.Windows.Forms.Button buttonSetPass;
        private System.Windows.Forms.Label labelAssets;
        private System.Windows.Forms.Label labelAdapters;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

