using UnityEngine;
using System.Collections;

public class AccelerometerInt2 : MonoBehaviour
{
	void Update()
	{
		float move = Input.acceleration.y + 0.8f;
		transform.Translate(0, 0, move);
	}
}
