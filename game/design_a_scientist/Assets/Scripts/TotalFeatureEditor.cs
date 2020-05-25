using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalFeatureEditor : MonoBehaviour
{
    public SpriteRenderer part;
    public Sprite[] parts;
    public Color[] colors;
    public bool usesColorEffects;
    public ColorEffects colorEffect = null;
    public int indexColor = 0;
    public int indexPart = 0;

    void Start(){
        if(usesColorEffects) {
            colorEffect.InitColorSwapTex();
        }
        if(colors.Length > 0) {
            ChangeColor(0);
        }
        ChangePart(0);
    }

    public TotalFeatureEditor() {

    }

    public void ChangePart(int i)
    {
        part.sprite = parts[i];
        indexPart = i;
        if(usesColorEffects){
            colorEffect.selectColor(colors[indexColor]);
        }
    }

    public void ChangeColor(int i)
    {
        if (usesColorEffects) {
            colorEffect.selectColor(colors[i]);
        } else {
            part.color = colors[i];
        }
        indexColor = i;
    }

    public int getIndexPart() {
        return indexPart;
    }

    public int getIndexColor() {
        return indexColor;
    }
}
