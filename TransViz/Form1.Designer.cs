namespace TransViz {
				partial class ChartPage {
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
												if (disposing && ( components != null )) {
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
												System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
												System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
												System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
												System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
												System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
												this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
												this.PageTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.RightTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.BottomRightFlow = new System.Windows.Forms.FlowLayoutPanel();
												this.EarlinessThreshold = new System.Windows.Forms.NumericUpDown();
												this.EarlinessLabel = new System.Windows.Forms.Label();
												this.LatenessThreshold = new System.Windows.Forms.NumericUpDown();
												this.LatenessLabel = new System.Windows.Forms.Label();
												this.ChooseFolder = new System.Windows.Forms.Button();
												this.FilesFolder = new System.Windows.Forms.FolderBrowserDialog();
												this.LeftFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
												this.TopMonthCalendar = new System.Windows.Forms.MonthCalendar();
												this.BottomMonthCalendar = new System.Windows.Forms.MonthCalendar();
												((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
												this.PageTableLayout.SuspendLayout();
												this.RightTableLayout.SuspendLayout();
												this.BottomRightFlow.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.EarlinessThreshold)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.LatenessThreshold)).BeginInit();
												this.LeftFlowLayout.SuspendLayout();
												this.SuspendLayout();
												// 
												// barChart
												// 
												chartArea1.Name = "ChartArea1";
												this.barChart.ChartAreas.Add(chartArea1);
												this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
												legend1.Name = "Legend1";
												this.barChart.Legends.Add(legend1);
												this.barChart.Location = new System.Drawing.Point(3, 88);
												this.barChart.Name = "barChart";
												series1.ChartArea = "ChartArea1";
												series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series1.Color = System.Drawing.Color.Blue;
												series1.IsXValueIndexed = true;
												series1.Legend = "Legend1";
												series1.Name = "On Time";
												series2.ChartArea = "ChartArea1";
												series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
												series2.Legend = "Legend1";
												series2.Name = "Late";
												series3.ChartArea = "ChartArea1";
												series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
												series3.Legend = "Legend1";
												series3.Name = "Early";
												this.barChart.Series.Add(series1);
												this.barChart.Series.Add(series2);
												this.barChart.Series.Add(series3);
												this.barChart.Size = new System.Drawing.Size(776, 337);
												this.barChart.TabIndex = 0;
												this.barChart.Text = "chart1";
												// 
												// PageTableLayout
												// 
												this.PageTableLayout.ColumnCount = 2;
												this.PageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
												this.PageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
												this.PageTableLayout.Controls.Add(this.LeftFlowLayout, 0, 0);
												this.PageTableLayout.Controls.Add(this.RightTableLayout, 1, 0);
												this.PageTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.PageTableLayout.Location = new System.Drawing.Point(0, 0);
												this.PageTableLayout.Name = "PageTableLayout";
												this.PageTableLayout.RowCount = 1;
												this.PageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
												this.PageTableLayout.Size = new System.Drawing.Size(1050, 543);
												this.PageTableLayout.TabIndex = 4;
												// 
												// RightTableLayout
												// 
												this.RightTableLayout.ColumnCount = 1;
												this.RightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
												this.RightTableLayout.Controls.Add(this.barChart, 0, 1);
												this.RightTableLayout.Controls.Add(this.BottomRightFlow, 0, 2);
												this.RightTableLayout.Controls.Add(this.ChooseFolder, 0, 0);
												this.RightTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.RightTableLayout.Location = new System.Drawing.Point(265, 3);
												this.RightTableLayout.Name = "RightTableLayout";
												this.RightTableLayout.RowCount = 3;
												this.RightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
												this.RightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
												this.RightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
												this.RightTableLayout.Size = new System.Drawing.Size(782, 537);
												this.RightTableLayout.TabIndex = 2;
												// 
												// BottomRightFlow
												// 
												this.BottomRightFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
												this.BottomRightFlow.AutoSize = true;
												this.BottomRightFlow.Controls.Add(this.EarlinessThreshold);
												this.BottomRightFlow.Controls.Add(this.EarlinessLabel);
												this.BottomRightFlow.Controls.Add(this.LatenessThreshold);
												this.BottomRightFlow.Controls.Add(this.LatenessLabel);
												this.BottomRightFlow.Location = new System.Drawing.Point(244, 438);
												this.BottomRightFlow.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
												this.BottomRightFlow.Name = "BottomRightFlow";
												this.BottomRightFlow.Size = new System.Drawing.Size(293, 96);
												this.BottomRightFlow.TabIndex = 1;
												// 
												// EarlinessThreshold
												// 
												this.EarlinessThreshold.AutoSize = true;
												this.EarlinessThreshold.Location = new System.Drawing.Point(3, 3);
												this.EarlinessThreshold.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
												this.EarlinessThreshold.Name = "EarlinessThreshold";
												this.EarlinessThreshold.Size = new System.Drawing.Size(35, 20);
												this.EarlinessThreshold.TabIndex = 5;
												this.EarlinessThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
												this.EarlinessThreshold.ValueChanged += new System.EventHandler(this.ThresholdsChanged);
												// 
												// EarlinessLabel
												// 
												this.EarlinessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
												this.EarlinessLabel.AutoSize = true;
												this.EarlinessLabel.Location = new System.Drawing.Point(44, 0);
												this.EarlinessLabel.Name = "EarlinessLabel";
												this.EarlinessLabel.Size = new System.Drawing.Size(99, 26);
												this.EarlinessLabel.TabIndex = 7;
												this.EarlinessLabel.Text = "Earliness Threshold";
												this.EarlinessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// LatenessThreshold
												// 
												this.LatenessThreshold.AutoSize = true;
												this.LatenessThreshold.Location = new System.Drawing.Point(149, 3);
												this.LatenessThreshold.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
												this.LatenessThreshold.Name = "LatenessThreshold";
												this.LatenessThreshold.Size = new System.Drawing.Size(35, 20);
												this.LatenessThreshold.TabIndex = 6;
												this.LatenessThreshold.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
												this.LatenessThreshold.ValueChanged += new System.EventHandler(this.ThresholdsChanged);
												// 
												// LatenessLabel
												// 
												this.LatenessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
												this.LatenessLabel.AutoSize = true;
												this.LatenessLabel.Location = new System.Drawing.Point(190, 0);
												this.LatenessLabel.Name = "LatenessLabel";
												this.LatenessLabel.Size = new System.Drawing.Size(100, 26);
												this.LatenessLabel.TabIndex = 8;
												this.LatenessLabel.Text = "Lateness Threshold";
												this.LatenessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// ChooseFolder
												// 
												this.ChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
												this.ChooseFolder.AutoSize = true;
												this.ChooseFolder.Location = new System.Drawing.Point(3, 3);
												this.ChooseFolder.Name = "ChooseFolder";
												this.ChooseFolder.Size = new System.Drawing.Size(776, 79);
												this.ChooseFolder.TabIndex = 2;
												this.ChooseFolder.Text = "ChooseFolder";
												this.ChooseFolder.UseVisualStyleBackColor = true;
												this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
												// 
												// LeftFlowLayout
												// 
												this.LeftFlowLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.LeftFlowLayout.Controls.Add(this.TopMonthCalendar);
												this.LeftFlowLayout.Controls.Add(this.BottomMonthCalendar);
												this.LeftFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
												this.LeftFlowLayout.Location = new System.Drawing.Point(3, 3);
												this.LeftFlowLayout.Name = "LeftFlowLayout";
												this.LeftFlowLayout.Size = new System.Drawing.Size(256, 537);
												this.LeftFlowLayout.TabIndex = 3;
												// 
												// TopMonthCalendar
												// 
												this.TopMonthCalendar.Location = new System.Drawing.Point(9, 90);
												this.TopMonthCalendar.Margin = new System.Windows.Forms.Padding(9, 90, 9, 9);
												this.TopMonthCalendar.Name = "TopMonthCalendar";
												this.TopMonthCalendar.TabIndex = 0;
												// 
												// BottomMonthCalendar
												// 
												this.BottomMonthCalendar.Location = new System.Drawing.Point(9, 270);
												this.BottomMonthCalendar.Name = "BottomMonthCalendar";
												this.BottomMonthCalendar.TabIndex = 1;
												// 
												// ChartPage
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(1050, 543);
												this.Controls.Add(this.PageTableLayout);
												this.Name = "ChartPage";
												this.Text = "TransViz";
												((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
												this.PageTableLayout.ResumeLayout(false);
												this.RightTableLayout.ResumeLayout(false);
												this.RightTableLayout.PerformLayout();
												this.BottomRightFlow.ResumeLayout(false);
												this.BottomRightFlow.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.EarlinessThreshold)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.LatenessThreshold)).EndInit();
												this.LeftFlowLayout.ResumeLayout(false);
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
								private System.Windows.Forms.TableLayoutPanel PageTableLayout;
								private System.Windows.Forms.TableLayoutPanel RightTableLayout;
								private System.Windows.Forms.FlowLayoutPanel BottomRightFlow;
								private System.Windows.Forms.NumericUpDown EarlinessThreshold;
								private System.Windows.Forms.Label EarlinessLabel;
								private System.Windows.Forms.NumericUpDown LatenessThreshold;
								private System.Windows.Forms.Label LatenessLabel;
								private System.Windows.Forms.FolderBrowserDialog FilesFolder;
								private System.Windows.Forms.Button ChooseFolder;
								private System.Windows.Forms.FlowLayoutPanel LeftFlowLayout;
								private System.Windows.Forms.MonthCalendar TopMonthCalendar;
								private System.Windows.Forms.MonthCalendar BottomMonthCalendar;
				}
}

