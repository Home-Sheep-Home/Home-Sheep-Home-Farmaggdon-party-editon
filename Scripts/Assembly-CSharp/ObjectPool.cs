using UnityEngine;

public class ObjectPool : MonoBehaviour
{
	public GameObject[] objectPool;
	[SerializeField]
	private bool despawnObject;
	[SerializeField]
	private float yDespawn;
	[SerializeField]
	private bool useLocal;
}
