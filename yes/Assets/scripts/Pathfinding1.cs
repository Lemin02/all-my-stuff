using Pathfinding;
using Pathfinding.Util;
using System.Net.NetworkInformation;
using UnityEngine;
public class Pathfinding1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform target;

    public float _speed = 200f;
    public float _NextWaypointDistance = 3f;

    Path path;
    int _currentwaypoint = 0;
    bool Reachedendpoint = false;

    Seeker seeker;
    Rigidbody2D rb;


    void Start()
    {
        seeker = GetComponent<Seeker>();

        rb = GetComponent<Rigidbody2D>();

        //makes the path the enemy follows
        seeker.StartPath(rb.position, target.position, OnPathComplete);

        //updates the path repetedly
        InvokeRepeating(nameof(UP),0f,0.5f);
       
       
       
        
       
    }

    //checks if the path is complete
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            _currentwaypoint = 0;

        }
    }
    //updates path (shorttend to UP so i can't misspell it)
    void UP()
    {
        if (seeker.IsDone())
        {
            seeker.StartPath(rb.position, target.position, OnPathComplete);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {



        if (path == null)
        {
            return;

        }
        // stops moving onece it reaches the player

        if (_currentwaypoint >= path.vectorPath.Count)
        {
            Reachedendpoint = true;
        }
        else
        {
            Reachedendpoint = false;
        }
        // finds direction to the next pathV
        Vector2 _direction = ((Vector2)path.vectorPath[_currentwaypoint] - rb.position).normalized;
        //V moves the enemy
        Vector2 _force = _direction * _speed * Time.deltaTime;

        rb.AddForce(_force);
        float _distance = Vector2.Distance(rb.position, path.vectorPath[_currentwaypoint]);
        //checks if the waypoint was reached
        if (_distance < _NextWaypointDistance)
        {
            _currentwaypoint++;
        }
        




    }
}
