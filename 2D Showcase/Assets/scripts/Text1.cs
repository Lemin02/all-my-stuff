using UnityEngine;
using TMPro;
using UnityEngine.Assemblies;
using JetBrains.Annotations;

public class Text : MonoBehaviour
{
    public GameObject Player;
    public TextMeshProUGUI _HP_text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float _currentHp = Player.GetComponent<PlayerHP>().HP;
        _HP_text.text = _currentHp+"/10 HP";
        
    }
}
