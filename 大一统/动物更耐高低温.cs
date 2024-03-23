﻿using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动物更耐高低温
{
	[HarmonyPatch(typeof(EntityTemplates), "ExtendEntityToBasicCreature")]
	public class 动物体质增强
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020B0 File Offset: 0x000002B0
		public static void Prefix(ref float warningLowTemperature, ref float warningHighTemperature, ref float lethalLowTemperature, ref float lethalHighTemperature)
		{
			if (PeterHan.PLib.Options.SingletonOptions<大一统.大一统控制台UI>.Instance.动物更耐高低温)
			{
				if (warningLowTemperature > 150f) warningLowTemperature -= 100f;
				if (warningHighTemperature < 303.15f) warningLowTemperature = 303.15f;
				if (lethalLowTemperature > 150f) lethalLowTemperature -= 100f;
				if (lethalHighTemperature < 275.15f + 55f) lethalHighTemperature = 275.15f + 55f;
			}
		}
	}
}
