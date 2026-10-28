using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    Rigidbody2D myRigidbody2d;
    [SerializeField] float _torqueAmount = 1f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("move");
        myRigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 _movvevector;
        _movvevector = moveAction.ReadValue<Vector2>();

        if (_movvevector.x < 0)
        {
            myRigidbody2d.AddTorque(_torqueAmount);
        }
        else if (_movvevector.x > 0)
        {
            myRigidbody2d.AddTorque(_torqueAmount * -1f);
        }
    }
}
