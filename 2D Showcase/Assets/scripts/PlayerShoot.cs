using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private InputActionReference ATK;

    public float shootDelay = 3;
    float timer = 0;

    private void OnEnable()
    {
        ATK.action.performed += AtkPressed;
    }

    private void OnDisable()
    {
        ATK.action.performed -= AtkPressed;
    }
    private void AtkPressed(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (ATK.action.inProgress)

        {
            if (timer > shootDelay)
            {
                timer = 0f;
                Debug.Log("PEW PEW");
                //when I push the attack button, I want to spawn in a bullet
                //I also want to push the bullet in the direction of the mouse
                //I also want to destroy the bullet after a period of time, so it doesn't live forever
                GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
                //find where the mouse is on the screen
                Vector3 mousePos = Mouse.current.position.ReadValue();
                //need to convert from pixel coordinates to world position in the game
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                mousePos.z = 0;
                //destination - starting position to calculate the vector from the player to the mouse
                Vector3 shootDir = mousePos - transform.position;
                shootDir.Normalize();
                //push the bullet in the direction calculated
                //CHALLENGE:
                //Make it so the bullets go faster, but still maintain a consistent velocity
                //Try to get Enemy Health that will reduce when hit by a bullet
                shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
                Destroy(shot, 10);
            }
        }
        }
    
    
    public float moveSpeed = 2f;
    public GameObject bullet;
    public float bulletSpeed = 10;
    
   
}
