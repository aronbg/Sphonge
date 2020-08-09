using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eventlist : MonoBehaviour
{
   public void startlevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void startlevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void startlevel3()
    {
        SceneManager.LoadScene(3);
    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
