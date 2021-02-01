using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Allows you to flop through the tutorial slides
    @author Anthony Bulthuis
    @author Thomas Batchelder
*/
public class TutorialSlide : MonoBehaviour
{   
    //The renderer holding the slide
    public SpriteRenderer screen;
    //The diffrent slides in the tutorial
    public Sprite[] screens;
    //The current slide
    public int index = 0;

    /**
        Start is called before the first frame update
    */
    void Start()
    {
        screen.sprite = screens[index];
    }

    /**
        Navigates to the left one slide
    */
    public void left()
    {
        index--;
        if (index < 0)
            index = (screens.Length - 1);
        screen.sprite = screens[index];
    }

    /**
        Navigates to the right one slide
    */
    public void right()
    {
        index++;
        if (index >= screens.Length)
            index = 0;
        screen.sprite = screens[index];
    }
}
