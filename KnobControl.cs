using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnobControl : MonoBehaviour
{
    public float power = 10f;
    public float maxDrag = 5f;
    public Rigidbody2D rb;
    public LineRenderer lr;
    public float minX, maxX;

    Vector3 dragStartPos;
    Vector3 startPosition, driftPosition;
    Touch touch;

    private void Start() {
        //startPosition = transform.position;
    }
    
    private void Update() {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y);
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                DragStart();
            }
            if (touch.phase == TouchPhase.Moved)
            {
                Dragging();
            }
            if (touch.phase == TouchPhase.Ended)
            {
                DragRelease();
            }
        }
    }

    private void FixedUpdate()
    {
        
    }

    void DragStart()
    {
        dragStartPos = Camera.main.ScreenToWorldPoint(touch.position);
        //dragStartPos = touch.position;
        dragStartPos.z = 0f;
        lr.positionCount = 1;
        lr.SetPosition(0, dragStartPos);
    }
    void Dragging()
    {
        Vector3 draggingPos = Camera.main.ScreenToWorldPoint(touch.position);
        //Vector3 draggingPos = touch.position;
        
        draggingPos.z = 0f;
        lr.positionCount = 2;
        lr.SetPosition(1, draggingPos);
    }
    void DragRelease()
    {
        lr.positionCount = 0;

        Vector3 dragReleasePos = Camera.main.ScreenToWorldPoint(touch.position);
        //Vector3 dragReleasePos = touch.position;
        dragReleasePos.z = 0f;

        Vector3 force = dragStartPos - dragReleasePos;
        Vector3 clampForce = Vector3.ClampMagnitude(force, maxDrag) * power;
        rb.AddForce(clampForce, ForceMode2D.Impulse);
    }
}
