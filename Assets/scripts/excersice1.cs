using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class excersice1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Exercise 1: Number Generator:
       while (true)
       {
            int random_number = Random.Range(1,21);
            if (random_number == 5 )
            {
                continue;
            }

            Debug.Log(random_number); 

            if (random_number == 15)
            {
                break;
            }
            //print 15 and exist the loop if the random_number = 15
       }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
