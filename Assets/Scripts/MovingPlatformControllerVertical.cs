using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformControllerVertical : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject PointA;
    public GameObject PointB;
    private Transform currentPoint;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = PointB.transform;
    }

    private void Update()
    {

        // Calculate the distance ratio between the current position and the target position
        float distanceRatio = Mathf.Clamp01(Vector2.Distance(transform.position, currentPoint.position) / 0.5f);

        // Use Vector2.Lerp to smoothly move towards the target position
        rb.velocity = (currentPoint.position - transform.position).normalized * speed * distanceRatio;

        // Check if the object is close to the target point and update the current point accordingly
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.1f)
        {
            if (currentPoint == PointB.transform)
            {
                currentPoint = PointA.transform;
            }
            else
            {
                currentPoint = PointB.transform;
            }
        }
    }
}

