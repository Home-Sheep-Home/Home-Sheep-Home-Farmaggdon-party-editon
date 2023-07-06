using UnityEngine;

public class Farmer : LevelObject
{
	public enum FarmerStates
	{
		startingVan = 0,
		stillStartingVan = 1,
		startingSurprise = 2,
		startingOutburst = 3,
		startingJoy = 4,
		drivingVan = 5,
		onTowtruck = 6,
		stillOnTowtruck = 7,
		towtruckSurprise = 8,
		towtruckOutburst = 9,
		towtruckWait = 10,
		towtruckJoy = 11,
		watchingTelly = 12,
		tellyBroken = 13,
	}

	[SerializeField]
	private FarmerStates startState;
	[SerializeField]
	private FarmerStates state;
}
