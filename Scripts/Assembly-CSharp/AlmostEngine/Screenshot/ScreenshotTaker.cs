using UnityEngine;

namespace AlmostEngine.Screenshot
{
	public class ScreenshotTaker : MonoBehaviour
	{
		public enum GameViewResizingWaitingMode
		{
			FRAMES = 0,
			TIME = 1,
		}

		public enum CaptureMode
		{
			GAMEVIEW_RESIZING = 0,
			RENDER_TO_TEXTURE = 1,
			FIXED_GAMEVIEW = 2,
		}

		public enum ColorFormat
		{
			RGB = 0,
			RGBA = 1,
		}

		public Texture2D m_Texture;
		public GameViewResizingWaitingMode m_GameViewResizingWaitingMode;
		public float m_GameViewResizingWaitingTime;
		public int m_GameViewResizingWaitingFrames;
	}
}
