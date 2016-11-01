/*
using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour
{
    void Update()
    {
        // transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
        // Vector3 actual_position = transform.position;
        // transform.Rotate(transform.position * (-(Input.acceleration.x)));
        //  transform.Rotate(transform.position * Input.acceleration.y);
        // transform.Rotate(transform.position * Time.deltaTime * Input.acceleration.z);

        Vector3 dir1 = Vector3.zero;
        Vector3 dir2 = Vector3.zero;


        dir1.x = Input.acceleration.y;
        //dir2.z = Input.acceleration.x;
         dir2.y = Input.acceleration.x;

        //transform.Rotate(dir1); à calibrer
        transform.Rotate(dir2);
    }
}
*/