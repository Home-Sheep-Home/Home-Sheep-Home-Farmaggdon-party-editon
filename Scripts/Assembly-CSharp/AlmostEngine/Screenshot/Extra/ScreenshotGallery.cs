using UnityEngine;
using AlmostEngine.Screenshot;
using System.Collections.Generic;

namespace AlmostEngine.Screenshot.Extra
{
	public class ScreenshotGallery : MonoBehaviour
	{
		public string m_ScreenshotFolderPath;
		public ScreenshotNameParser.DestinationFolder m_DestinationFolder;
		public GreyboxCanvas m_GreyBox;
		public GameObject m_ImageItemPrefab;
		public List<TextureExporter.ImageFile> m_ImageFiles;
		public List<GameObject> m_ImageInstances;
	}
}
