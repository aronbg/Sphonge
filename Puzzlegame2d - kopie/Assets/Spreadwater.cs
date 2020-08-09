using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spreadwater : MonoBehaviour
{
    public bool lakevisible;
    public static int watersize;
    public SpriteRenderer waterlake;
  

    // Start is called before the first frame update


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (lakevisible == true)
        {
            watersize = watersize + 1;
            StartCoroutine(FadeImage(true));
                 waterlake.color = new Color(1, 1, 1, 0);
            lakevisible = false;

            Debug.Log(watersize);
        }

    }
    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                waterlake.color = new Color(1, 1, 1, i);
                yield return null;
               // fadeAway = false;
            }
        }
        //fade from transparent to opaque
        if (!fadeAway)
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                waterlake.color = new Color(1, 1, 1, i);
                yield return null;
                //fadeAway = true;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (lakevisible == false && watersize > 0)
        {
            Debug.Log("helleu");
            if (Input.GetMouseButtonDown(0))
            {
                watersize -= 1;
                
                StartCoroutine(FadeImage(false));
                //waterlake.color = new Color(1, 1, 1, 1);
                lakevisible = true;
                Debug.Log(watersize);
            }

        }
    }
   
   

}


