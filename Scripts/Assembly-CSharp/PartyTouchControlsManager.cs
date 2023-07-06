using UnityEngine;
using UnityEngine.EventSystems;

public class PartyTouchControlsManager : MonoBehaviour
{
	[SerializeField]
	private UIButton leftButton;
	[SerializeField]
	private UIButton rightButton;
	[SerializeField]
	private UIButton jumpButton;
	public SheepManager sheepManager;
	public PartyUI partyUI;
	public EventSystem eventSystem;
	public GlowAPI hatchGlow;
}
