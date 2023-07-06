using UnityEngine;
using UnityEngine.UI;

public class Menu_StartScreen : AppScreen
{
	public RectTransform backgroundMovementRoot;
	public Image logoImage;
	public Button startButton;
	public Sprite startButtonDefaultSprite;
	public Sprite startButtonSelectedSprite;
	public RectTransform silouetteImageRT;
	public RectTransform floorRoot;
	public Vector2 silouetteOffset;
	public Vector2 silouetteTargetPos;
	public Vector2 floorOffset;
	public Vector2 floorTargetPos;
	public string[] logoKeys;
	public Sprite[] logoSprites;
	public BaaEffect baaEffectPrefab;
	public Vector3 baaEffectSpawnPos;
}
