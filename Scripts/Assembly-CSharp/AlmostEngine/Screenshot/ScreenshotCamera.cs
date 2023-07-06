using System;
using UnityEngine;

namespace AlmostEngine.Screenshot
{
	[Serializable]
	public class ScreenshotCamera
	{
		public enum CustomSettings
		{
			KEEP_CAMERA_SETTINGS = 0,
			CUSTOM = 1,
		}

		public bool m_Active;
		public Camera m_Camera;
		public CustomSettings m_ClearSettings;
		public CameraClearFlags m_ClearFlags;
		public Color m_BackgroundColor;
		public CustomSettings m_CullingSettings;
		public int m_CullingMask;
		public CustomSettings m_FOVSettings;
		public float m_FOV;
	}
}
