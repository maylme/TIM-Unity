using UnityEngine;
using System.Collections;


public class TouchInt2 : MonoBehaviour
{
	void Update()
	{
		
		if (Input.touchCount > 0)
		{
			Touch myTouch = Input.GetTouch(0);
			Vector3 dir1 = Vector3.zero;
			float screenWidth = Screen.width;
			dir1.y = (myTouch.position.x - (screenWidth / 2)) * 0.002f;
			transform.Rotate(dir1);
		}

	}
}