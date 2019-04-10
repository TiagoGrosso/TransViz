using System;
using System.Collections.Generic;

namespace TransViz.Objects
{
				public class Coordinate
				{

								public string VehicleID { get; private set; }
								public float Latitude { get; private set; }
								public float Longitude { get; private set; }
								public DateTime Time { get; private set; }

								public Coordinate(string vehicleID, float latitude, float longitude, DateTime time)
								{
												this.VehicleID = vehicleID;
												this.Latitude = latitude;
												this.Longitude = longitude;
												this.Time = time;
								}

								public Coordinate(float latitude, float longitude)
								{
												this.Latitude = latitude;
												this.Longitude = longitude;
								}

								public Coordinate(DateTime time)
								{
												this.VehicleID = "MOCK";
												this.Time = time;
								}

								public static double CalcDist(Coordinate start, Coordinate end)
								{
												double earthRadiusKm = 6371;

												double dLat = Constants.DEG_TO_RAD * (end.Latitude - start.Latitude);
												double dLon = Constants.DEG_TO_RAD * (end.Longitude - start.Longitude);

												double lat1 = Constants.DEG_TO_RAD * start.Latitude;
												double lat2 = Constants.DEG_TO_RAD * end.Latitude;

												double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
																				Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
												double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

												return earthRadiusKm * c;
								}
				}



				public class ByCoordinate : IComparer<Coordinate>
				{

								public int Compare(Coordinate x, Coordinate y)
								{
												int timeComparison = DateTime.Compare(x.Time, y.Time);

												return timeComparison != 0 ? timeComparison : string.Compare(x.VehicleID, y.VehicleID);
								}
				}


				public class ByDist : IComparer<Coordinate>
				{
								public Coordinate Reference { get; private set; }

								public ByDist(Coordinate reference)
								{
												Reference = reference;
								}

								public int Compare(Coordinate x, Coordinate y)
								{
												return Math.Sign(Coordinate.CalcDist(Reference, x) - Coordinate.CalcDist(Reference, y));
								}
				}
}
