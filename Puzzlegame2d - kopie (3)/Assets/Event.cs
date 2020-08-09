using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public void Openworldmap()
    {
        Invoke("openworldmapplease",1f);


    }
    public void openworldmapplease()
    {
        SceneManager.LoadScene(4);
    }
    

    public void closegame()
    {
        Application.Quit();
    }
}
