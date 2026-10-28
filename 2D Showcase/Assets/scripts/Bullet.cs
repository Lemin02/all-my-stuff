using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string SafeTag = "Enemy";
    //create a new script on the player bullet to DESTROY the player bullet
    //when it hits anything whose tag != (this means NOT equal) to the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(SafeTag))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
    
}
