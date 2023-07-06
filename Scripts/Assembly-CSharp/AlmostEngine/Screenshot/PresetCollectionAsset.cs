using System;
using UnityEngine;
using System.Collections.Generic;

namespace AlmostEngine.Screenshot
{
	[Serializable]
	public class PresetCollectionAsset : ScriptableObject
	{
		public List<ScreenshotResolutionAsset> m_Presets;
	}
}
