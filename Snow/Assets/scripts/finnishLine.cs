using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class finnishLine : MonoBehaviour
{
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    [SerializeField] float _restartDelay = 1f;
    [SerializeField] ParticleSystem finishParticles;
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        int layerIndex = LayerMask.NameToLayer("Player");

        if (collision.gameObject.layer == layerIndex)
        {
            finishParticles.Play();
            Invoke("ReloadScene", _restartDelay);
        } 

       
    }
}
