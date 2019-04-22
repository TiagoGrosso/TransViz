using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransViz.Objects
{
				public struct Color
				{
								public readonly float r, g, b;

								public Color(float r, float g, float b)
								{
												this.r = r;
												this.g = g;
												this.b = b;
								}


								public readonly static Color RED = new Color(1, 0.2f, 0.2f);
								public readonly static Color GREEN = new Color(0.2f, 1, 0.2f);
								public readonly static Color GRAY = new Color(0.2f, 0.2f, 0.2f);
								public readonly static Color YELLOW = new Color(1f, 1f, 0.2f);

				}

				public class Constants
				{

								public const int ARRIVED_EARLY = -1;
								public const int ARRIVED_ONTIME = 0;
								public const int ARRIVED_LATE = 1;

								public const double DEG_TO_RAD = Math.PI / 180;
								public const int NUM_SECTORS = 200;
								public const double FIRST_INNER_RADIUS = 0.45;
								public const double DISK_SEPARATOR_RADIUS = 0.01;
								public const double DISK_RADIUS = 0.1;


								public const int BAR_CHART_TAB = 0;
								public const int CIRCULAR_CHART_TAB = 1;
								public const int GPS_CHART_TAB = 2;

								public const float TUBE_START_X = -1f;
								public const float TUBE_SIZE = 2f;
								public const float INDICATOR_LINE_OFFSET = 0.2f;
								public const float INDICATOR_TEXT_SIZE_X = 0.05f;
								public const float INDICATOR_TEXT_SIZE_Y = 0.05f;
								public const float SECONDS_PER_FRAME = 0.5f;
								public const float ACCEPTABLE_DIST_SKEW = 0.2f;
								public const float GRAVE_DIST_SKEW = 0.4f;

								public static Coordinate RED_LINE_START = new Coordinate(42.2844f, -71.06369999999998f);
								public static Coordinate RED_LINE_END = new Coordinate(42.3961388f, -71.1407727f);


				}
}
