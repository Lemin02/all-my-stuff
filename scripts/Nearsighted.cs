using UnityEngine;
using Pathfinding;
using Unity.VisualScripting;
public class Nearsighted : MonoBehaviour
{

    public Transform target;
    IAstarAI ai;
    //you need to add a 2D collider that is a trigger
    //replaced OnEnable with OnTriggerEnter2D
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ai = GetComponent<IAstarAI>();

            if (ai != null) ai.onSearchPath += Update;
        }
    }

    void OnDisable()
    {
        if (ai != null) ai.onSearchPath -= Update;
    }

    //updates the path as long as the 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (target != null && ai != null) ai.destination = target.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ai.destination = ai.position;
        }
    }

    void Update()
    {

    }
}



