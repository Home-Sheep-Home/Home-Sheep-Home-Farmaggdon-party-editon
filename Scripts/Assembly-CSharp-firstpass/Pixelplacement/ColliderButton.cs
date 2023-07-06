using UnityEngine;
using UnityEngine.UI;

namespace Pixelplacement
{
	public class ColliderButton : MonoBehaviour
	{
		public enum EaseType
		{
			EaseOut = 0,
			EaseOutBack = 1,
		}

		public ColliderButtonEvent OnSelected;
		public ColliderButtonEvent OnDeselected;
		public ColliderButtonEvent OnClick;
		public ColliderButtonEvent OnPressed;
		public ColliderButtonEvent OnReleased;
		public KeyCode[] keyInput;
		public bool _unityEventsFolded;
		public bool _scaleResponseFolded;
		public bool _colorResponseFolded;
		public bool applyColor;
		public bool applyScale;
		public LayerMask collisionLayerMask;
		public Renderer colorRendererTarget;
		public Image colorImageTarget;
		public Color selectedColor;
		public Color pressedColor;
		public Color disabledColor;
		public float colorDuration;
		public Transform scaleTarget;
		public Vector3 normalScale;
		public Vector3 selectedScale;
		public Vector3 pressedScale;
		public float scaleDuration;
		public EaseType scaleEaseType;
		public bool resizeGUIBoxCollider;
		public bool centerGUIBoxCollider;
		public Vector2 guiBoxColliderPadding;
		public bool interactable;
	}
}
