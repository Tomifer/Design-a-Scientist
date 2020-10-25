using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSlide : MonoBehaviour
{
    public SpriteRenderer screen;
    public Sprite[] screens;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        screen.sprite = screens[index];
    }

    // Update is called once per frame
    public void left()
    {
        index--;
        if (index < 0)
            index = (screens.Length - 1);
        screen.sprite = screens[index];
    }

    
    public void right()
    {
        index++;
        if (index >= screens.Length)
            index = 0;
        screen.sprite = screens[index];
    }
}
