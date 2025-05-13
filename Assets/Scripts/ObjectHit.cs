using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) { // פונקציה שאומרת שמתי האובייקט שקיבל את הפונקציה מתנגש באובייקט אחר 
        if(other.gameObject.tag == "Player"){
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit"; // אם לא רשמנו לאיזה אובייקט אנחנו רוצים - אז זה יהיה אוטומטי לאובייקט שהופעל עליו הפונקציה. שמחזיק את הסקריפט
        }
   }
}
