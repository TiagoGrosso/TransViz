using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransViz.Objects
{
				public class Line
				{
								public string Name {
												get; private set;
								}
								public SortedSet<Arrival> Arrivals {
												get; private set;
								}
								public SortedSet<Coordinate> CoordinatesDirection0 {
												get; private set;
								}
								public SortedSet<Coordinate> CoordinatesDirection1 {
												get; private set;
								}

								public Line(string name, SortedSet<Arrival> arrivals, SortedSet<Coordinate> coordinatesDirection0, SortedSet<Coordinate> coordinatesDirection1)
								{
												this.Name = name;
												this.Arrivals = arrivals;
												this.CoordinatesDirection0 = coordinatesDirection0;
												this.CoordinatesDirection1 = coordinatesDirection1;
								}
				}
}
