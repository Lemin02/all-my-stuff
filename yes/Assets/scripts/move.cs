using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class Move : MonoBehaviour
{
    InputAction moveAction;

    private void Start()
    {


        moveAction = InputSystem.actions.FindAction("move");
        Vector2 _moveVector;
        _moveVector = moveAction.ReadValue<Vector2>();
    }
    //first we need to get the user unput 
    //then we need to push the player in the direction of the input
    public float moveSpeed = 2f;

    
    
 
   
    private void Update()

    {
        Vector2 _moveVector;
        _moveVector = moveAction.ReadValue<Vector2>();

        GetComponent<Rigidbody2D>().linearVelocity = _moveVector * moveSpeed;
    }

}












