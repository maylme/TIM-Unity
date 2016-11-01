using UnityEngine;
using System.Collections;

public class AccelerometerInt1 : MonoBehaviour
{
    void Update()
    {

        Vector3 dir1 = Vector3.zero;
        Vector3 dir2 = Vector3.zero;

        MonoBehaviour.print(Input.acceleration.y);
        dir1.x = Input.acceleration.y;
         dir2.y = Input.acceleration.x * 4;

        //transform.Rotate(dir1); //à calibrer
          transform.Rotate(dir2);
    }
}
