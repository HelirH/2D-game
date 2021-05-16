using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed;
    public Transform[] Waypoints;
    public int currentPoint;
    public Transform platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        platform.position = Vector3.MoveTowards(platform.position, Waypoints[currentPoint].position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(platform.position, Waypoints[currentPoint].position) < 0.5)
        {
            currentPoint++;
            if (currentPoint >= Waypoints.Length)
            {
                currentPoint = 0;
            }
        }
    }
}