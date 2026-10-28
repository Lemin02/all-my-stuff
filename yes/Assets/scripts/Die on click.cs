using Unity.VisualScripting;
using UnityEngine;

public class Dieonclick : MonoBehaviour
{

    public GameObject Enemywaves;
   
    void Start()
    {
         health += starthealth;
       
    }
    float health = 1;
    bool _mouseover = false;
    public float starthealth = 1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            health -= 1;
        }
        else if (collision.CompareTag("Player"))
        {
            health = 0 ; 
        }
    }




    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0)
        {
           
            Enemywaves.GetComponent<EnemyWaves>()._numberLeft -= 1;
            Destroy(gameObject);
        }
    }
}
