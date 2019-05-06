﻿using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TransViz.Objects;

namespace TransViz {
				public partial class DataVizPage : Form {


								// TODO
								// Ordenar paragens
								// Viz geografica (manhatan)
								// Alterar GPSChart com delta vertical
								// Passar para fase de testes
												// 20 de Maio
												// Testar o Guiao primeiro



								string folderPath;


								private List<string> lineNames = new List<string>()
								{   "Red",
												"747",
												"1",
												"Green-B",
												"Green-C",
												"Green-D",
												"Green-E"
								};
								private Dictionary<string, Line> lines = new Dictionary<string, Line>();

								public DataVizPage()
								{
												this.InitializeComponent();

												this.barChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0} %";
												this.barChart.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
												//InitializeMap();


												this.MonthCalendar.SelectionStart = new DateTime(2019, 1, 9);
												this.startDate = this.MonthCalendar.SelectionStart;

												this.DrawTab();
								}

								private void AddBoldedDates()
								{
												List<DateTime> boldedDates = new List<DateTime>();

												DateTime current = new DateTime(2019, 1, 9);
												DateTime end = new DateTime(2019, 1, 24);

												while (current <= end) {
																Console.WriteLine(current);
																if (this.CheckDateForProblems(current))
																				boldedDates.Add(current);

																current = current.AddDays(1);
												}


												this.MonthCalendar.BoldedDates = boldedDates.ToArray();
								}

								private bool CheckDateForProblems(DateTime date)
								{
												foreach (Line line in this.lines.Values) {
																if (this.CheckLineForProblems(line, date))
																				return true;
												}

												return false;
								}

								private bool CheckLineForProblems(Line line, DateTime date)
								{
												int earlyArrivals = 0;
												int onTimeArrivals = 0;
												int lateArrivals = 0;

												foreach (Arrival arrival in line.Arrivals
																												.GetViewBetween(new Arrival(date, date),
																												new Arrival(date.AddDays(1), date.AddDays(1)))) {


																int onTime = arrival.OnTime(3, 5);

																if (onTime == Constants.ARRIVED_EARLY)
																				++earlyArrivals;
																else if (onTime == Constants.ARRIVED_ONTIME)
																				++onTimeArrivals;
																else
																				++lateArrivals;
												}

												int totalArrivals = earlyArrivals + onTimeArrivals + lateArrivals;

												Console.WriteLine((float) onTimeArrivals / (float) totalArrivals);

												if ((float) onTimeArrivals / (float) totalArrivals < 0.40f)
																return true;
												return false;
								}

								//private void InitializeMap()
								//{
								//				try
								//				{
								//								System.Net.IPHostEntry e =
								//													System.Net.Dns.GetHostEntry("www.google.com");
								//				}
								//				catch
								//				{
								//								MainMap.Manager.Mode = AccessMode.CacheOnly;
								//								MessageBox.Show("No internet connection avaible, going to CacheOnly mode.",
								//														"GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK,
								//														MessageBoxIcon.Warning);
								//				}

								//				// config map
								//				MainMap.MapProvider = GMapProviders.GoogleMap;
								//				MainMap.Position = new PointLatLng(54.6961334816182, 25.2985095977783);
								//				MainMap.MinZoom = 0;
								//				MainMap.MaxZoom = 24;
								//				MainMap.Zoom = 9;
								//}

								#region Data

								private void LoadData()
								{
												foreach (string lineName in this.lineNames)
																this.AddLine(lineName);

												this.circularChartLoaded = false;
												this.gpsChartTabLoaded = false;

												this.AddBarChartItemList();
												this.AddBoldedDates();

								}

								private void AddLocation(SortedSet<Coordinate> coordinatesDirection0, SortedSet<Coordinate> coordinatesDirection1, string fileLine, string lineName)
								{
												string[] parts = fileLine.Split(';');
												if (parts.Length != 7)
																return;

												string route = parts[4];
												int direction;

												try {
																direction = int.Parse(parts[5]);
												}
												catch {
																return;
												}

												if (!route.Equals(lineName))
																return;

												DateTime time;
												float latitude, longitude;
												string vehicleID = parts[0];

												try {
																time = DateTime.Parse(parts[1]);
																latitude = float.Parse(parts[2], CultureInfo.InvariantCulture);
																longitude = float.Parse(parts[3], CultureInfo.InvariantCulture);


																if (direction == 1)
																				coordinatesDirection1.Add(new Coordinate(vehicleID, latitude, longitude, time));
																else if (direction == 0)
																				coordinatesDirection0.Add(new Coordinate(vehicleID, latitude, longitude, time));

												}
												catch {
																return;
												}

								}

								private void AddArrival(SortedSet<Arrival> arrivals, string fileLine)
								{
												string[] parts = fileLine.Split(';');

												if (parts.Length != 5)
																return;

												string stopID = parts[1];
												string scheduledString = parts[3];
												string actualString = parts[4];

												if (stopID == "undefined" || stopID == "null" ||
																scheduledString == "undefined" || scheduledString == "null" ||
																actualString == "undefined" || actualString == "null")
																return;
												try {
																DateTime scheduled = DateTime.Parse(parts[3]);
																DateTime actual = DateTime.Parse(parts[4]);

																arrivals.Add(new Arrival(scheduled, actual, stopID));

												}
												catch {
												}

								}

								private void AddLine(string lineName)
								{
												Console.WriteLine("Starting to load: " + lineName);

												string adherenceFileName = lineName + "_routeAdhrence.csv";

												string[] adhrenceFileLines = System.IO.File.ReadAllLines(this.folderPath + "\\" + adherenceFileName);

												SortedSet<Arrival> arrivals = new SortedSet<Arrival>(new ByArrival());
												foreach (string fileLine in adhrenceFileLines)
																this.AddArrival(arrivals, fileLine);

												string[] locationFileLines = System.IO.File.ReadAllLines(this.folderPath + "\\" + "vehicleLocation.csv");

												SortedSet<Coordinate> coordinatesDirection0 = new SortedSet<Coordinate>(new ByCoordinate());
												SortedSet<Coordinate> coordinatesDirection1 = new SortedSet<Coordinate>(new ByCoordinate());

												foreach (string fileLine in locationFileLines)
																this.AddLocation(coordinatesDirection0, coordinatesDirection1, fileLine, lineName);

												Coordinate[] firstLastStation = this.GetFirstLastStation(lineName);

												Coordinate firstStation = firstLastStation[0];
												Coordinate lastStation = firstLastStation[1];

												this.lines.Add(lineName, new Line(lineName, arrivals, coordinatesDirection0, coordinatesDirection1, firstStation, lastStation));

												Console.WriteLine("Finished loading: " + lineName);

								}

								private Coordinate[] GetFirstLastStation(string lineName)
								{

												lineName = lineName.Replace('-', '_');

												string firstFieldName = "LINE_" + lineName.ToUpper() + "_START";
												string lastFieldName = "LINE_" + lineName.ToUpper() + "_END";

												Coordinate firstStation = (Coordinate) typeof(Constants).GetField(firstFieldName).GetValue(null);
												Coordinate lastStation = (Coordinate) typeof(Constants).GetField(lastFieldName).GetValue(null);

												return new Coordinate[2] { firstStation, lastStation };
								}

								private void ChooseFolder_Click(object sender, EventArgs e)
								{
												if (this.FilesFolder.ShowDialog() == DialogResult.OK) {
																//Get the path of specified file
																this.folderPath = this.FilesFolder.SelectedPath;
																this.LoadData();

																this.DrawTab();

												}
								}


								#endregion

								#region Navigation

								private void DrawTab()
								{


												this.StartTime.Visible = true;
												this.NumDaysSelector.Visible = false;

												switch (this.TabControl.SelectedIndex) {
																case Constants.BAR_CHART_TAB:
																				this.DrawBarChartTab();
																				break;
																case Constants.CIRCULAR_CHART_TAB:
																				this.DrawCircularChartTab();
																				break;
																case Constants.GPS_CHART_TAB:
																				this.DrawGPSChartTab();
																				break;
																default:
																				break;
												}
								}

								private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
								{
												this.DrawTab();
								}

								#endregion

								#region Bar Chart

								string selectedBarChartLine;

								private void RefreshChart()
								{
												this.barChart.Series["On Time"].Points.Clear();
												this.barChart.Series["Late"].Points.Clear();
												this.barChart.Series["Early"].Points.Clear();

												DateTime beginDate = new DateTime(this.startDate.Year, this.startDate.Month, this.startDate.Day);
												DateTime endDate = beginDate.AddDays((int) this.NumDaysSelector.Value);

												Arrival firstArrival = new Arrival(beginDate, beginDate);
												Arrival lastArrival = new Arrival(endDate, endDate);

												if (this.selectedBarChartLine == "none" || this.selectedBarChartLine == null)
																foreach (string lineName in this.lines.Keys)
																				this.RefreshBar(lineName, this.lines[lineName].Arrivals.GetViewBetween(firstArrival, lastArrival).ToList());
												else
																this.RefreshStops(firstArrival, lastArrival);

								}

								private void RefreshStops(Arrival firstArrival, Arrival lastArrival)
								{
												Dictionary<string, List<Arrival>> arrivalsByStop = new Dictionary<string, List<Arrival>>();

												foreach (Arrival arrival in this.lines[this.selectedBarChartLine].Arrivals.GetViewBetween(firstArrival, lastArrival)) {
																string stopId = arrival.StopID;

																if (!arrivalsByStop.ContainsKey(stopId))
																				arrivalsByStop.Add(stopId, new List<Arrival>());

																arrivalsByStop[stopId].Add(arrival);
												}

												foreach (string stopName in arrivalsByStop.Keys)
																this.RefreshBar(stopName, arrivalsByStop[stopName]);

								}

								private void RefreshBar(string barName, List<Arrival> arrivals)
								{

												int earlyArrivals = 0;
												int onTimeArrivals = 0;
												int lateArrivals = 0;

												foreach (Arrival arrival in arrivals) {


																int onTime = arrival.OnTime((int) this.EarlinessThresholdBarChart.Value, (int) this.LatenessThresholdBarChart.Value);

																if (onTime == Constants.ARRIVED_EARLY)
																				++earlyArrivals;
																else if (onTime == Constants.ARRIVED_ONTIME)
																				++onTimeArrivals;
																else
																				++lateArrivals;
												}

												int totalArrivals = earlyArrivals + onTimeArrivals + lateArrivals;

												DataPoint point = new DataPoint();
												point.SetValueXY(barName, (double) onTimeArrivals / totalArrivals * 100);
												//point.ToolTip = "" + onTimeArrivals / totalArrivals * 100;
												this.barChart.Series["On Time"].Points.Add(point);
												this.barChart.Series["Late"].Points.AddXY(barName, (double) lateArrivals / totalArrivals * 100);
												this.barChart.Series["Early"].Points.AddXY(barName, (double) earlyArrivals / totalArrivals * 100);
								}

								private void BarChartThresholdsChanged(object sender, EventArgs e)
								{
												this.RefreshChart();
								}

								private void BarChartStopList_ItemCheck(object sender, ItemCheckEventArgs e)
								{
												if (e.NewValue == CheckState.Checked) {
																for (int ix = 0; ix < this.BarChartStopList.Items.Count; ++ix)
																				if (e.Index != ix) this.BarChartStopList.SetItemChecked(ix, false);

																this.selectedBarChartLine = (string) this.BarChartStopList.Items[e.Index];
												}
												else
																this.selectedBarChartLine = "none";

												this.RefreshChart();
								}

								private void AddBarChartItemList()
								{
												foreach (string line in this.lines.Keys)
																this.BarChartStopList.Items.Add(line);
								}

								private void DrawBarChartTab()
								{
												this.StartTime.Visible = false;
												this.NumDaysSelector.Visible = true;
												this.BarChartBottomFlow.Visible = true;
												this.RefreshChart();
								}



								#endregion

								#region Circular Chart

								string circularChartSelectedLine;
								bool circularChartLoaded = false;

								private void DrawSelectedLineCircular()
								{

												DateTime monday = this.startDate.AddDays(-(int) this.startDate.DayOfWeek + (int) DayOfWeek.Monday);
												Console.WriteLine(monday);

												List<vtkActor> actors = new List<vtkActor>();


												if (!string.IsNullOrEmpty(this.circularChartSelectedLine))
																actors.AddRange(this.DrawSectors(monday, 5, this.lines[this.circularChartSelectedLine]));

												vtkRenderWindow renderWindow = this.RenderWindowCircularChart.RenderWindow;

												vtkInteractorStyleImage interactorStyle = new vtkInteractorStyleImage();
												renderWindow.GetInteractor().SetInteractorStyle(interactorStyle);

												vtkRenderer renderer = renderer = renderWindow.GetRenderers().GetFirstRenderer();
												renderer.SetBackground(0.2, 0.3, 0.4);

												renderer.Clear();
												this.RenderWindowCircularChart.Invalidate();


												actors.AddRange(this.DrawClockLines());


												foreach (vtkActor actor in actors)
																renderer.AddActor(actor);



												this.RenderWindowCircularChart.Update();

								}

								private List<vtkActor> DrawClockLines()
								{
												List<vtkActor> actors = new List<vtkActor>();

												// Create a line.  
												vtkLineSource line1 = vtkLineSource.New();
												vtkLineSource line2 = vtkLineSource.New();
												vtkLineSource line3 = vtkLineSource.New();
												vtkLineSource line4 = vtkLineSource.New();

												line1.SetPoint1(0.05, 0, 0);
												line1.SetPoint2(1.05, 0, 0);
												line2.SetPoint1(0, 0.05, 0);
												line2.SetPoint2(0, 1.05, 0);
												line3.SetPoint1(-0.05, 0, 0);
												line3.SetPoint2(-1.05, 0, 0);
												line4.SetPoint1(0, -0.05, 0);
												line4.SetPoint2(0, -1.05, 0);

												vtkLineSource[] lines = { line1, line2, line3, line4 };

												foreach (vtkLineSource line in lines) {
																vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
																mapper.SetInputConnection(line.GetOutputPort());
																vtkActor lineActor = vtkActor.New();
																lineActor.SetMapper(mapper);
																lineActor.GetProperty().SetColor(0, 0, 0);
																actors.Add(lineActor);
												}

												return actors;
								}

								private List<vtkActor> DrawSectors(DateTime startDate, int numDays, Line line)
								{

												List<vtkActor> actors = new List<vtkActor>();
												SortedSet<Arrival> arrivals = line.Arrivals;

												for (int day = 0; day < numDays; ++day) {
																DateTime nextDay = startDate.AddDays(1);

																actors.AddRange(this.DrawSector(startDate, day, arrivals));

																startDate = nextDay;
												}

												return actors;
								}

								private List<vtkActor> DrawSector(DateTime startDate, int day, SortedSet<Arrival> arrivals)
								{
												List<vtkActor> actors = new List<vtkActor>();


												float minutesInterval = 24f * 60f / Constants.NUM_SECTORS;
												float sectorAngle = 360f / Constants.NUM_SECTORS;

												for (int i = 0; i < Constants.NUM_SECTORS; ++i) {
																DateTime nextSector = startDate.AddMinutes(minutesInterval);

																float r, g, b;
																r = b = g = 0.2f;

																SortedSet<Arrival> arrivalsSubset = arrivals.GetViewBetween(new Arrival(startDate, startDate), new Arrival(nextSector, nextSector));
																if (arrivalsSubset.Count != 0) {
																				float sectorValue = 0;

																				foreach (Arrival arrival in arrivalsSubset)
																								sectorValue += Math.Abs(arrival.OnTime((int) this.EarlinessThresholdCircularChart.Value, (int) this.LatenessThresholdCircularChart.Value));

																				if (sectorValue == 0)
																								g = 1;
																				else
																								r = 1;

																}

																actors.Add(this.CreateDiskSector(Constants.FIRST_INNER_RADIUS + ( day * ( Constants.DISK_RADIUS + Constants.DISK_SEPARATOR_RADIUS ) ), Constants.DISK_RADIUS, 270 + sectorAngle * i, sectorAngle, r, g, 0.2f));

																startDate = nextSector;
												}

												return actors;
								}

								private vtkActor CreateDiskSector(double innerRadius, double radius, double startAngle, double arcAngle, float r, float g, float b)
								{
												startAngle = 360 - startAngle;
												arcAngle = 360 - arcAngle;

												startAngle *= Constants.DEG_TO_RAD;
												arcAngle *= Constants.DEG_TO_RAD;
												double finalAngle = arcAngle + startAngle;

												double clip1X = -Math.Cos(Math.PI / 2 + startAngle);
												double clip1Y = -Math.Sin(Math.PI / 2 + startAngle);
												double clip2X = Math.Cos(Math.PI / 2 + finalAngle);
												double clip2Y = Math.Sin(Math.PI / 2 + finalAngle);

												return this.DiskSector(innerRadius, radius, clip1X, clip1Y, clip2X, clip2Y, r, g, b);
								}

								private vtkActor DiskSector(double innerRadius, double radius, double clip1X, double clip1Y, double clip2X, double clip2Y, float r, float g, float b)
								{

												vtkProperty arcColor = vtkProperty.New();
												arcColor.SetColor(r, g, b);

												vtkDiskSource outerDisk = vtkDiskSource.New();
												outerDisk.SetCircumferentialResolution(50);
												outerDisk.SetRadialResolution(50);
												outerDisk.SetInnerRadius(innerRadius);
												outerDisk.SetOuterRadius(innerRadius + radius);

												// Define a clipping plane
												vtkPlane clipPlane = vtkPlane.New();
												clipPlane.SetNormal(clip1X, clip1Y, 0);
												clipPlane.SetOrigin(0.0, 0.0, 0.0);

												// Define a clipping plane
												vtkPlane clipPlane2 = vtkPlane.New();
												clipPlane2.SetNormal(clip2X, clip2Y, 0);
												clipPlane2.SetOrigin(0, 0, 0);


												vtkClipPolyData clipper = vtkClipPolyData.New();
												clipper.SetInputConnection(outerDisk.GetOutputPort());
												clipper.SetClipFunction(clipPlane);

												vtkClipPolyData clipper2 = vtkClipPolyData.New();
												clipper2.SetInputConnection(clipper.GetOutputPort());
												clipper2.SetClipFunction(clipPlane2);


												// Visualize
												vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
												mapper.SetInputConnection(clipper2.GetOutputPort());


												vtkActor actor = vtkActor.New();
												actor.SetMapper(mapper);
												actor.SetProperty(arcColor);


												return actor;
								}

								private void CircularChartLineChanged(object sender, EventArgs e)
								{
												RadioButton newSelected = (RadioButton) sender;
												if (newSelected.Checked == true) {
																foreach (RadioButton radioButton in this.CircularChartCenterFlow.Controls) {
																				if (radioButton != newSelected)
																								radioButton.Checked = false;
																}
																this.circularChartSelectedLine = newSelected.Name;

																this.DrawSelectedLineCircular();
												}
								}

								private void CircularChartThresholdsChanged(object sender, EventArgs e)
								{
												this.DrawSelectedLineCircular();
								}

								private void DrawCircularChartTab()
								{
												this.CircularChartBottomFlow.Visible = true;
												this.CircularChartCenterFlow.Visible = true;
												this.StartTime.Visible = false;

												if (!this.circularChartLoaded) {
																bool selectedFirst = false;
																foreach (string lineName in this.lines.Keys) {
																				RadioButton radioButton = new RadioButton {
																								Name = lineName,
																								Text = lineName,
																								AutoSize = true,
																								Parent = this.CircularChartCenterFlow
																				};

																				if (!selectedFirst) {
																								radioButton.Checked = true;
																								selectedFirst = true;
																								this.circularChartSelectedLine = lineName;
																				}
																				radioButton.CheckedChanged += this.CircularChartLineChanged;

																}

																this.circularChartLoaded = true;
												}

												this.DrawSelectedLineCircular();

								}

								#endregion

								#region GPS Chart

								bool gpsChartTabLoaded = false;
								bool playing = false;

								DateTime startDate;
								float step = 2;
								private string GPSChartSelectedLine;

								private List<vtkActor> DrawLineSectors(string lineName)
								{
												Line line = this.lines[lineName];

												List<vtkActor> actors = new List<vtkActor>();
												actors.AddRange(this.DrawDirection(line.CoordinatesDirection0, 0.5f, line.firstStation, line.lastStation));
												actors.AddRange(this.DrawDirection(line.CoordinatesDirection1, -0.5f, line.firstStation, line.lastStation));

												return actors;
								}

								private List<vtkActor> DrawDirection(SortedSet<Coordinate> coordinates, float yOffset, Coordinate start, Coordinate end)
								{
												DateTime endDate = this.startDate.AddMinutes(this.step);
												SortedSet<Coordinate> subset = coordinates.GetViewBetween(new Coordinate(this.startDate), new Coordinate(endDate));

												SortedSet<Coordinate> noDuplicates = new SortedSet<Coordinate>(new ByDist(start));
												foreach (Coordinate coord in subset) {
																bool insert = true;
																foreach (Coordinate coord2 in noDuplicates)
																				if (coord.VehicleID.Equals(coord2.VehicleID)) {
																								insert = false;
																								break;
																				}

																if (insert)
																				noDuplicates.Add(coord);
												}

												double routeLength = Coordinate.CalcDist(start, end);
												double scale = Constants.TUBE_SIZE / routeLength;
												float curX = Constants.TUBE_START_X;


												float averageDist = Constants.TUBE_SIZE / noDuplicates.Count;
												float maxAcceptableDist = averageDist * ( 1 + Constants.ACCEPTABLE_DIST_SKEW );
												float minAcceptableDist = averageDist * ( 1 - Constants.ACCEPTABLE_DIST_SKEW );
												float maxUnreasonableDist = averageDist * ( 1 + Constants.GRAVE_DIST_SKEW );
												float minUnreasonableDist = averageDist * ( 1 - Constants.GRAVE_DIST_SKEW );

												List<vtkActor> actors = new List<vtkActor>();

												bool first = true;

												foreach (Coordinate coord in noDuplicates) {

																double distToOrigin = Coordinate.CalcDist(start, coord) * scale;
																double size = Math.Abs(curX - ( Constants.TUBE_START_X + distToOrigin ));

																size = Math.Min(Constants.TUBE_START_X + Constants.TUBE_SIZE - curX, size);

																Color color;

																if (first) {
																				first = false;
																				color = Color.GRAY;
																}
																else {
																				if (size > maxUnreasonableDist || size < minUnreasonableDist)
																								color = Color.RED;
																				else if (size > maxAcceptableDist || size < minAcceptableDist)
																								color = Color.YELLOW;
																				else
																								color = Color.GREEN;
																}
																actors.Add(this.DrawLineSector(curX, yOffset, (float) size, color));
																actors.Add(this.DrawIndicatorLine(curX, yOffset));
																curX = Constants.TUBE_START_X + (float) distToOrigin;
												}
												{
																double size = ( Constants.TUBE_START_X + Constants.TUBE_SIZE ) - curX;

																actors.Add(this.DrawLineSector(curX, yOffset, (float) size, Color.GRAY));
																actors.Add(this.DrawIndicatorLine(curX, yOffset));

																curX = ( Constants.TUBE_START_X + Constants.TUBE_SIZE );
																actors.Add(this.DrawIndicatorLine(curX, yOffset));

												}

												return actors;
								}

								private vtkActor DrawIndicatorLine(float curX, float yOffset)
								{
												// Create a line.  
												vtkLineSource lineSource = vtkLineSource.New();
												// Create two points, P0 and P1
												double[] p0 = new double[] { curX, -Constants.INDICATOR_LINE_OFFSET + yOffset, 0.0 };
												double[] p1 = new double[] { curX, Constants.INDICATOR_LINE_OFFSET + yOffset, 0.0 };

												lineSource.SetPoint1(p0[0], p0[1], p0[2]);
												lineSource.SetPoint2(p1[0], p1[1], p1[2]);

												// Visualize
												vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
												mapper.SetInputConnection(lineSource.GetOutputPort());
												vtkActor lineActor = vtkActor.New();
												lineActor.SetMapper(mapper);
												lineActor.GetProperty().SetColor(0, 0, 0);

												return lineActor;
								}

								//private vtkActor DrawVehicleID(float curX, float ySign)
								//{

								//				// Create text
								//				vtkVectorText textSource = new vtkVectorText();
								//				textSource.SetText("Hello");
								//				textSource.Update();

								//				// Visualize
								//				vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
								//				mapper.SetInputConnection(textSource.GetOutputPort());


								//				vtkActor textActor = vtkActor.New();

								//				textActor.SetScale(Constants.INDICATOR_TEXT_SIZE_X, Constants.INDICATOR_TEXT_SIZE_Y, 1);

								//				double[] bounds = textActor.GetXRange();

								//				Console.WriteLine(bounds[0]);
								//				Console.WriteLine(bounds[1]);

								//				double halfSize = (bounds[1] - bounds[0]) / 2d;

								//				textActor.SetPosition(curX - halfSize, Constants.INDICATOR_LINE_OFFSET * ySign, 0);

								//				textActor.SetMapper(mapper);
								//				textActor.GetProperty().SetColor(1, 0, 0);

								//				return textActor;
								//}

								private vtkActor DrawLineSector(float startX, float yOffset, float size, Color color)
								{
												// Create a line.  
												vtkLineSource lineSource = vtkLineSource.New();
												// Create two points, P0 and P1
												double[] p0 = new double[] { startX, yOffset, 0.0 };
												double[] p1 = new double[] { startX + size, yOffset, 0.0 };

												lineSource.SetPoint1(p0[0], p0[1], p0[2]);
												lineSource.SetPoint2(p1[0], p1[1], p1[2]);


												vtkTubeFilter tube = new vtkTubeFilter();
												tube.SetInputConnection(lineSource.GetOutputPort());
												tube.SetRadius(0.1);
												tube.SetNumberOfSides(50);
												tube.Update();


												// Visualize
												vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
												mapper.SetInputConnection(tube.GetOutputPort());
												vtkActor tubeActor = vtkActor.New();
												tubeActor.SetMapper(mapper);
												tubeActor.GetProperty().SetColor(color.r, color.g, color.b);

												return tubeActor;
								}

								private void DrawSelectedLineGPS()
								{
												this.SetFrameTime();

												if (this.lines.Count == 0)
																return;

												vtkRenderWindow renderWindow = this.RenderWindowGPS.RenderWindow;
												vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
												renderer.SetBackground(0.2, 0.3, 0.4);

												renderer.RemoveAllViewProps();
												renderer.Clear();

												foreach (vtkActor actor in this.DrawLineSectors(this.GPSChartSelectedLine))
																renderer.AddActor(actor);

												this.RenderWindowGPS.Invalidate();

								}

								private void DrawGPSChartTab()
								{
												this.SetFrameTime();

												if (!this.gpsChartTabLoaded) {

																vtkInteractorStyleImage interactorStyle = new vtkInteractorStyleImage();
																this.RenderWindowGPS.RenderWindow.GetInteractor().SetInteractorStyle(interactorStyle);


																bool selectedFirst = false;
																foreach (string lineName in this.lines.Keys) {
																				RadioButton radioButton = new RadioButton {
																								Name = lineName,
																								Text = lineName,
																								AutoSize = true,
																								Parent = this.GPSPageRadioButtonFlow
																				};

																				if (!selectedFirst) {
																								radioButton.Checked = true;
																								selectedFirst = true;
																								this.GPSChartSelectedLine = lineName;
																				}
																				radioButton.CheckedChanged += this.GPSChartLineChanged;

																}

																this.gpsChartTabLoaded = true;

												}


												this.DrawSelectedLineGPS();
												this.RenderWindowGPS.Refresh();


								}

								private void GPSChartLineChanged(object sender, EventArgs e)
								{


												RadioButton newSelected = (RadioButton) sender;
												if (newSelected.Checked == true) {
																foreach (RadioButton radioButton in this.GPSPageRadioButtonFlow.Controls) {
																				if (radioButton != newSelected)
																								radioButton.Checked = false;
																}
																this.GPSChartSelectedLine = newSelected.Name;

																this.DrawSelectedLineGPS();
												}
								}

								private void SetFrameTime()
								{
												this.DateLabel.Text = this.startDate.ToString("d");
												this.StartTime.Value = this.startDate;
												this.MonthCalendar.SetSelectionRange(this.startDate, this.startDate);
												this.StepLabel.Text = ( this.IntervalSlider.Value / 1000f ) + " seconds";
												this.FrameTimer.Interval = this.IntervalSlider.Value;
								}

								private void DrawNextFrame(int sign)
								{
												this.startDate = this.startDate.AddMinutes(sign * this.step);

												this.DrawSelectedLineGPS();
								}

								private void NextFrame_Click(object sender, EventArgs e)
								{
												this.DrawNextFrame(1);
								}

								private void PreviousFrame_Click(object sender, EventArgs e)
								{
												this.DrawNextFrame(-1);
								}

								private void PlayPause_Click(object sender, EventArgs e)
								{
												this.playing = !this.playing;

												if (this.playing) {
																this.PlayPause.Text = "Pause";
																this.FrameTimer.Start();
												}
												else {
																this.PlayPause.Text = "Play";
																this.FrameTimer.Stop();
												}
								}

								private void FrameTimer_Tick(object sender, EventArgs e)
								{
												this.DrawNextFrame(1);
								}

								private void IntervalSlider_ValueChanged(object sender, EventArgs e)
								{
												this.SetFrameTime();
								}


								private void BarChart_MouseMove(object sender, MouseEventArgs e)
								{

												HitTestResult result = this.barChart.HitTest(e.X, e.Y);

												if (result.PointIndex > -1 && result.ChartArea != null)
																try {
																				string toolTipMessage = result.Series.Points[result.PointIndex].YValues[0].ToString("0.0");

																				this.ChartToolTip.Show(toolTipMessage, this.barChart, e.X + 10, e.Y);
																}
																catch {

																}
												else
																this.ChartToolTip.Hide(this.barChart);
								}

								#endregion

								private void StartTime_ValueChanged(object sender, EventArgs e)
								{
												this.startDate = new DateTime(this.startDate.Year, this.startDate.Month, this.startDate.Day, this.StartTime.Value.Hour, this.StartTime.Value.Minute, this.StartTime.Value.Second);


												this.DrawTab();
								}

								private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
								{
												this.startDate = this.MonthCalendar.SelectionStart;

												this.DrawTab();
								}

								private void NumDaysSelector_ValueChanged(object sender, EventArgs e)
								{
												this.DrawTab();
								}
				}





}
