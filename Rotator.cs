using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float moveSpeed;
    float randomSeconds;

    void Start()
    {
        moveSpeed = Random.Range(-30, 30);
    }
    void FixedUpdate()
    {
        //StartCoroutine(RandomRotate());
        transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * moveSpeed);
    }

    IEnumerator RandomRotate()
    {
        StartCoroutine(RandomTime());
        yield return new WaitForSeconds(2f);
        moveSpeed = Random.Range(-30f, 30f); 
        transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * moveSpeed); 
        
    }
    IEnumerator RandomTime()
    { 
        randomSeconds = Random.Range(2f, 10f); 
        yield return new WaitForSeconds(randomSeconds); 
    }
}
