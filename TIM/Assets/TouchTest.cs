using UnityEngine;
using System.Collections;


public class TouchTest : MonoBehaviour
{
    void Update()
    {
        Touch myTouch = Input.GetTouch(0);

        Touch[] myTouches = Input.touches;
        if (Input.touchCount > 0)
        {
            transform.Translate(0, 0, 0.2f);
        }

    }
}