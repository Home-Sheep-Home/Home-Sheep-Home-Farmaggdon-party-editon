using UnityEngine;
using System.Collections.Generic;

public class TippingObjectsSounds : MonoBehaviour
{
	public List<Rigidbody2D> bodies;
	public string tippingSoundID;
	public float minAngularVelocityForSound;
	public float maxAngularVelocityForSound;
}
