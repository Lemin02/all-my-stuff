using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float _HP = 10;
    public GameObject Player;
    public GameObject EnemyCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnemyCounter.GetComponent<enemycounter>()._EnemyNum += 1;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            _HP -= 1;
        }
       
    }
    void Update()
    {
        if (_HP <= 0)
        {
            EnemyCounter.GetComponent<enemycounter>()._EnemyNum -= 1;
            Player.GetComponent<PlayerHP>().HP += 1;
            Destroy(gameObject);
        }
    }
}
