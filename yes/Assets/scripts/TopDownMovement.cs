using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class TopDownMovement : MonoBehaviour
{
   



    //first we need to get the user unput 
    //then we need to push the player in the direction of the input
    public float moveSpeed = 2f;

    public void OnMove(InputValue value)
    {

        //Vector2 is a special variable meant to store 2 floats (x, y)
        Vector2 moveDir = value.Get<Vector2>();
        GetComponent<Rigidbody2D>().linearVelocity = moveSpeed * Time.deltaTime * moveDir;
        

    }
    
    
}






    





