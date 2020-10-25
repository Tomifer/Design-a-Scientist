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
    public bool usesMultipleColorEffects;
    public ColorEffects colorEffect = null;
    public int indexColor = 0;
    public int indexPart = 0;

    void Start(){
        if(usesColorEffects) {
            colorEffect.InitColorSwapTex();
        }
        if(colors.Length > 0) {
            ChangeColor(indexColor);
        }
        ChangePart(indexPart);
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
            if (usesMultipleColorEffects) {
                Color tempColor = colors[i];
                colorEffect.selectColor(250, tempColor);
                if((float)0.03125 < tempColor[0]) {
                    tempColor[0] = tempColor[0] - (float)0.03125;
                }
                if((float)0.03125 < tempColor[1]){
                    tempColor[1] = tempColor[1] - (float)0.03125;
                }
                if((float)0.03125 < tempColor[2]){
                    tempColor[2] = tempColor[2] - (float)0.03125;
                }
                colorEffect.selectColor(242, tempColor);
                if((float)0.0390625 < tempColor[0]) {
                    tempColor[0] = tempColor[0] - (float)0.0390625;
                }
                if((float)0.0390625 < tempColor[1]) {
                    tempColor[1] = tempColor[1] - (float)0.0390625;
                }
                if((float)0.0390625 < tempColor[2]) {
                    tempColor[2] = tempColor[2] - (float)0.0390625;
                }
                colorEffect.selectColor(232, tempColor);
            }
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
