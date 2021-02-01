using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
    Ends the game
    @author Anthony Bulthuis
    @author Thomas Batchelder
*/
public class end : MonoBehaviour
{
    /**
        Ends the game
    */
    public void gameTransition() 
    {
        SceneManager.LoadScene (sceneBuildIndex:0);
    }
}
