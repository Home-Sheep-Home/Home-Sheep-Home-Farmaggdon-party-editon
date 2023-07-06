using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class ItemData
{
	public string item;
	public int levelNumber;
	public int sortingOrder;
	public PositionData position;
	public float spriteRotationOffset;
	public string contactNoise;
	public float scaleX;
	public float scaleY;
	public string layer;
	public GoalData goal;
	public string tx;
	public string switchtarget;
	public string switchfunction;
	public string gfxHD;
	public Vector2 regHD;
	public Vector2 anchorHD;
	public string gfxSD;
	public Vector2 regSD;
	public Vector2 anchorSD;
	public float textwidth;
	public float textheight;
	public float width;
	public float height;
	public float color;
	public string text;
	public string font;
	public string align;
	public string leading;
	public float size;
	public float buoyancy;
	public float explosivepower;
	public float magnetForce;
	public float sliderpower;
	public float sliderspeed;
	public List<string> tags;
	public List<Vector2> floatPoints;
	public Vector2 body;
	public Vector2 velocity;
	public float angularVelocity;
	public float mass;
	public float m_I;
	public Vector2 localCenter;
	public float linearDamping;
	public float angularDamping;
	public List<ShapesData> shapes;
}
