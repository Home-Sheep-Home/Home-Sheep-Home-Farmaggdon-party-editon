using System;
using UnityEngine;

namespace AlmostEngine.Screenshot
{
	[Serializable]
	public class ScreenshotResolution
	{
		public enum Orientation
		{
			LANDSCAPE = 0,
			PORTRAIT = 1,
		}

		public bool m_Active;
		public int m_Width;
		public int m_Height;
		public float m_Scale;
		public Orientation m_Orientation;
		public string m_ResolutionName;
		public string m_Category;
		public int m_PPI;
		public int m_ForcedUnityPPI;
		public Canvas m_DeviceCanvas;
		public string m_Ratio;
		public string m_FileName;
		public bool m_IgnoreOrientation;
	}
}
