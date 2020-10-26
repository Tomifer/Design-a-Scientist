using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Menu_Script : MonoBehaviour
{
    public void gameTransition() 
    {
        SceneManager.LoadScene (sceneBuildIndex:1);
    }

    public void gameEnd() 
    {
        Application.Quit();
    }
}
