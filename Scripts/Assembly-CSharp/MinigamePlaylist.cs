using UnityEngine;
using System.Collections.Generic;

public class MinigamePlaylist : MonoBehaviour
{
	[SerializeField]
	private PartyGameConfiguration.PartyGames[] minigamesArray;
	public List<PartyGameConfiguration.PartyGames> minigamesInRotation;
}
