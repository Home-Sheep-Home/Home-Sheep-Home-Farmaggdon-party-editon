using System;
using AlmostEngine;

namespace AlmostEngine.SimpleLocalization
{
	public class SimpleTextLocalizer : ISimpleLocalizer
	{
		[Serializable]
		public class Localization : SerializableDictionary<string, string>
		{
		}

		public string m_OriginalText;
		public Localization m_Localisations;
	}
}
