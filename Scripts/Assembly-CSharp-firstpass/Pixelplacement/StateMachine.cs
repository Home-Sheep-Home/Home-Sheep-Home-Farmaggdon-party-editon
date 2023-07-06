using UnityEngine;
using UnityEngine.Events;

namespace Pixelplacement
{
	public class StateMachine : MonoBehaviour
	{
		public GameObject defaultState;
		public GameObject currentState;
		public bool _unityEventsFolded;
		public bool verbose;
		public bool allowReentry;
		public bool returnToDefaultOnDisable;
		public GameObjectEvent OnStateExited;
		public GameObjectEvent OnStateEntered;
		public UnityEvent OnFirstStateEntered;
		public UnityEvent OnFirstStateExited;
		public UnityEvent OnLastStateEntered;
		public UnityEvent OnLastStateExited;
	}
}
