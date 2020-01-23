﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Menu_Script : MonoBehaviour
{
    public void ExitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void StartGame ()
    {
        SceneManager.LoadScene("Game");
    }
}
