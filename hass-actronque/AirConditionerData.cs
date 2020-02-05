﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HMX.HASSActronQue
{
	public class AirConditionerData
	{
		public Dictionary<int, AirConditionerZone> Zones;
		public string FanMode; // FanMode
		public string Mode; // Mode
		public bool On; // isOn
		public double SetTemperatureCooling; // TemperatureSetpoint_Cool_oC
		public double SetTemperatureHeating; // TemperatureSetpoint_Heat_oC
		public string CompressorState; // CompressorMode
		public DateTime LastUpdated;
	}
}
