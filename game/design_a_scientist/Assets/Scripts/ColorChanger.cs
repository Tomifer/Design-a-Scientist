using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public SpriteRenderer body;
    public Color[] colors;

    int index = 0;

    void Start(){
        ChangeColor(0);
    }

    public void ChangeColor(int i)
    {
        body.color = colors[i];
        index = i;
    }

    public int getIndex() {
        return index;
    }

}
