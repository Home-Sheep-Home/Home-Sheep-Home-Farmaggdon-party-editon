using UnityEngine;

public class Vehicle : MonoBehaviour
{
	public enum Model
	{
		Lorry = 0,
		Bus = 1,
		Car = 2,
		Camper = 3,
		BounceCar = 4,
		CrateLorry = 5,
	}

	[SerializeField]
	private bool active;
	public bool startingVehicle;
	public Model vehicleModel;
	public float vehicleSpeed;
	public Transform spawnPoint;
	public Transform nextSpawnPoint;
	public Transform front;
}
