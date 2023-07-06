using System;
using System.Collections.Generic;

namespace AlmostEngine.Screenshot
{
	[Serializable]
	public class ScreenshotBatch
	{
		public bool m_Active;
		public string m_Name;
		public List<ScreenshotProcess> m_PreProcess;
		public List<ScreenshotProcess> m_PostProcess;
	}
}
