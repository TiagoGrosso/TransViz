namespace TransViz {
				partial class DataVizPage {
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
												this.components = new System.ComponentModel.Container();
												System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
												System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
												System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
												System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
												System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
												this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
												this.PageTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.LeftFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
												this.ChooseFolder = new System.Windows.Forms.Button();
												this.TopMonthCalendar = new System.Windows.Forms.MonthCalendar();
												this.BottomMonthCalendar = new System.Windows.Forms.MonthCalendar();
												this.RightTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.TabControl = new System.Windows.Forms.TabControl();
												this.BarChartTab = new System.Windows.Forms.TabPage();
												this.BarChartTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.BarChartBottomFlow = new System.Windows.Forms.FlowLayoutPanel();
												this.EarlinessThresholdBarChart = new System.Windows.Forms.NumericUpDown();
												this.EarlinessThresholdBarChartLabel = new System.Windows.Forms.Label();
												this.LatenessThresholdBarChart = new System.Windows.Forms.NumericUpDown();
												this.LatenessThresholdBarChartLabel = new System.Windows.Forms.Label();
												this.CircularChartTab = new System.Windows.Forms.TabPage();
												this.CircularChartTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.RenderWindowCircularChart = new Kitware.VTK.RenderWindowControl();
												this.CircularChartCenterFlow = new System.Windows.Forms.FlowLayoutPanel();
												this.CircularChartBottomFlow = new System.Windows.Forms.FlowLayoutPanel();
												this.EarlinessThresholdCircularChart = new System.Windows.Forms.NumericUpDown();
												this.EarlinessThresholdCircularChartLabel = new System.Windows.Forms.Label();
												this.LatenessThresholdCircularChart = new System.Windows.Forms.NumericUpDown();
												this.LatenessThresholdCircularChartLabel = new System.Windows.Forms.Label();
												this.GPSPage = new System.Windows.Forms.TabPage();
												this.GPSPageTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.RenderWindowGPS = new Kitware.VTK.RenderWindowControl();
												this.ButtonControlsTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.PreviousFrame = new System.Windows.Forms.Button();
												this.PlayPause = new System.Windows.Forms.Button();
												this.NextFrame = new System.Windows.Forms.Button();
												this.StepLabel = new System.Windows.Forms.Label();
												this.TimeLabel = new System.Windows.Forms.Label();
												this.DateLabel = new System.Windows.Forms.Label();
												this.FilesFolder = new System.Windows.Forms.FolderBrowserDialog();
												this.FrameTimer = new System.Windows.Forms.Timer(this.components);
												this.IntervalSlider = new System.Windows.Forms.TrackBar();
												((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
												this.PageTableLayout.SuspendLayout();
												this.LeftFlowLayout.SuspendLayout();
												this.RightTableLayout.SuspendLayout();
												this.TabControl.SuspendLayout();
												this.BarChartTab.SuspendLayout();
												this.BarChartTableLayout.SuspendLayout();
												this.BarChartBottomFlow.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.EarlinessThresholdBarChart)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.LatenessThresholdBarChart)).BeginInit();
												this.CircularChartTab.SuspendLayout();
												this.CircularChartTableLayout.SuspendLayout();
												this.CircularChartBottomFlow.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.EarlinessThresholdCircularChart)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.LatenessThresholdCircularChart)).BeginInit();
												this.GPSPage.SuspendLayout();
												this.GPSPageTableLayout.SuspendLayout();
												this.ButtonControlsTableLayout.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.IntervalSlider)).BeginInit();
												this.SuspendLayout();
												// 
												// barChart
												// 
												chartArea4.Name = "ChartArea1";
												this.barChart.ChartAreas.Add(chartArea4);
												this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
												legend4.Name = "Legend1";
												this.barChart.Legends.Add(legend4);
												this.barChart.Location = new System.Drawing.Point(3, 3);
												this.barChart.Name = "barChart";
												series10.ChartArea = "ChartArea1";
												series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series10.Color = System.Drawing.Color.Blue;
												series10.IsXValueIndexed = true;
												series10.Legend = "Legend1";
												series10.Name = "On Time";
												series11.ChartArea = "ChartArea1";
												series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
												series11.Legend = "Legend1";
												series11.Name = "Late";
												series12.ChartArea = "ChartArea1";
												series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
												series12.Legend = "Legend1";
												series12.Name = "Early";
												this.barChart.Series.Add(series10);
												this.barChart.Series.Add(series11);
												this.barChart.Series.Add(series12);
												this.barChart.Size = new System.Drawing.Size(756, 393);
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
												// LeftFlowLayout
												// 
												this.LeftFlowLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.LeftFlowLayout.Controls.Add(this.ChooseFolder);
												this.LeftFlowLayout.Controls.Add(this.TopMonthCalendar);
												this.LeftFlowLayout.Controls.Add(this.BottomMonthCalendar);
												this.LeftFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
												this.LeftFlowLayout.Location = new System.Drawing.Point(3, 3);
												this.LeftFlowLayout.Name = "LeftFlowLayout";
												this.LeftFlowLayout.Size = new System.Drawing.Size(256, 537);
												this.LeftFlowLayout.TabIndex = 3;
												// 
												// ChooseFolder
												// 
												this.ChooseFolder.Dock = System.Windows.Forms.DockStyle.Top;
												this.ChooseFolder.Location = new System.Drawing.Point(3, 3);
												this.ChooseFolder.Name = "ChooseFolder";
												this.ChooseFolder.Size = new System.Drawing.Size(239, 114);
												this.ChooseFolder.TabIndex = 2;
												this.ChooseFolder.Text = "ChooseFolder";
												this.ChooseFolder.UseVisualStyleBackColor = true;
												this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
												// 
												// TopMonthCalendar
												// 
												this.TopMonthCalendar.Location = new System.Drawing.Point(9, 129);
												this.TopMonthCalendar.Name = "TopMonthCalendar";
												this.TopMonthCalendar.TabIndex = 0;
												// 
												// BottomMonthCalendar
												// 
												this.BottomMonthCalendar.Location = new System.Drawing.Point(9, 309);
												this.BottomMonthCalendar.Name = "BottomMonthCalendar";
												this.BottomMonthCalendar.TabIndex = 1;
												// 
												// RightTableLayout
												// 
												this.RightTableLayout.ColumnCount = 1;
												this.RightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
												this.RightTableLayout.Controls.Add(this.TabControl, 0, 0);
												this.RightTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.RightTableLayout.Location = new System.Drawing.Point(265, 3);
												this.RightTableLayout.Name = "RightTableLayout";
												this.RightTableLayout.RowCount = 2;
												this.RightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
												this.RightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
												this.RightTableLayout.Size = new System.Drawing.Size(782, 537);
												this.RightTableLayout.TabIndex = 2;
												// 
												// TabControl
												// 
												this.TabControl.Controls.Add(this.BarChartTab);
												this.TabControl.Controls.Add(this.CircularChartTab);
												this.TabControl.Controls.Add(this.GPSPage);
												this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
												this.TabControl.Location = new System.Drawing.Point(3, 3);
												this.TabControl.Name = "TabControl";
												this.RightTableLayout.SetRowSpan(this.TabControl, 2);
												this.TabControl.SelectedIndex = 0;
												this.TabControl.Size = new System.Drawing.Size(776, 531);
												this.TabControl.TabIndex = 5;
												this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
												// 
												// BarChartTab
												// 
												this.BarChartTab.Controls.Add(this.BarChartTableLayout);
												this.BarChartTab.Location = new System.Drawing.Point(4, 22);
												this.BarChartTab.Name = "BarChartTab";
												this.BarChartTab.Padding = new System.Windows.Forms.Padding(3);
												this.BarChartTab.Size = new System.Drawing.Size(768, 505);
												this.BarChartTab.TabIndex = 0;
												this.BarChartTab.Text = "Bar Chart (SA)";
												this.BarChartTab.UseVisualStyleBackColor = true;
												// 
												// BarChartTableLayout
												// 
												this.BarChartTableLayout.ColumnCount = 1;
												this.BarChartTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
												this.BarChartTableLayout.Controls.Add(this.barChart, 0, 0);
												this.BarChartTableLayout.Controls.Add(this.BarChartBottomFlow, 0, 1);
												this.BarChartTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.BarChartTableLayout.Location = new System.Drawing.Point(3, 3);
												this.BarChartTableLayout.Name = "BarChartTableLayout";
												this.BarChartTableLayout.RowCount = 2;
												this.BarChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
												this.BarChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
												this.BarChartTableLayout.Size = new System.Drawing.Size(762, 499);
												this.BarChartTableLayout.TabIndex = 1;
												// 
												// BarChartBottomFlow
												// 
												this.BarChartBottomFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.BarChartBottomFlow.AutoSize = true;
												this.BarChartBottomFlow.Controls.Add(this.EarlinessThresholdBarChart);
												this.BarChartBottomFlow.Controls.Add(this.EarlinessThresholdBarChartLabel);
												this.BarChartBottomFlow.Controls.Add(this.LatenessThresholdBarChart);
												this.BarChartBottomFlow.Controls.Add(this.LatenessThresholdBarChartLabel);
												this.BarChartBottomFlow.Location = new System.Drawing.Point(228, 402);
												this.BarChartBottomFlow.Name = "BarChartBottomFlow";
												this.BarChartBottomFlow.Size = new System.Drawing.Size(305, 26);
												this.BarChartBottomFlow.TabIndex = 1;
												this.BarChartBottomFlow.Visible = false;
												// 
												// EarlinessThresholdBarChart
												// 
												this.EarlinessThresholdBarChart.AutoSize = true;
												this.EarlinessThresholdBarChart.Location = new System.Drawing.Point(3, 3);
												this.EarlinessThresholdBarChart.Name = "EarlinessThresholdBarChart";
												this.EarlinessThresholdBarChart.Size = new System.Drawing.Size(41, 20);
												this.EarlinessThresholdBarChart.TabIndex = 0;
												this.EarlinessThresholdBarChart.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
												this.EarlinessThresholdBarChart.ValueChanged += new System.EventHandler(this.BarChartThresholdsChanged);
												// 
												// EarlinessThresholdBarChartLabel
												// 
												this.EarlinessThresholdBarChartLabel.Location = new System.Drawing.Point(50, 0);
												this.EarlinessThresholdBarChartLabel.Name = "EarlinessThresholdBarChartLabel";
												this.EarlinessThresholdBarChartLabel.Size = new System.Drawing.Size(99, 20);
												this.EarlinessThresholdBarChartLabel.TabIndex = 2;
												this.EarlinessThresholdBarChartLabel.Text = "Earliness Threshold";
												this.EarlinessThresholdBarChartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// LatenessThresholdBarChart
												// 
												this.LatenessThresholdBarChart.AutoSize = true;
												this.LatenessThresholdBarChart.Location = new System.Drawing.Point(155, 3);
												this.LatenessThresholdBarChart.Name = "LatenessThresholdBarChart";
												this.LatenessThresholdBarChart.Size = new System.Drawing.Size(41, 20);
												this.LatenessThresholdBarChart.TabIndex = 1;
												this.LatenessThresholdBarChart.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
												this.LatenessThresholdBarChart.ValueChanged += new System.EventHandler(this.BarChartThresholdsChanged);
												// 
												// LatenessThresholdBarChartLabel
												// 
												this.LatenessThresholdBarChartLabel.Location = new System.Drawing.Point(202, 0);
												this.LatenessThresholdBarChartLabel.Name = "LatenessThresholdBarChartLabel";
												this.LatenessThresholdBarChartLabel.Size = new System.Drawing.Size(100, 20);
												this.LatenessThresholdBarChartLabel.TabIndex = 3;
												this.LatenessThresholdBarChartLabel.Text = "Lateness Threshold";
												this.LatenessThresholdBarChartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// CircularChartTab
												// 
												this.CircularChartTab.Controls.Add(this.CircularChartTableLayout);
												this.CircularChartTab.Location = new System.Drawing.Point(4, 22);
												this.CircularChartTab.Name = "CircularChartTab";
												this.CircularChartTab.Padding = new System.Windows.Forms.Padding(3);
												this.CircularChartTab.Size = new System.Drawing.Size(768, 505);
												this.CircularChartTab.TabIndex = 1;
												this.CircularChartTab.Text = "Circular Chart (SA)";
												this.CircularChartTab.UseVisualStyleBackColor = true;
												// 
												// CircularChartTableLayout
												// 
												this.CircularChartTableLayout.ColumnCount = 1;
												this.CircularChartTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
												this.CircularChartTableLayout.Controls.Add(this.RenderWindowCircularChart, 0, 0);
												this.CircularChartTableLayout.Controls.Add(this.CircularChartCenterFlow, 0, 1);
												this.CircularChartTableLayout.Controls.Add(this.CircularChartBottomFlow, 0, 2);
												this.CircularChartTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.CircularChartTableLayout.Location = new System.Drawing.Point(3, 3);
												this.CircularChartTableLayout.Name = "CircularChartTableLayout";
												this.CircularChartTableLayout.RowCount = 3;
												this.CircularChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
												this.CircularChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
												this.CircularChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
												this.CircularChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
												this.CircularChartTableLayout.Size = new System.Drawing.Size(762, 499);
												this.CircularChartTableLayout.TabIndex = 7;
												// 
												// RenderWindowCircularChart
												// 
												this.RenderWindowCircularChart.AddTestActors = false;
												this.RenderWindowCircularChart.Dock = System.Windows.Forms.DockStyle.Fill;
												this.RenderWindowCircularChart.Location = new System.Drawing.Point(3, 3);
												this.RenderWindowCircularChart.Name = "RenderWindowCircularChart";
												this.RenderWindowCircularChart.Size = new System.Drawing.Size(756, 393);
												this.RenderWindowCircularChart.TabIndex = 6;
												this.RenderWindowCircularChart.TestText = null;
												// 
												// CircularChartCenterFlow
												// 
												this.CircularChartCenterFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.CircularChartCenterFlow.AutoSize = true;
												this.CircularChartCenterFlow.Location = new System.Drawing.Point(381, 402);
												this.CircularChartCenterFlow.Name = "CircularChartCenterFlow";
												this.CircularChartCenterFlow.Size = new System.Drawing.Size(0, 0);
												this.CircularChartCenterFlow.TabIndex = 8;
												// 
												// CircularChartBottomFlow
												// 
												this.CircularChartBottomFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.CircularChartBottomFlow.AutoSize = true;
												this.CircularChartBottomFlow.Controls.Add(this.EarlinessThresholdCircularChart);
												this.CircularChartBottomFlow.Controls.Add(this.EarlinessThresholdCircularChartLabel);
												this.CircularChartBottomFlow.Controls.Add(this.LatenessThresholdCircularChart);
												this.CircularChartBottomFlow.Controls.Add(this.LatenessThresholdCircularChartLabel);
												this.CircularChartBottomFlow.Location = new System.Drawing.Point(228, 461);
												this.CircularChartBottomFlow.Name = "CircularChartBottomFlow";
												this.CircularChartBottomFlow.Size = new System.Drawing.Size(305, 26);
												this.CircularChartBottomFlow.TabIndex = 7;
												this.CircularChartBottomFlow.Visible = false;
												// 
												// EarlinessThresholdCircularChart
												// 
												this.EarlinessThresholdCircularChart.AutoSize = true;
												this.EarlinessThresholdCircularChart.Location = new System.Drawing.Point(3, 3);
												this.EarlinessThresholdCircularChart.Name = "EarlinessThresholdCircularChart";
												this.EarlinessThresholdCircularChart.Size = new System.Drawing.Size(41, 20);
												this.EarlinessThresholdCircularChart.TabIndex = 0;
												this.EarlinessThresholdCircularChart.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
												this.EarlinessThresholdCircularChart.ValueChanged += new System.EventHandler(this.CircularChartThresholdsChanged);
												// 
												// EarlinessThresholdCircularChartLabel
												// 
												this.EarlinessThresholdCircularChartLabel.Location = new System.Drawing.Point(50, 0);
												this.EarlinessThresholdCircularChartLabel.Name = "EarlinessThresholdCircularChartLabel";
												this.EarlinessThresholdCircularChartLabel.Size = new System.Drawing.Size(99, 20);
												this.EarlinessThresholdCircularChartLabel.TabIndex = 2;
												this.EarlinessThresholdCircularChartLabel.Text = "Earliness Threshold";
												this.EarlinessThresholdCircularChartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// LatenessThresholdCircularChart
												// 
												this.LatenessThresholdCircularChart.AutoSize = true;
												this.LatenessThresholdCircularChart.Location = new System.Drawing.Point(155, 3);
												this.LatenessThresholdCircularChart.Name = "LatenessThresholdCircularChart";
												this.LatenessThresholdCircularChart.Size = new System.Drawing.Size(41, 20);
												this.LatenessThresholdCircularChart.TabIndex = 1;
												this.LatenessThresholdCircularChart.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
												this.LatenessThresholdCircularChart.ValueChanged += new System.EventHandler(this.CircularChartThresholdsChanged);
												// 
												// LatenessThresholdCircularChartLabel
												// 
												this.LatenessThresholdCircularChartLabel.Location = new System.Drawing.Point(202, 0);
												this.LatenessThresholdCircularChartLabel.Name = "LatenessThresholdCircularChartLabel";
												this.LatenessThresholdCircularChartLabel.Size = new System.Drawing.Size(100, 20);
												this.LatenessThresholdCircularChartLabel.TabIndex = 3;
												this.LatenessThresholdCircularChartLabel.Text = "Lateness Threshold";
												this.LatenessThresholdCircularChartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// GPSPage
												// 
												this.GPSPage.Controls.Add(this.GPSPageTableLayout);
												this.GPSPage.Location = new System.Drawing.Point(4, 22);
												this.GPSPage.Name = "GPSPage";
												this.GPSPage.Size = new System.Drawing.Size(768, 505);
												this.GPSPage.TabIndex = 2;
												this.GPSPage.Text = "GPS Chart (H)";
												this.GPSPage.UseVisualStyleBackColor = true;
												// 
												// GPSPageTableLayout
												// 
												this.GPSPageTableLayout.ColumnCount = 1;
												this.GPSPageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
												this.GPSPageTableLayout.Controls.Add(this.RenderWindowGPS, 0, 0);
												this.GPSPageTableLayout.Controls.Add(this.ButtonControlsTableLayout, 0, 1);
												this.GPSPageTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.GPSPageTableLayout.Location = new System.Drawing.Point(0, 0);
												this.GPSPageTableLayout.Name = "GPSPageTableLayout";
												this.GPSPageTableLayout.RowCount = 2;
												this.GPSPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
												this.GPSPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
												this.GPSPageTableLayout.Size = new System.Drawing.Size(768, 505);
												this.GPSPageTableLayout.TabIndex = 1;
												// 
												// RenderWindowGPS
												// 
												this.RenderWindowGPS.AddTestActors = false;
												this.RenderWindowGPS.Dock = System.Windows.Forms.DockStyle.Fill;
												this.RenderWindowGPS.Location = new System.Drawing.Point(3, 3);
												this.RenderWindowGPS.Name = "RenderWindowGPS";
												this.RenderWindowGPS.Size = new System.Drawing.Size(762, 372);
												this.RenderWindowGPS.TabIndex = 0;
												this.RenderWindowGPS.TestText = null;
												// 
												// ButtonControlsTableLayout
												// 
												this.ButtonControlsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
												this.ButtonControlsTableLayout.ColumnCount = 3;
												this.ButtonControlsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.Controls.Add(this.PreviousFrame, 0, 2);
												this.ButtonControlsTableLayout.Controls.Add(this.PlayPause, 1, 2);
												this.ButtonControlsTableLayout.Controls.Add(this.NextFrame, 2, 2);
												this.ButtonControlsTableLayout.Controls.Add(this.StepLabel, 1, 0);
												this.ButtonControlsTableLayout.Controls.Add(this.TimeLabel, 2, 0);
												this.ButtonControlsTableLayout.Controls.Add(this.DateLabel, 0, 0);
												this.ButtonControlsTableLayout.Controls.Add(this.IntervalSlider, 1, 1);
												this.ButtonControlsTableLayout.Location = new System.Drawing.Point(172, 381);
												this.ButtonControlsTableLayout.Name = "ButtonControlsTableLayout";
												this.ButtonControlsTableLayout.RowCount = 3;
												this.ButtonControlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
												this.ButtonControlsTableLayout.Size = new System.Drawing.Size(423, 121);
												this.ButtonControlsTableLayout.TabIndex = 1;
												// 
												// PreviousFrame
												// 
												this.PreviousFrame.Dock = System.Windows.Forms.DockStyle.Fill;
												this.PreviousFrame.Location = new System.Drawing.Point(3, 83);
												this.PreviousFrame.Name = "PreviousFrame";
												this.PreviousFrame.Size = new System.Drawing.Size(135, 35);
												this.PreviousFrame.TabIndex = 2;
												this.PreviousFrame.Text = "Prev";
												this.PreviousFrame.UseVisualStyleBackColor = true;
												this.PreviousFrame.Click += new System.EventHandler(this.PreviousFrame_Click);
												// 
												// PlayPause
												// 
												this.PlayPause.Dock = System.Windows.Forms.DockStyle.Fill;
												this.PlayPause.Location = new System.Drawing.Point(144, 83);
												this.PlayPause.Name = "PlayPause";
												this.PlayPause.Size = new System.Drawing.Size(135, 35);
												this.PlayPause.TabIndex = 3;
												this.PlayPause.Text = "Play";
												this.PlayPause.UseVisualStyleBackColor = true;
												this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
												// 
												// NextFrame
												// 
												this.NextFrame.Dock = System.Windows.Forms.DockStyle.Fill;
												this.NextFrame.Location = new System.Drawing.Point(285, 83);
												this.NextFrame.Name = "NextFrame";
												this.NextFrame.Size = new System.Drawing.Size(135, 35);
												this.NextFrame.TabIndex = 1;
												this.NextFrame.Text = "Next";
												this.NextFrame.UseVisualStyleBackColor = true;
												this.NextFrame.Click += new System.EventHandler(this.NextFrame_Click);
												// 
												// StepLabel
												// 
												this.StepLabel.AutoSize = true;
												this.StepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
												this.StepLabel.Location = new System.Drawing.Point(144, 0);
												this.StepLabel.Name = "StepLabel";
												this.StepLabel.Size = new System.Drawing.Size(135, 40);
												this.StepLabel.TabIndex = 4;
												this.StepLabel.Text = "Step";
												this.StepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// TimeLabel
												// 
												this.TimeLabel.AutoSize = true;
												this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
												this.TimeLabel.Location = new System.Drawing.Point(285, 0);
												this.TimeLabel.Name = "TimeLabel";
												this.TimeLabel.Size = new System.Drawing.Size(135, 40);
												this.TimeLabel.TabIndex = 5;
												this.TimeLabel.Text = "Time";
												this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// DateLabel
												// 
												this.DateLabel.AutoSize = true;
												this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
												this.DateLabel.Location = new System.Drawing.Point(3, 0);
												this.DateLabel.Name = "DateLabel";
												this.DateLabel.Size = new System.Drawing.Size(135, 40);
												this.DateLabel.TabIndex = 6;
												this.DateLabel.Text = "Date";
												this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// FrameTimer
												// 
												this.FrameTimer.Interval = 500;
												this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
												// 
												// IntervalSlider
												// 
												this.IntervalSlider.Dock = System.Windows.Forms.DockStyle.Fill;
												this.IntervalSlider.Location = new System.Drawing.Point(144, 43);
												this.IntervalSlider.Maximum = 2000;
												this.IntervalSlider.Minimum = 100;
												this.IntervalSlider.Name = "IntervalSlider";
												this.IntervalSlider.Size = new System.Drawing.Size(135, 34);
												this.IntervalSlider.TabIndex = 7;
												this.IntervalSlider.TickStyle = System.Windows.Forms.TickStyle.None;
												this.IntervalSlider.Value = 100;
												this.IntervalSlider.ValueChanged += new System.EventHandler(this.IntervalSlider_ValueChanged);
												// 
												// DataVizPage
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(1050, 543);
												this.Controls.Add(this.PageTableLayout);
												this.Name = "DataVizPage";
												this.Text = "TransViz";
												((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
												this.PageTableLayout.ResumeLayout(false);
												this.LeftFlowLayout.ResumeLayout(false);
												this.RightTableLayout.ResumeLayout(false);
												this.TabControl.ResumeLayout(false);
												this.BarChartTab.ResumeLayout(false);
												this.BarChartTableLayout.ResumeLayout(false);
												this.BarChartTableLayout.PerformLayout();
												this.BarChartBottomFlow.ResumeLayout(false);
												this.BarChartBottomFlow.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.EarlinessThresholdBarChart)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.LatenessThresholdBarChart)).EndInit();
												this.CircularChartTab.ResumeLayout(false);
												this.CircularChartTableLayout.ResumeLayout(false);
												this.CircularChartTableLayout.PerformLayout();
												this.CircularChartBottomFlow.ResumeLayout(false);
												this.CircularChartBottomFlow.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.EarlinessThresholdCircularChart)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.LatenessThresholdCircularChart)).EndInit();
												this.GPSPage.ResumeLayout(false);
												this.GPSPageTableLayout.ResumeLayout(false);
												this.ButtonControlsTableLayout.ResumeLayout(false);
												this.ButtonControlsTableLayout.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.IntervalSlider)).EndInit();
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
								private System.Windows.Forms.TableLayoutPanel PageTableLayout;
								private System.Windows.Forms.TableLayoutPanel RightTableLayout;
								private System.Windows.Forms.FolderBrowserDialog FilesFolder;
								private System.Windows.Forms.Button ChooseFolder;
								private System.Windows.Forms.FlowLayoutPanel LeftFlowLayout;
								private System.Windows.Forms.MonthCalendar TopMonthCalendar;
								private System.Windows.Forms.MonthCalendar BottomMonthCalendar;
								private System.Windows.Forms.TabControl TabControl;
								private System.Windows.Forms.TabPage BarChartTab;
								private System.Windows.Forms.TabPage CircularChartTab;
								private Kitware.VTK.RenderWindowControl RenderWindowCircularChart;
								private System.Windows.Forms.TableLayoutPanel BarChartTableLayout;
								private System.Windows.Forms.FlowLayoutPanel BarChartBottomFlow;
								private System.Windows.Forms.NumericUpDown EarlinessThresholdBarChart;
								private System.Windows.Forms.Label EarlinessThresholdBarChartLabel;
								private System.Windows.Forms.NumericUpDown LatenessThresholdBarChart;
								private System.Windows.Forms.Label LatenessThresholdBarChartLabel;
								private System.Windows.Forms.TableLayoutPanel CircularChartTableLayout;
								private System.Windows.Forms.FlowLayoutPanel CircularChartBottomFlow;
								private System.Windows.Forms.NumericUpDown EarlinessThresholdCircularChart;
								private System.Windows.Forms.Label EarlinessThresholdCircularChartLabel;
								private System.Windows.Forms.NumericUpDown LatenessThresholdCircularChart;
								private System.Windows.Forms.Label LatenessThresholdCircularChartLabel;
								private System.Windows.Forms.FlowLayoutPanel CircularChartCenterFlow;
								private System.Windows.Forms.TabPage GPSPage;
								private Kitware.VTK.RenderWindowControl RenderWindowGPS;
								private System.Windows.Forms.TableLayoutPanel GPSPageTableLayout;
								private System.Windows.Forms.Button NextFrame;
								private System.Windows.Forms.Timer FrameTimer;
								private System.Windows.Forms.TableLayoutPanel ButtonControlsTableLayout;
								private System.Windows.Forms.Button PreviousFrame;
								private System.Windows.Forms.Button PlayPause;
								private System.Windows.Forms.Label StepLabel;
								private System.Windows.Forms.Label TimeLabel;
								private System.Windows.Forms.Label DateLabel;
								private System.Windows.Forms.TrackBar IntervalSlider;
				}
}

