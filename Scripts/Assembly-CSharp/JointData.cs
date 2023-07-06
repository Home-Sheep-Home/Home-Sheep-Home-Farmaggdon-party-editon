using System;
using UnityEngine;

[Serializable]
public class JointData
{
	public string itemA;
	public string itemB;
	public Vector2 anchor1;
	public Vector2 anchor2;
	public string type;
	public Vector2 axis;
	public float motorspeed;
	public float motorforce;
	public float upperlimit;
	public float lowerlimit;
}
