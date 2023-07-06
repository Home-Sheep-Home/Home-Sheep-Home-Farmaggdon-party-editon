using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class ShapesData
{
	public Vector2 position;
	public string type;
	public float density;
	public float friction;
	public float restitution;
	public float r;
	public bool sensor;
	public List<Vector2> verticies;
}
