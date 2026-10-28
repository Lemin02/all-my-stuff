using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHP : MonoBehaviour
{
    public float HP = 10;
    public int _currentLevel = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            HP -= 0.5f;
            Debug.Log(HP);
        }

        else if (collision.CompareTag("EnemyBullet"))
        {
            HP -= 0.5f;
            Debug.Log(HP);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (HP > 10)
        {
            HP = 10;
        }
        else if (HP <= 0)
        {
            SceneManager.LoadScene(_currentLevel);
        }

    }
}
