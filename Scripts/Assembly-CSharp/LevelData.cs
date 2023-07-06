using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class LevelData
{
	public Vector2 worldboxTL;
	public Vector2 worldboxBR;
	public List<ItemData> items;
	public List<JointData> joints;
	public List<HintData> hints;
}
