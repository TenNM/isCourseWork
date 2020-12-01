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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePortfolio = new System.Windows.Forms.TabPage();
            this.buttonCallAllServers = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.labelAssets = new System.Windows.Forms.Label();
            this.labelAdapters = new System.Windows.Forms.Label();
            this.checkedListBoxAssets = new System.Windows.Forms.CheckedListBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.checkedListBoxAdapters = new System.Windows.Forms.CheckedListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageAdapters = new System.Windows.Forms.TabPage();
            this.buttonSetPassAndName = new System.Windows.Forms.Button();
            this.buttonCheckConnAll = new System.Windows.Forms.Button();
            this.buttonInitAll = new System.Windows.Forms.Button();
            this.buttonDelAdapter = new System.Windows.Forms.Button();
            this.buttonAddAdapter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassSetted = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
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
            this.tabPagePortfolio.Controls.Add(this.buttonCallAllServers);
            this.tabPagePortfolio.Controls.Add(this.comboBoxFilter);
            this.tabPagePortfolio.Controls.Add(this.labelAssets);
            this.tabPagePortfolio.Controls.Add(this.labelAdapters);
            this.tabPagePortfolio.Controls.Add(this.checkedListBoxAssets);
            this.tabPagePortfolio.Controls.Add(this.buttonFilter);
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
            // buttonCallAllServers
            // 
            this.buttonCallAllServers.Location = new System.Drawing.Point(673, 167);
            this.buttonCallAllServers.Name = "buttonCallAllServers";
            this.buttonCallAllServers.Size = new System.Drawing.Size(100, 100);
            this.buttonCallAllServers.TabIndex = 7;
            this.buttonCallAllServers.Text = "Call to all servers";
            this.buttonCallAllServers.UseVisualStyleBackColor = true;
            this.buttonCallAllServers.Click += new System.EventHandler(this.buttonCallAllServers_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(673, 29);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(100, 28);
            this.comboBoxFilter.TabIndex = 6;
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
            // labelAdapters
            // 
            this.labelAdapters.AutoSize = true;
            this.labelAdapters.Location = new System.Drawing.Point(417, 6);
            this.labelAdapters.Name = "labelAdapters";
            this.labelAdapters.Size = new System.Drawing.Size(74, 20);
            this.labelAdapters.TabIndex = 4;
            this.labelAdapters.Text = "Adapters";
            // 
            // checkedListBoxAssets
            // 
            this.checkedListBoxAssets.FormattingEnabled = true;
            this.checkedListBoxAssets.Location = new System.Drawing.Point(547, 29);
            this.checkedListBoxAssets.Name = "checkedListBoxAssets";
            this.checkedListBoxAssets.Size = new System.Drawing.Size(120, 349);
            this.checkedListBoxAssets.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(673, 273);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(100, 100);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(400, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPageAdapters
            // 
            this.tabPageAdapters.Controls.Add(this.buttonSetPassAndName);
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
            // buttonSetPassAndName
            // 
            this.buttonSetPassAndName.Location = new System.Drawing.Point(578, 6);
            this.buttonSetPassAndName.Name = "buttonSetPassAndName";
            this.buttonSetPassAndName.Size = new System.Drawing.Size(100, 100);
            this.buttonSetPassAndName.TabIndex = 5;
            this.buttonSetPassAndName.Text = "Set Pass and Name";
            this.buttonSetPassAndName.UseVisualStyleBackColor = true;
            this.buttonSetPassAndName.Click += new System.EventHandler(this.buttonSetPassAndName_Click);
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(142, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "labelName";
            // 
            // labelPassSetted
            // 
            this.labelPassSetted.AutoSize = true;
            this.labelPassSetted.Location = new System.Drawing.Point(314, 9);
            this.labelPassSetted.Name = "labelPassSetted";
            this.labelPassSetted.Size = new System.Drawing.Size(116, 20);
            this.labelPassSetted.TabIndex = 3;
            this.labelPassSetted.Text = "labelPassState";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPassSetted);
            this.Controls.Add(this.labelName);
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
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonInitAll;
        private System.Windows.Forms.Button buttonCheckConnAll;
        private System.Windows.Forms.CheckedListBox checkedListBoxAssets;
        private System.Windows.Forms.Button buttonSetPassAndName;
        private System.Windows.Forms.Label labelAssets;
        private System.Windows.Forms.Label labelAdapters;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        internal System.Windows.Forms.Label labelName;
        internal System.Windows.Forms.Label labelPassSetted;
        private System.Windows.Forms.Button buttonCallAllServers;
    }
}

