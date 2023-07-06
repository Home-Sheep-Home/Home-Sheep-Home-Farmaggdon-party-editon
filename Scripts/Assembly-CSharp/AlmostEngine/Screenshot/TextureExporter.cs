using System;
using UnityEngine;

namespace AlmostEngine.Screenshot
{
	public class TextureExporter
	{
		[Serializable]
		public class ImageFile
		{
			public Texture2D m_Texture;
			public string m_Name;
			public string m_Fullname;
		}

		public enum ImageFileFormat
		{
			PNG = 0,
			JPG = 1,
		}

	}
}
