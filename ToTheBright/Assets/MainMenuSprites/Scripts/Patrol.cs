using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    public Transform[] waypoints;
    public string chooseStart;
    private int waypointIndex= 0;
    public Rigidbody2D rb;

    void Start()
    {
        //this.transform.position = GameObject.Find(chooseStart).transform.position;
        waypointIndex = Random.Range(0, 10);
        transform.position = waypoints[waypointIndex].transform.position;
    }

    void FixedUpdate()
    {
        Vector2 newPosition = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, speed);
        rb.MovePosition(newPosition);
        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex = Random.Range(0, 10);
            Debug.Log(waypointIndex);
        }
    }
}
