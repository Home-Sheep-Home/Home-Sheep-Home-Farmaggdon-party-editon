using UnityEngine;

namespace Pixelplacement
{
	public class SplineAnchor : MonoBehaviour
	{
		public TangentMode tangentMode;
		[SerializeField]
		private Transform _masterTangent;
		[SerializeField]
		private Transform _slaveTangent;
	}
}
