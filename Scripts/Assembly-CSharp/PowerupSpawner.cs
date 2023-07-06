using UnityEngine;
using System;

public class PowerupSpawner : MonoBehaviour
{
	[Serializable]
	private class Range
	{
		public float min;
		public float max;
	}

	[SerializeField]
	private Powerup powerupPrefab;
	[SerializeField]
	private float yPosition;
	[SerializeField]
	private Range[] validRanges;
	[SerializeField]
	private float spawnRate;
}
