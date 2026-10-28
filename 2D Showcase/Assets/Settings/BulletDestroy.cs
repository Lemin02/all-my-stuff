using Unity.Collections;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public string ShootTag;
    //create a new script on the player bullet to DESTROY the player bullet
    //when it hits anything whose tag != (this means NOT equal) to the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != ShootTag)
        {
            Destroy(gameObject);
        }
    }

}
