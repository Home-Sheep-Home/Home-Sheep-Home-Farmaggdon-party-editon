using UnityEngine;
using System.Collections.Generic;

public class Crusher : MonoBehaviour
{
	public float SlamHeight;
	public float RestHeight;
	public int ChangeToMediumAfterXCrushes;
	public int ChangeToHardAfterXCrushes;
	public int SpecialCrushEveryXCrushes;
	[SerializeField]
	private float StartingCrusherSpeed;
	[SerializeField]
	private float SpeedIncreaseAfterCrush;
	[SerializeField]
	private float CrusherSpeedLimit;
	public List<CrusherHeadPreset> crusherHeadPresetsEasy;
	public List<CrusherHeadPreset> crusherHeadPresetsMedium;
	public List<CrusherHeadPreset> crusherHeadPresetsHard;
	public CrusherShake CrusherShake;
	public CrusherActions CrusherActions;
	public List<CrusherHeadPreset> currentPresetList;
}
