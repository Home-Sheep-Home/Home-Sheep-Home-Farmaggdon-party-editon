using System;
using UnityEngine;

namespace Pixelplacement
{
	[Serializable]
	public class SplineFollower
	{
		public Transform target;
		public float percentage;
		public bool faceDirection;
	}
}
