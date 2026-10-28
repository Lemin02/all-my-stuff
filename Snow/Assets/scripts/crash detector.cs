using UnityEngine;
using UnityEngine.SceneManagement;

public class crashdetector : MonoBehaviour
{
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    [SerializeField] float _restartDelay = 1f;
    [SerializeField] ParticleSystem crashParticles;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            crashParticles.Play();
            Invoke("ReloadScene", _restartDelay);

        }

        
    }
}