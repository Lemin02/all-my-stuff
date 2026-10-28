using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollde : MonoBehaviour
{
    public float _playerHP = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public int Level = 0;
    public int WinLevel = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("he got me");
            _playerHP -= 1;
        }
        else if(collision.CompareTag("Finish"))
        {
            SceneManager.LoadScene(WinLevel);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (_playerHP <= 0)
        SceneManager.LoadScene(Level);
    }
}
