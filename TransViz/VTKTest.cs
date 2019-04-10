using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TransViz.Objects;



namespace TransViz {
				public partial class VTKTest : Form {

								SortedSet<Arrival> arrivals = new SortedSet<Arrival>(new ByArrival());

								public VTKTest()
								{
												this.InitializeComponent();
								}

								private void GetData(string fileName)
								{
												string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Utilizador\Desktop\Tese\" + fileName);


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
																				this.arrivals.Add(new Arrival(scheduled, actual));
																}
																catch {
																}
												}
								}

								private void DrawSectors(DateTime startDate, int numDays)
								{
												for (int day = 0; day < numDays; ++day) {
																DateTime nextDay = startDate.AddDays(1);

																this.DrawSector(startDate, day);

																startDate = nextDay;
												}

								}

								private void DrawSector(DateTime startDate, int day)
								{
												float minutesInterval = 24f * 60f / Constants.NUM_SECTORS;
												float sectorAngle = 360f / Constants.NUM_SECTORS;
												Console.WriteLine(sectorAngle);

												for (int i = 0; i < Constants.NUM_SECTORS; ++i) {
																DateTime nextSector = startDate.AddMinutes(minutesInterval);

																float r, g, b;
																r = b = g = 0.2f;

																SortedSet<Arrival> arrivalsSubset = this.arrivals.GetViewBetween(new Arrival(startDate, startDate), new Arrival(nextSector, nextSector));
																if (arrivalsSubset.Count != 0) {
																				float sectorValue = 0;

																				foreach (Arrival arrival in arrivalsSubset)
																								sectorValue += arrival.OnTime(1000, 6);

																				if (sectorValue == 0)
																								g = 1;
																				else
																								r = 1;

																}

																this.CreateDiskSector(Constants.FIRST_INNER_RADIUS + ( day * ( Constants.DISK_RADIUS + Constants.DISK_SEPARATOR_RADIUS ) ), Constants.DISK_RADIUS, 270 + sectorAngle * i, sectorAngle, r, g, 0.2f);

																startDate = nextSector;
												}
								}

								private void RenderWindowControl1_Load(object sender, EventArgs e)
								{
												try {
																this.GetData(@"Green-B_routeAdhrence.csv");
																this.DrawSectors(new DateTime(2019, 1, 14), 5);
												}
												catch (Exception ex) {
																MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK);
												}

								}

								private void CreateDiskSector(double innerRadius, double radius, double startAngle, double arcAngle, float r, float g, float b)
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

												this.DiskSector(innerRadius, radius, clip1X, clip1Y, clip2X, clip2Y, r, g, b);
								}

								private void DiskSector(double innerRadius, double radius, double clip1X, double clip1Y, double clip2X, double clip2Y, float r, float g, float b)
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

												vtkRenderWindow renderWindow = this.renderWindowControl1.RenderWindow;
												vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
												renderer.SetBackground(0.2, 0.3, 0.4);
												renderer.AddActor(actor);
								}


				}


}

