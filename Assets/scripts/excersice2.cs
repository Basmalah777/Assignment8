using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class excersice2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Exercise 2: Funny Sentence Generator:
         string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
         string wordsSentence = "";
         int wordCount = 0;
         int wordLength = words.Length;
         while (wordCount < 7) 
         {
             int indexWord = Random.Range(1,wordLength);
             wordsSentence +=words[indexWord] + " ";
             wordCount++;
         }
         Debug.Log("Funny Sentence : "+ wordsSentence);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
