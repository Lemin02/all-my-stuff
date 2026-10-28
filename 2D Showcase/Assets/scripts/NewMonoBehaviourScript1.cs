using UnityEngine;
using TMPro;

public class Text1 : MonoBehaviour
{
    public TextMeshProUGUI _HP_text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _HP_text.text = "10/10";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
