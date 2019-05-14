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
												System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
												System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
												System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
												System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
												System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
												this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
												this.PageTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.LeftFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
												this.ChooseFolder = new System.Windows.Forms.Button();
												this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
												this.StartTime = new System.Windows.Forms.DateTimePicker();
												this.NumDaysSelector = new System.Windows.Forms.NumericUpDown();
												this.RightTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.TabControl = new System.Windows.Forms.TabControl();
												this.BarChartTab = new System.Windows.Forms.TabPage();
												this.BarChartTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.BarChartBottomFlow = new System.Windows.Forms.FlowLayoutPanel();
												this.EarlinessThresholdBarChart = new System.Windows.Forms.NumericUpDown();
												this.EarlinessThresholdBarChartLabel = new System.Windows.Forms.Label();
												this.LatenessThresholdBarChart = new System.Windows.Forms.NumericUpDown();
												this.LatenessThresholdBarChartLabel = new System.Windows.Forms.Label();
												this.BarChartStopList = new System.Windows.Forms.CheckedListBox();
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
												this.GPSPageBottomTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.GPSPageRadioButtonFlow = new System.Windows.Forms.FlowLayoutPanel();
												this.ButtonControlsTableLayout = new System.Windows.Forms.TableLayoutPanel();
												this.DateLabel = new System.Windows.Forms.Label();
												this.PreviousFrame = new System.Windows.Forms.Button();
												this.PlayPause = new System.Windows.Forms.Button();
												this.NextFrame = new System.Windows.Forms.Button();
												this.StepLabel = new System.Windows.Forms.Label();
												this.IntervalSlider = new System.Windows.Forms.TrackBar();
												this.RenderWindowGPS = new Kitware.VTK.RenderWindowControl();
												this.FilesFolder = new System.Windows.Forms.FolderBrowserDialog();
												this.FrameTimer = new System.Windows.Forms.Timer(this.components);
												this.ChartToolTip = new System.Windows.Forms.ToolTip(this.components);
												this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
												this.MapPage = new System.Windows.Forms.TabPage();
												this.MapRenderWindow = new Kitware.VTK.RenderWindowControl();
												((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
												this.PageTableLayout.SuspendLayout();
												this.LeftFlowLayout.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.NumDaysSelector)).BeginInit();
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
												this.GPSPageBottomTableLayout.SuspendLayout();
												this.ButtonControlsTableLayout.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.IntervalSlider)).BeginInit();
												this.MapPage.SuspendLayout();
												this.SuspendLayout();
												// 
												// barChart
												// 
												chartArea1.Name = "ChartArea1";
												this.barChart.ChartAreas.Add(chartArea1);
												this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
												legend1.Name = "Legend1";
												this.barChart.Legends.Add(legend1);
												this.barChart.Location = new System.Drawing.Point(3, 3);
												this.barChart.Name = "barChart";
												series1.ChartArea = "ChartArea1";
												series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series1.Color = System.Drawing.Color.Blue;
												series1.IsXValueIndexed = true;
												series1.Legend = "Legend1";
												series1.Name = "On Time";
												series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
												series2.ChartArea = "ChartArea1";
												series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
												series2.Legend = "Legend1";
												series2.Name = "Late";
												series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
												series3.ChartArea = "ChartArea1";
												series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
												series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
												series3.Legend = "Legend1";
												series3.Name = "Early";
												series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
												this.barChart.Series.Add(series1);
												this.barChart.Series.Add(series2);
												this.barChart.Series.Add(series3);
												this.barChart.Size = new System.Drawing.Size(756, 393);
												this.barChart.TabIndex = 0;
												this.barChart.Text = "Schedule Adherence";
												this.barChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarChart_MouseMove);
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
												this.LeftFlowLayout.Controls.Add(this.MonthCalendar);
												this.LeftFlowLayout.Controls.Add(this.StartTime);
												this.LeftFlowLayout.Controls.Add(this.NumDaysSelector);
												this.LeftFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
												this.LeftFlowLayout.Location = new System.Drawing.Point(3, 3);
												this.LeftFlowLayout.Name = "LeftFlowLayout";
												this.LeftFlowLayout.Size = new System.Drawing.Size(256, 536);
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
												// MonthCalendar
												// 
												this.MonthCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.MonthCalendar.Location = new System.Drawing.Point(9, 129);
												this.MonthCalendar.Name = "MonthCalendar";
												this.MonthCalendar.ShowToday = false;
												this.MonthCalendar.ShowTodayCircle = false;
												this.MonthCalendar.TabIndex = 0;
												this.MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
												// 
												// StartTime
												// 
												this.StartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.StartTime.Checked = false;
												this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
												this.StartTime.Location = new System.Drawing.Point(89, 303);
												this.StartTime.Name = "StartTime";
												this.StartTime.ShowUpDown = true;
												this.StartTime.Size = new System.Drawing.Size(67, 20);
												this.StartTime.TabIndex = 3;
												this.StartTime.Value = new System.DateTime(2019, 1, 9, 16, 0, 0, 0);
												this.StartTime.ValueChanged += new System.EventHandler(this.StartTime_ValueChanged);
												// 
												// NumDaysSelector
												// 
												this.NumDaysSelector.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.NumDaysSelector.Location = new System.Drawing.Point(87, 329);
												this.NumDaysSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
												this.NumDaysSelector.Name = "NumDaysSelector";
												this.NumDaysSelector.Size = new System.Drawing.Size(70, 20);
												this.NumDaysSelector.TabIndex = 4;
												this.NumDaysSelector.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
												this.NumDaysSelector.ValueChanged += new System.EventHandler(this.NumDaysSelector_ValueChanged);
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
												this.TabControl.Controls.Add(this.MapPage);
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
												this.BarChartTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
												this.BarChartTableLayout.Controls.Add(this.BarChartStopList, 0, 2);
												this.BarChartTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.BarChartTableLayout.Location = new System.Drawing.Point(3, 3);
												this.BarChartTableLayout.Name = "BarChartTableLayout";
												this.BarChartTableLayout.RowCount = 3;
												this.BarChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
												this.BarChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
												this.BarChartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
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
												// BarChartStopList
												// 
												this.BarChartStopList.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.BarChartStopList.CheckOnClick = true;
												this.BarChartStopList.FormattingEnabled = true;
												this.BarChartStopList.Location = new System.Drawing.Point(136, 451);
												this.BarChartStopList.MultiColumn = true;
												this.BarChartStopList.Name = "BarChartStopList";
												this.BarChartStopList.Size = new System.Drawing.Size(490, 19);
												this.BarChartStopList.TabIndex = 0;
												this.BarChartStopList.ThreeDCheckBoxes = true;
												this.BarChartStopList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.BarChartStopList_ItemCheck);
												// 
												// CircularChartTab
												// 
												this.CircularChartTab.Controls.Add(this.CircularChartTableLayout);
												this.CircularChartTab.Location = new System.Drawing.Point(4, 22);
												this.CircularChartTab.Name = "CircularChartTab";
												this.CircularChartTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
												this.RenderWindowCircularChart.Location = new System.Drawing.Point(4, 5);
												this.RenderWindowCircularChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
												this.RenderWindowCircularChart.Name = "RenderWindowCircularChart";
												this.RenderWindowCircularChart.Size = new System.Drawing.Size(754, 389);
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
												this.GPSPageTableLayout.Controls.Add(this.GPSPageBottomTableLayout, 0, 1);
												this.GPSPageTableLayout.Controls.Add(this.RenderWindowGPS, 0, 0);
												this.GPSPageTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.GPSPageTableLayout.Location = new System.Drawing.Point(0, 0);
												this.GPSPageTableLayout.Name = "GPSPageTableLayout";
												this.GPSPageTableLayout.RowCount = 2;
												this.GPSPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
												this.GPSPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
												this.GPSPageTableLayout.Size = new System.Drawing.Size(768, 505);
												this.GPSPageTableLayout.TabIndex = 1;
												// 
												// GPSPageBottomTableLayout
												// 
												this.GPSPageBottomTableLayout.ColumnCount = 1;
												this.GPSPageBottomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
												this.GPSPageBottomTableLayout.Controls.Add(this.GPSPageRadioButtonFlow, 0, 0);
												this.GPSPageBottomTableLayout.Controls.Add(this.ButtonControlsTableLayout, 0, 1);
												this.GPSPageBottomTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.GPSPageBottomTableLayout.Location = new System.Drawing.Point(3, 381);
												this.GPSPageBottomTableLayout.Name = "GPSPageBottomTableLayout";
												this.GPSPageBottomTableLayout.RowCount = 2;
												this.GPSPageBottomTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
												this.GPSPageBottomTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
												this.GPSPageBottomTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
												this.GPSPageBottomTableLayout.Size = new System.Drawing.Size(762, 121);
												this.GPSPageBottomTableLayout.TabIndex = 2;
												// 
												// GPSPageRadioButtonFlow
												// 
												this.GPSPageRadioButtonFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
												this.GPSPageRadioButtonFlow.AutoSize = true;
												this.GPSPageRadioButtonFlow.Location = new System.Drawing.Point(381, 3);
												this.GPSPageRadioButtonFlow.Name = "GPSPageRadioButtonFlow";
												this.GPSPageRadioButtonFlow.Size = new System.Drawing.Size(0, 0);
												this.GPSPageRadioButtonFlow.TabIndex = 2;
												// 
												// ButtonControlsTableLayout
												// 
												this.ButtonControlsTableLayout.ColumnCount = 3;
												this.ButtonControlsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
												this.ButtonControlsTableLayout.Controls.Add(this.DateLabel, 0, 0);
												this.ButtonControlsTableLayout.Controls.Add(this.PreviousFrame, 0, 1);
												this.ButtonControlsTableLayout.Controls.Add(this.PlayPause, 1, 1);
												this.ButtonControlsTableLayout.Controls.Add(this.NextFrame, 2, 1);
												this.ButtonControlsTableLayout.Controls.Add(this.StepLabel, 1, 0);
												this.ButtonControlsTableLayout.Controls.Add(this.IntervalSlider, 2, 0);
												this.ButtonControlsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
												this.ButtonControlsTableLayout.Location = new System.Drawing.Point(3, 33);
												this.ButtonControlsTableLayout.Name = "ButtonControlsTableLayout";
												this.ButtonControlsTableLayout.RowCount = 2;
												this.ButtonControlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
												this.ButtonControlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
												this.ButtonControlsTableLayout.Size = new System.Drawing.Size(756, 85);
												this.ButtonControlsTableLayout.TabIndex = 1;
												// 
												// DateLabel
												// 
												this.DateLabel.AutoSize = true;
												this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
												this.DateLabel.Location = new System.Drawing.Point(3, 0);
												this.DateLabel.Name = "DateLabel";
												this.DateLabel.Size = new System.Drawing.Size(246, 42);
												this.DateLabel.TabIndex = 6;
												this.DateLabel.Text = "Date";
												this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// PreviousFrame
												// 
												this.PreviousFrame.Dock = System.Windows.Forms.DockStyle.Fill;
												this.PreviousFrame.Location = new System.Drawing.Point(3, 45);
												this.PreviousFrame.Name = "PreviousFrame";
												this.PreviousFrame.Size = new System.Drawing.Size(246, 37);
												this.PreviousFrame.TabIndex = 2;
												this.PreviousFrame.Text = "Prev";
												this.PreviousFrame.UseVisualStyleBackColor = true;
												this.PreviousFrame.Click += new System.EventHandler(this.PreviousFrame_Click);
												// 
												// PlayPause
												// 
												this.PlayPause.Dock = System.Windows.Forms.DockStyle.Fill;
												this.PlayPause.Location = new System.Drawing.Point(255, 45);
												this.PlayPause.Name = "PlayPause";
												this.PlayPause.Size = new System.Drawing.Size(246, 37);
												this.PlayPause.TabIndex = 3;
												this.PlayPause.Text = "Play";
												this.PlayPause.UseVisualStyleBackColor = true;
												this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
												// 
												// NextFrame
												// 
												this.NextFrame.Dock = System.Windows.Forms.DockStyle.Fill;
												this.NextFrame.Location = new System.Drawing.Point(507, 45);
												this.NextFrame.Name = "NextFrame";
												this.NextFrame.Size = new System.Drawing.Size(246, 37);
												this.NextFrame.TabIndex = 1;
												this.NextFrame.Text = "Next";
												this.NextFrame.UseVisualStyleBackColor = true;
												this.NextFrame.Click += new System.EventHandler(this.NextFrame_Click);
												// 
												// StepLabel
												// 
												this.StepLabel.AutoSize = true;
												this.StepLabel.Dock = System.Windows.Forms.DockStyle.Right;
												this.StepLabel.Location = new System.Drawing.Point(472, 0);
												this.StepLabel.Name = "StepLabel";
												this.StepLabel.Size = new System.Drawing.Size(29, 42);
												this.StepLabel.TabIndex = 4;
												this.StepLabel.Text = "Step";
												this.StepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
												// 
												// IntervalSlider
												// 
												this.IntervalSlider.Dock = System.Windows.Forms.DockStyle.Fill;
												this.IntervalSlider.Location = new System.Drawing.Point(507, 3);
												this.IntervalSlider.Maximum = 2000;
												this.IntervalSlider.Minimum = 100;
												this.IntervalSlider.Name = "IntervalSlider";
												this.IntervalSlider.Size = new System.Drawing.Size(246, 36);
												this.IntervalSlider.TabIndex = 7;
												this.IntervalSlider.TickStyle = System.Windows.Forms.TickStyle.None;
												this.IntervalSlider.Value = 100;
												this.IntervalSlider.ValueChanged += new System.EventHandler(this.IntervalSlider_ValueChanged);
												// 
												// RenderWindowGPS
												// 
												this.RenderWindowGPS.AddTestActors = false;
												this.RenderWindowGPS.Dock = System.Windows.Forms.DockStyle.Fill;
												this.RenderWindowGPS.Location = new System.Drawing.Point(4, 5);
												this.RenderWindowGPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
												this.RenderWindowGPS.Name = "RenderWindowGPS";
												this.RenderWindowGPS.Size = new System.Drawing.Size(760, 368);
												this.RenderWindowGPS.TabIndex = 0;
												this.RenderWindowGPS.TestText = null;
												// 
												// FrameTimer
												// 
												this.FrameTimer.Interval = 500;
												this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
												// 
												// entityCommand1
												// 
												this.entityCommand1.CommandTimeout = 0;
												this.entityCommand1.CommandTree = null;
												this.entityCommand1.Connection = null;
												this.entityCommand1.EnablePlanCaching = true;
												this.entityCommand1.Transaction = null;
												// 
												// MapPage
												// 
												this.MapPage.Controls.Add(this.MapRenderWindow);
												this.MapPage.Location = new System.Drawing.Point(4, 22);
												this.MapPage.Name = "MapPage";
												this.MapPage.Size = new System.Drawing.Size(768, 505);
												this.MapPage.TabIndex = 3;
												this.MapPage.Text = "Map Page";
												this.MapPage.UseVisualStyleBackColor = true;
												// 
												// MapRenderWindow
												// 
												this.MapRenderWindow.AddTestActors = false;
												this.MapRenderWindow.Dock = System.Windows.Forms.DockStyle.Fill;
												this.MapRenderWindow.Location = new System.Drawing.Point(0, 0);
												this.MapRenderWindow.Name = "MapRenderWindow";
												this.MapRenderWindow.Size = new System.Drawing.Size(768, 505);
												this.MapRenderWindow.TabIndex = 0;
												this.MapRenderWindow.TestText = null;
												// 
												// DataVizPage
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.AutoSize = true;
												this.ClientSize = new System.Drawing.Size(1050, 543);
												this.Controls.Add(this.PageTableLayout);
												this.Name = "DataVizPage";
												this.Text = "TransViz";
												((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
												this.PageTableLayout.ResumeLayout(false);
												this.LeftFlowLayout.ResumeLayout(false);
												((System.ComponentModel.ISupportInitialize)(this.NumDaysSelector)).EndInit();
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
												this.GPSPageBottomTableLayout.ResumeLayout(false);
												this.GPSPageBottomTableLayout.PerformLayout();
												this.ButtonControlsTableLayout.ResumeLayout(false);
												this.ButtonControlsTableLayout.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.IntervalSlider)).EndInit();
												this.MapPage.ResumeLayout(false);
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
								private System.Windows.Forms.TableLayoutPanel PageTableLayout;
								private System.Windows.Forms.TableLayoutPanel RightTableLayout;
								private System.Windows.Forms.FolderBrowserDialog FilesFolder;
								private System.Windows.Forms.Button ChooseFolder;
								private System.Windows.Forms.FlowLayoutPanel LeftFlowLayout;
								private System.Windows.Forms.MonthCalendar MonthCalendar;
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
								private System.Windows.Forms.TrackBar IntervalSlider;
								private System.Windows.Forms.TableLayoutPanel GPSPageBottomTableLayout;
								private System.Windows.Forms.Label DateLabel;
								private System.Windows.Forms.FlowLayoutPanel GPSPageRadioButtonFlow;
								private System.Windows.Forms.CheckedListBox BarChartStopList;
								private System.Windows.Forms.DateTimePicker StartTime;
								private System.Windows.Forms.ToolTip ChartToolTip;
								private System.Windows.Forms.NumericUpDown NumDaysSelector;
								private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
								private System.Windows.Forms.TabPage MapPage;
								private Kitware.VTK.RenderWindowControl MapRenderWindow;
				}
}

