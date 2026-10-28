using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    [SerializeField] float _delay = 1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool _hasPackage = false;
   

        if (collision.CompareTag("Package"))
        {
            Debug.Log("yummy icecream :)");
            _hasPackage = true;
            Destroy(collision.gameObject, _delay);
        }

        if (collision.CompareTag("Customer") && _hasPackage)
        {
            Debug.Log("sorry!");
            _hasPackage = false; 
        }
        
      
    }
}
