using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Collision : MonoBehaviour
{


    [SerializeField] float delay = 1f;
    bool _hasPackage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       


        if (collision.CompareTag("Package") && !_hasPackage)
        {
            Debug.Log("yummy icecream :)");
            _hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }

        if (collision.CompareTag("Customer") && _hasPackage)
        {
            Debug.Log("sorry!");
            GetComponent<ParticleSystem>().Stop();
            _hasPackage = false;
            Destroy(collision.gameObject, delay);
        }


    }
}
