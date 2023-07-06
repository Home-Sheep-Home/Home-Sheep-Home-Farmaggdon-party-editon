using UnityEngine;

namespace Pixelplacement
{
	public class Spline : MonoBehaviour
	{
		public Color color;
		public float toolScale;
		public TangentMode defaultTangentMode;
		public SplineDirection direction;
		public bool loop;
		public SplineFollower[] followers;
		[SerializeField]
		private bool _removeRenderers;
		[SerializeField]
		private bool _showVelocityTicks;
		[SerializeField]
		private int _velocityTickCount;
		[SerializeField]
		private float _velocityTickScale;
	}
}
