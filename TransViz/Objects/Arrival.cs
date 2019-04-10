using System;
using System.Collections;
using System.Collections.Generic;

namespace TransViz.Objects {
				public class Arrival {
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
																return Constants.ARRIVED_LATE;
												else if (difference <= -earlinessThreshold * 60)
																return Constants.ARRIVED_EARLY;

												return Constants.ARRIVED_ONTIME;
								}


								public Arrival(DateTime scheduled, DateTime actual)
								{
												this.Scheduled = scheduled;
												this.Actual = actual;
								}
				}

				public class ByArrival : IComparer<Arrival> {

								public int Compare(Arrival x, Arrival y)
								{
												return DateTime.Compare(x.Scheduled, y.Scheduled);
								}
				}
}
