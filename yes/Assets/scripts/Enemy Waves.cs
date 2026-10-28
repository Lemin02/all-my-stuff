using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class EnemyWaves : MonoBehaviour
{
    int _totalmoney = 0;
  
    int _waveNumber = 0;
    public int _numberLeft = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemy;


    Vector2 origin = Vector2.zero;




    public int _enemyCount = 3;
    void Start()
    {/*
       //wave stuff here
        int _numberSpawned = 0;
   
        for (int i = 1; i <= _enemyCount; i++)
        {
            _numberLeft += 1;
            _numberSpawned += 1;
            Vector2 _randomPosition = origin + Random.insideUnitCircle * 10;
            Instantiate(enemy, _randomPosition,Quaternion.identity);
            Debug.Log("spawned" + _numberSpawned);
            
        }
        Debug.Log("wave spawned! have fun!");
        _enemyCount += 1;

        //money stuff here V
        int _money = 0;
        int _waveNumber = 1;
        for (int i = 1; i <= _waveNumber; i++)
        {
            _money += 10;
        }
        Debug.Log("earned" + _money + "dollars");
 
        _waveNumber += 1;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (_numberLeft <= 0)
        {
            
            
          
            
            //wave stuff here
            int _numberSpawned = 0;
            enemy.GetComponent<Dieonclick>().starthealth = 0;
            for (int i = 1; i <= _enemyCount; i++)
            {
                _numberLeft += 1;
                _numberSpawned += 1;
                Vector2 _randomPosition = origin + Random.insideUnitCircle * 10;
                Instantiate(enemy, _randomPosition, Quaternion.identity);
                Debug.Log("spawned" + _numberSpawned);
                enemy.GetComponent<Dieonclick>().starthealth += 1;

            }
            Debug.Log("wave spawned! have fun!");
            _enemyCount += 1;
            //money V
            int _money = 0;
            
            if (_waveNumber >= 1)
            {
                for (int i = 1; i <= _waveNumber; i++)
                {
                    _money += 10;
                    _totalmoney += 10;
                }
                float _5rounds = _waveNumber / 5;
                Mathf.Floor(_5rounds);
                for (int i=1; i <=_5rounds; i++)
                {
                    _money += 5;
                    _totalmoney += 5;
                }

                 
                Debug.Log("earned $" + _money );
                Debug.Log("you have $" + _totalmoney + " total");
                _money = 0;

            }
            _waveNumber += 1;
        }

        
       
    }
}
