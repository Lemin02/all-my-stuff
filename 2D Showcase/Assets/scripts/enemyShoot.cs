using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    
    // the bullet object the enemy will shoot
    public GameObject bullet;
    // how fast the bullets are
    public float bulletspeed = 5;

    //how often the enemy shoots
    public float shootDelay = 3;

    //enemy range
    public float enemyRange = 10;

    //find the player
    GameObject player;
    //how much time has passed between shots?
    float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");   
    }

    // Update is called once per frame
    void Update()
    {
        //every X seconds, we want to shoot at the player if they are close
        //dela=change Delta time= the change in time
        timer += Time.deltaTime;

        if (timer>shootDelay)
        {
            //shoot is off cooldown
            Vector3 ShootDir = player.transform.position - transform.position;
            // destination - starting position
            if(ShootDir.magnitude < enemyRange)
            {
                //player is in range
                GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
                //normalize the vector
                timer = 0;

                ShootDir.Normalize();
                //this is important ^

                shot.GetComponent<Rigidbody2D>().linearVelocity = ShootDir * bulletspeed;
                Destroy(shot, 10);

                

            }
        }

        
    }
}
