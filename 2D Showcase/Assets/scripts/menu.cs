using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }
}
