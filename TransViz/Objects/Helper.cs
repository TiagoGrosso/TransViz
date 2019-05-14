using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransViz.Objects
{
				public class Color
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

								public static Color[] colorPalette = {
												new Color(1, 0.843137f, 0),
												new Color(1, 0.694117f, 0.305882f),
												new Color(0.980392f, 0.529411f, 0.458823f),
												new Color(0.917647f, 0.372549f, 0.580392f),
												new Color(0.803921f, 0.203921f, 0.709803f),
												new Color(0.615686f, 0.007843f, 0.843137f),
												new Color(0, 0, 1)
								};

								/*
								 [  "rgb(255,215,0)",
												"rgb(255,177,78)",
												"rgb(250,135,117)",
												"rgb(234,95,148)",
												"rgb(205,52,181)",
												"rgb(157,2,215)",
												"rgb(0,0,255)"]
								*/


								public static Color GetColorFromPalette(float value, float min, float max)
								{

												float step = (max - min) / 7;
												int index = colorPalette.Length - 1;

												if (value > min)
												{
																float cur = min;

																while (index > 0)
																{
																				float next = cur + step;

																				if (value >= cur && value < next)
																								break;

																				--index;
																				cur = next;
																}
												}

												return colorPalette[index];
								}

								public static Color GetColorFromPalette(int step, int totalStep)
								{
												int index = totalStep / step - 1;

												return colorPalette[index];
								}

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
								public const float TUBE_DEFAULT_HALFSIZE_Y = 0.1f;
								public const float TUBE_MAX_DELTA_Y = 0.18f;

								public const float INDICATOR_LINE_OFFSET = 0.3f;
								public const float INDICATOR_TEXT_SIZE_X = 0.05f;
								public const float INDICATOR_TEXT_SIZE_Y = 0.05f;
								public const float SECONDS_PER_FRAME = 0.5f;
								public const float ACCEPTABLE_DIST_SKEW = 0.2f;
								public const float GRAVE_DIST_SKEW = 0.4f;

								public static Coordinate LINE_RED_START = new Coordinate(42.2844f, -71.06369999999998f);
								public static Coordinate LINE_RED_END = new Coordinate(42.3961388f, -71.1407727f);

								public static Coordinate LINE_747_START = new Coordinate(42.384035f, -71.076612f);
								public static Coordinate LINE_747_END = new Coordinate(42.336647f, -71.089407f);

								public static Coordinate LINE_1_START = new Coordinate(42.373366f, -71.118106f);
								public static Coordinate LINE_1_END = new Coordinate(42.329789f, -71.083887f);

								public static Coordinate LINE_GREEN_B_START = new Coordinate(42.340081f, -71.1689577f);
								public static Coordinate LINE_GREEN_B_END = new Coordinate(42.356395f, -71.062424f);

								public static Coordinate LINE_GREEN_C_START = new Coordinate(42.336142f, -71.149326f);
								public static Coordinate LINE_GREEN_C_END = new Coordinate(42.365577f, -71.06129f);

								public static Coordinate LINE_GREEN_D_START = new Coordinate(42.337059f, -71.251742f);
								public static Coordinate LINE_GREEN_D_END = new Coordinate(42.359705f, -71.059215f);

								public static Coordinate LINE_GREEN_E_START = new Coordinate(42.328316f, -71.110252f);
								public static Coordinate LINE_GREEN_E_END = new Coordinate(42.370772f, -71.076536f);

				}
}
