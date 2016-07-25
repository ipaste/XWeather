/* This file was generated by Settings Studio
 *
 * Copyright © 2015 Colby Williams. All Rights Reserved.
 */

using XWeather;

namespace SettingsStudio
{

	public static partial class Settings
	{

		#region Visible Settings


		public static string VersionNumber => StringForKey (SettingsKeys.VersionNumber);

		public static string BuildNumber => StringForKey (SettingsKeys.BuildNumber);

		public static string GitHash => StringForKey (SettingsKeys.GitCommitHash);

		public static string UserReferenceKey => StringForKey (SettingsKeys.UserReferenceKey);

		public static bool RandomBackgrounds {
			get { return BoolForKey (SettingsKeys.RandomBackgrounds); }
			set { SetSetting (SettingsKeys.RandomBackgrounds, value); }
		}

		public static TemperatureUnits UomTemperature {
			get { return (TemperatureUnits)Int32ForKey (SettingsKeys.UomTemperature); }
			set { SetSetting (SettingsKeys.UomTemperature, (int)value); }
		}

		public static DistanceUnits UomDistance {
			get { return (DistanceUnits)Int32ForKey (SettingsKeys.UomDistance); }
			set { SetSetting (SettingsKeys.UomDistance, (int)value); }
		}

		public static PressureUnits UomPressure {
			get { return (PressureUnits)Int32ForKey (SettingsKeys.UomPressure); }
			set { SetSetting (SettingsKeys.UomPressure, (int)value); }
		}

		public static LengthUnits UomLength {
			get { return (LengthUnits)Int32ForKey (SettingsKeys.UomLength); }
			set { SetSetting (SettingsKeys.UomLength, (int)value); }
		}

		public static SpeedUnits UomSpeed {
			get { return (SpeedUnits)Int32ForKey (SettingsKeys.UomSpeed); }
			set { SetSetting (SettingsKeys.UomSpeed, (int)value); }
		}


		#endregion


		#region Hidden Settings


		public static string LocationsJson {
			get { return StringForKey (SettingsKeys.LocationsJson); }
			set { SetSetting (SettingsKeys.LocationsJson, value ?? string.Empty); }
		}


		public static int WeatherPage {
			get { return Int32ForKey (SettingsKeys.WeatherPage); }
			set { SetSetting (SettingsKeys.WeatherPage, value); }
		}


		public static bool HighLowGraph {
			get { return BoolForKey (SettingsKeys.HighLowGraph); }
			set { SetSetting (SettingsKeys.HighLowGraph, value); }
		}


		#endregion
	}
}
