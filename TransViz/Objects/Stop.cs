using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransViz.Objects
{
				public class Stop
				{
								public string Name { get; private set; }
								public Coordinate Location { get; private set; }

								public Stop(string name, Coordinate location)
								{
												this.Name = name;
												this.Location = location;
								}
				}

				public class ByStopDist : IComparer<string>
				{
								private Dictionary<string, Stop> stops;

								public Coordinate Reference { get; private set; }


								public ByStopDist(Coordinate reference, Dictionary<string, Stop> stops) 
								{
												Reference = reference;
												this.stops = stops;
								}

								public int Compare(string x, string y)
								{
												return Math.Sign(Coordinate.CalcDist(Reference, stops[x].Location) - Coordinate.CalcDist(Reference, stops[y].Location));
								}
				}
}
