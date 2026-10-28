using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //any timr we are looping through 
        for (int i = 0; i <= 10; i++)
        {
          //  Debug.Log(i);

          
            
          
        }
        //adds up numbers from 1-100 into "number"
        int number = 0;
        for (int i = 1; i < 100; i++)
        {
            number += 1;
            
        }
        //Debug.Log(number);

        //I want to know the locations off all enemies in the level
         GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //[] means its an array of the variable (in this case game objects)
        //we can have arrays of different variables, like its, floats, ect
        //an array is a collection of variables of the smae type
        //in this case, the type is GameObject, all of witch are tagged as enemy in the scene

    
       

        for (int i=0; 1< enemies.Length; i++)
        {
            //length is the number of variables stored in the array
            //as long as "i" is less than the number of variables stored in the array
            //this code will continue to run
           // Debug.Log(enemies[i].transform.position);     
        }
       

        //challenge:
        for (int i = 17; i<=192; i++)
        {
            Debug.Log(i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        // do not put a loop in Update()
    
    }
}
