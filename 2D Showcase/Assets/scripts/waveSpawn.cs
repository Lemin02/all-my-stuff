using UnityEngine;

public class waveSpawn : MonoBehaviour
{
    public GameObject Shooter;
    public GameObject Attacker;
    Vector2 _randomPos = Vector2.zero + Random.insideUnitCircle * 10;
    public int _shooters;
    public int _attackers;

    void Shooty()
    {
        if (_shooters > 0)
        {
            Instantiate(Shooter, _randomPos, Quaternion.identity);
        }
    }

    void Attacky()
    {
        if (_attackers > 0)
        {
            Instantiate(Attacker, _randomPos, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hi");
        if(collision.CompareTag("Player"))
        {
          for (int i = 1; 1<=_shooters; i++)
            {
                Invoke("Shooty", 1);
            }
            for (int i = 1; 1 <= _attackers; i++)
            {
                Invoke("Attacky", 1);
            }
            _attackers = 0;
            _shooters = 0;
        }
    }
   
}

