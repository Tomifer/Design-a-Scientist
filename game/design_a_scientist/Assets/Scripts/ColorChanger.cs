using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public SpriteRenderer body;

    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;

    public int whatColor = 1;

    void Update()
    {
        if (whatColor == 1)
        {
            body.color = color1;
        }
        else if (whatColor == 2)
        {
            body.color = color2;
        }
        else if (whatColor == 3)
        {
            body.color = color3;
        }
        else if (whatColor == 4)
        {
            body.color = color4;
        }
    }

    public void ChangeColor1()
    {
        whatColor = 1;
    }

    public void ChangeColor2()
    {
        whatColor = 2;
    }

    public void ChangeColor3()
    {
        whatColor = 3;
    }

    public void ChangeColor4()
    {
        whatColor = 4;
    }

}
