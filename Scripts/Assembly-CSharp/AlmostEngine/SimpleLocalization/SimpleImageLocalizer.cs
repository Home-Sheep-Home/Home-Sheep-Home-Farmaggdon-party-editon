using System;
using AlmostEngine;
using UnityEngine;

namespace AlmostEngine.SimpleLocalization
{
	public class SimpleImageLocalizer : ISimpleLocalizer
	{
		[Serializable]
		public class Localization : SerializableDictionary<string, Texture>
		{
		}

		public Texture m_OriginalTexture;
		public Localization m_Localisations;
	}
}
