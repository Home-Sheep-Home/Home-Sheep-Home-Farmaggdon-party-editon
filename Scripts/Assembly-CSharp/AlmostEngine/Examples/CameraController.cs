using UnityEngine;

namespace AlmostEngine.Examples
{
	public class CameraController : MonoBehaviour
	{
		public bool m_MouseLookOnClickOnly;
		public float m_RotationCoeff;
		public float m_TranslationCoeff;
		public float m_TranslationMouseCoeff;
		public float m_TranslationMouseScrollCoeff;
		public Transform m_Head;
	}
}
