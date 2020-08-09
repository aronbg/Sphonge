using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLetters : MonoBehaviour
{

    bool stopgrow = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown)
        {
            StartCoroutine(Growing(true));
        }
        else
        {
            StartCoroutine(Growing(false));
        }
     
       

    }
    IEnumerator Growing(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1.2f; i >= 0.8f; i -= Time.deltaTime )
            {
                // set color with i as alpha
                gameObject.transform.localScale = new Vector3(i, i, i);

                yield return null;
            
            }
        }
        //fade from transparent to opaque
        if (!fadeAway)
        {
            // loop over 1 second
            for (float i = 0.8f; i <= 1.2f; i += Time.deltaTime )
            {
                // set color with i as alpha
                gameObject.transform.localScale = new Vector3(i, i, i);
                yield return null;
                
            }
        }
    }
}
