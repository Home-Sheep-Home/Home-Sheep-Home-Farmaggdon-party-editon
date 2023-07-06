using UnityEngine.UI;
using UnityEngine;

namespace AlmostEngine.Screenshot.Extra
{
	public class GridGalleryCanvas : ScreenshotGallery
	{
		public GridLayoutGroup m_Grid;
		public RectTransform m_PreviousButton;
		public RectTransform m_NextButton;
		public Text m_PageText;
		public int m_CurrentPage;
	}
}
