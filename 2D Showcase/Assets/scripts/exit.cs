using UnityEngine;
using UnityEngine.SceneManagement;
public class exit : MonoBehaviour
{
    public int nextlevel = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextlevel);
        }
    }
}
