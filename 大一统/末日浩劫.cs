﻿using Database;
using HarmonyLib;
using Klei.AI;
using Klei.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace 末日浩劫
{
	[HarmonyPatch(typeof(GameplaySeasons), "Expansion1Seasons")]
	public class 流行抵达时间
	{
		public static void Postfix(ref GameplaySeasons __instance)
		{
			if (PeterHan.PLib.Options.SingletonOptions<大一统.大一统控制台UI>.Instance.末日浩劫)
			{
				((MeteorShowerSeason)__instance.RegolithMoonMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.TemporalTearMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.GassyMooteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.SpacedOutStyleStartMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.SpacedOutStyleRocketMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.SpacedOutStyleWarpMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.ClassicStyleStartMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.ClassicStyleWarpMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.TundraMoonletMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.MarshyMoonletMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.NiobiumMoonletMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.WaterMoonletMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.MiniMetallicSwampyMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.MiniForestFrozenMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.MiniBadlandsMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.MiniFlippedMeteorShowers).clusterTravelDuration /= 10;
				((MeteorShowerSeason)__instance.MiniRadioactiveOceanMeteorShowers).clusterTravelDuration /= 10;

				((MeteorShowerSeason)__instance.RegolithMoonMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.TemporalTearMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.GassyMooteorShowers).period = 3;
				((MeteorShowerSeason)__instance.SpacedOutStyleStartMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.SpacedOutStyleRocketMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.SpacedOutStyleWarpMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.ClassicStyleStartMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.ClassicStyleWarpMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.TundraMoonletMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.MarshyMoonletMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.NiobiumMoonletMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.WaterMoonletMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.MiniMetallicSwampyMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.MiniForestFrozenMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.MiniBadlandsMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.MiniFlippedMeteorShowers).period = 3;
				((MeteorShowerSeason)__instance.MiniRadioactiveOceanMeteorShowers).period = 3;

			}
		}
	}
}
