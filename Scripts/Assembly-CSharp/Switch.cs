using System.Collections.Generic;

public class Switch : LevelObject
{
	public enum OperationType
	{
		boulder = 0,
		reverse = 1,
		rebound = 2,
		stop = 3,
		forward = 4,
		backward = 5,
		field = 6,
		release = 7,
		activate = 8,
		reset = 9,
		launch = 10,
		lights = 11,
		goTo = 12,
		trafficlights = 13,
		credits = 14,
	}

	public bool touched;
	public OperationType switchType;
	public string switchClipValue;
	public string overrideAudioID;
	public bool ignoreTargetCount;
	public List<string> switchTargets;
}
