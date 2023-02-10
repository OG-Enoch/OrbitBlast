using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPosition;
    private Vector2 offsetVector;
    //public float speed;
    public float minX, maxX;

    // Update is called once per frame
    void Update()
    {
        //Vector2.Lerp(transform.position, playerPosition.position, speed);
        offsetVector = playerPosition.position;
        offsetVector.x = Mathf.Clamp(offsetVector.x, minX, maxX);

        transform.position = offsetVector;
    }
}
