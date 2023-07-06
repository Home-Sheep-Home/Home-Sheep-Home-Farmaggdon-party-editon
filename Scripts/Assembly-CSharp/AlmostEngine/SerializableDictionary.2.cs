using System;
using System.Collections.Generic;
using UnityEngine;

namespace AlmostEngine
{
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>
	{
		[SerializeField]
		public new List<TKey> keys;
		[SerializeField]
		public new List<TValue> values;
		[SerializeField]
		public List<TValue> nulls;
	}
}
