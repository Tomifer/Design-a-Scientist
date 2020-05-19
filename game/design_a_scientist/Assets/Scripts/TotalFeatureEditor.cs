using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalFeatureEditor : MonoBehaviour
{
    public SpriteRenderer part;
    public Sprite[] parts;
    public Color[] colors;
    public int indexColor = 0;
    public int indexPart = 0;

    void Start(){
        ChangeColor(0);
        ChangePart(0);
    }

    public void ChangePart(int i)
    {
        part.sprite = parts[i];
        indexColor = i;
    }

    public void ChangeColor(int i)
    {
        part.color = colors[i];
        indexPart = i;
    }

    public int getIndexPart() {
        return indexPart;
    }

    public int getIndexColor() {
        return indexColor;
    }
}
