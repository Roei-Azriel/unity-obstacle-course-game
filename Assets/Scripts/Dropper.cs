using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mashrenderer; // משתנה חדש כרגע null מסוג mashrenderer 
    Rigidbody rigidbody; // משתנה חדש שכרגע null מסוג rigidbody 
    [SerializeField] float drop_time = 3f;


    // Start is called before the first frame update
    void Start()
    {
        mashrenderer = GetComponent<MeshRenderer>(); // נגדיר את המשתנה עם הפרמטר שאנחנו רוצים באמצעות קריאה בgetcomponent
        mashrenderer.enabled = false; // נהפוך לfalse בהתחלה 

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time > drop_time) // אחרי הזמן שנרצה נחליף בחזרה לtrue. ובעצם נחזיר את הגרוויטי והנראות של האובייקט.    gravity - כבידה ,   mashrenderer - נראות
       {
          GetComponent<Renderer>().enabled = true;  
          rigidbody.useGravity = true;
       }
    }
}
