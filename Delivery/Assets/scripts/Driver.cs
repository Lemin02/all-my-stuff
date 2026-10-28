using Unity.VisualScripting;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class Driver : MonoBehaviour
{
    [SerializeField] float _steerSpeed = 200f;
    [SerializeField] float _currentSpeed = 20f;
    [SerializeField] float _boostSpeed = 10f;
    [SerializeField] float _regularSpeed = 5f;

    [SerializeField] TMP_Text boostText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Boost"))
        {
            _currentSpeed = _boostSpeed;
            boostText.gameObject.SetActive(true);
            Destroy(collision.gameObject,0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _currentSpeed = _regularSpeed;
        boostText.gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boostText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float steer = 0;
        float move = 0;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            move = -1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }
        
        float _moveAmount = move * _currentSpeed * Time.deltaTime;
        float _steerAmount = steer * _steerSpeed * Time.deltaTime;

        transform.Rotate(0, 0, _steerAmount);
        transform.Translate(0, _moveAmount, 0);

    }
}
