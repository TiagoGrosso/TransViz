using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TransViz {
				public partial class ChartPage : Form {

								public const int ARRIVED_EARLY = -1;
								public const int ARRIVED_ONTIME = 0;
								public const int ARRIVED_LATE = 1;

								string folderPath;

								private class Arrival {
												public DateTime Scheduled {
																get; private set;
												}

												public DateTime Actual {
																get; private set;
												}

												/* TODO 
												 * CHANGE TO AN LATENESS NUMBER TO AVOID SOMECALCULATIONS AND LAG
												 * 
													* Current:
												 * Checks if the arrival was beyond an earliness or lateness threshold
													* Threshold is given in minutes
													* Return 0 for an On Time Arrival, -1 for early and 1 for late
													*/
												public int OnTime(int earlinessThreshold, int latenessThreshold)
												{
																double difference = ( this.Actual - this.Scheduled ).TotalSeconds;
																if (difference >= latenessThreshold * 60)
																				return ARRIVED_LATE;
																else if (difference <= -earlinessThreshold * 60)
																				return ARRIVED_EARLY;

																return ARRIVED_ONTIME;
												}

												public Arrival(DateTime scheduled, DateTime actual)
												{
																this.Scheduled = scheduled;
																this.Actual = actual;
												}
								}
								private Dictionary<string, List<Arrival>> arrivalsByLine = new Dictionary<string, List<Arrival>>();

								public ChartPage()
								{
												this.InitializeComponent();
												this.barChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0} %";
								}

								private void LoadData()
								{
												AddLine("Red_routeAdhrence.csv", "Red");
												AddLine("747_routeAdhrence.csv", "747");
												AddLine("1_routeAdhrence.csv", "1");
												AddLine("Green-B_routeAdhrence.csv", "Green-B");
												AddLine("Green-C_routeAdhrence.csv", "Green-C");
												AddLine("Green-D_routeAdhrence.csv", "Green-D");
												AddLine("Green-E_routeAdhrence.csv", "Green-E");
								}

								private void AddLine(string fileName, string lineName)
								{
												string[] lines = System.IO.File.ReadAllLines(folderPath + "\\" + fileName);

												List<Arrival> arrivals = new List<Arrival>();

												foreach (string line in lines) {
																string[] parts = line.Split(';');

																if (parts.Length != 5)
																				continue;

																string scheduledString = parts[3];
																string actualString = parts[4];

																if (scheduledString == "undefined" || scheduledString == "null" || actualString == "undefined" || actualString == "null")
																				continue;
																try {
																				DateTime scheduled = DateTime.Parse(parts[3]);
																				DateTime actual = DateTime.Parse(parts[4]);

																				arrivals.Add(new Arrival(scheduled, actual));
																}
																catch {
																}
												}

												arrivalsByLine.Add(lineName, arrivals);
								}

								private void RefreshChart()
								{
												this.barChart.Series["On Time"].Points.Clear();
												this.barChart.Series["Late"].Points.Clear();
												this.barChart.Series["Early"].Points.Clear();

												foreach (string line in arrivalsByLine.Keys)
																RefreshLine(line);							
								}

								private void RefreshLine(string line)
								{
												List<Arrival> arrivals = arrivalsByLine[line];

												int earlyArrivals = 0;
												int onTimeArrivals = 0;
												int lateArrivals = 0;

												foreach (Arrival arrival in arrivals) {
																int onTime = arrival.OnTime((int) this.EarlinessThreshold.Value, (int) this.LatenessThreshold.Value);

																if (onTime == ARRIVED_EARLY)
																				++earlyArrivals;
																else if (onTime == ARRIVED_ONTIME)
																				++onTimeArrivals;
																else
																				++lateArrivals;
												}

												int totalArrivals = earlyArrivals + onTimeArrivals + lateArrivals;

												this.barChart.Series["On Time"].Points.AddXY(line, (double) onTimeArrivals / totalArrivals * 100);
												this.barChart.Series["Late"].Points.AddXY(line, (double) lateArrivals / totalArrivals * 100);
												this.barChart.Series["Early"].Points.AddXY(line, (double) earlyArrivals / totalArrivals * 100);

												Console.WriteLine("On Time = " + onTimeArrivals);
												Console.WriteLine("Late = " + lateArrivals);
												Console.WriteLine("Early = " + earlyArrivals);
								}

								private void ThresholdsChanged(object sender, EventArgs e)
								{
												this.RefreshChart();
								}

								private void ChooseFolder_Click(object sender, EventArgs e)
								{
												if (FilesFolder.ShowDialog() == DialogResult.OK) {
																//Get the path of specified file
																folderPath = FilesFolder.SelectedPath;

																this.LoadData();
																this.RefreshChart();
												}
								}
				}
}
