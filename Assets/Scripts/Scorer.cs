using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
   int counter = 0;
   private void OnCollisionEnter(Collision other) { // פונקציה שאומרת שמתי האובייקט שקיבל את הםונקציה מתנגש באובייקט אחר 
        if(other.gameObject.tag != "Hit"){ 
             counter++; 
             Debug.Log("you've bumped into a thing this many times: " + counter);
        }
   }
}
