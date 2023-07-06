using UnityEngine;
using UnityEngine.UI;

public class LocaliseText : MonoBehaviour
{
	public enum AddBehaviour
	{
		Append = 0,
		Prepend = 1,
	}

	public Text text;
	public string translationKey;
	public string addText;
	public AddBehaviour addBehaviour;
}
