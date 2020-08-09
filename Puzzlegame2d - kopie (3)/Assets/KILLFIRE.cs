using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KILLFIRE : MonoBehaviour
{
    public SpriteRenderer lastlake;
    public GameObject fire;
    public AudioSource feuer;
   

    public void Update()
    {
        
        if (lastlake.color.a >=0.9f )
        {
            feuer.Play();
            fire.SetActive(false);
            Invoke("Destroywater", 0.33f);
            Invoke("endlevel", 2f);
        }

     
    }
    public void Destroywater()
    {
        lastlake.color = new Color(1, 1, 1, 0);
        gameObject.SetActive(false);
    }
    public void endlevel()
    {
        SceneManager.LoadScene(4);
    }
}
