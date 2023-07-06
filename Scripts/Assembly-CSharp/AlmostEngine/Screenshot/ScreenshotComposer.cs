using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace AlmostEngine.Screenshot
{
	public class ScreenshotComposer : MonoBehaviour
	{
		public bool m_Active;
		public Camera m_Camera;
		public Canvas m_Canvas;
		public List<RawImage> m_Textures;
	}
}
