using System;
using UnityEngine;
using System.Collections.Generic;

namespace AlmostEngine.Screenshot
{
	[Serializable]
	public class PopularityPresetAsset : ScriptableObject
	{
		[Serializable]
		public class Stat
		{
			public ScreenshotResolutionAsset m_Resolution;
			public float m_Frequency;
		}

		public List<PopularityPresetAsset.Stat> m_Stats;
	}
}
