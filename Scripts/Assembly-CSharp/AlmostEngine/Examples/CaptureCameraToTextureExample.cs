using UnityEngine;
using AlmostEngine.Screenshot;
using UnityEngine.UI;

namespace AlmostEngine.Examples
{
	public class CaptureCameraToTextureExample : MonoBehaviour
	{
		public ScreenshotTaker m_ScreenshotTaker;
		public RawImage m_RawImage;
		public Camera m_Camera;
		public int m_Width;
		public int m_Height;
	}
}
