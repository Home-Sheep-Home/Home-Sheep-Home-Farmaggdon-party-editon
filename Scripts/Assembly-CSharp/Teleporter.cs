using UnityEngine;
using System.Collections.Generic;

public class Teleporter : LevelObject
{
	public enum Label
	{
		idle = 0,
		loaded = 1,
		overloaded = 2,
		reset = 3,
	}

	public Sprite idle;
	public Sprite loaded;
	public Sprite overloaded;
	public Sprite reset;
	public LevelObject touchingThisFrame;
	public LevelObject touching;
	public List<LevelObject> itemsOnTeleporter;
	public bool setLoaded;
	public float touchedFor;
	public Label currentLabel;
}
