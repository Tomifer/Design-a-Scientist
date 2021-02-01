using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
    Handles all of the modification of a feature
    @author Anthony Bulthuis
    @author Thomas Batchelder
*/
public class TotalFeatureEditor : MonoBehaviour
{
    //The sprite renderer associated with the feature
    public SpriteRenderer part;
    //A list of possible parts
    public Sprite[] parts;
    //A list of possible colors
    public Color[] colors;
    //If color effects are used
    public bool usesColorEffects;
    //If multiple color effects are used
    public bool usesMultipleColorEffects;
    //The current color effect
    public ColorEffects colorEffect = null;
    //The index of the current color
    public int indexColor = 0;
    //The index of the current part
    public int indexPart = 0;

    /**
        Begins the feature with the starting values
    */
    void Start(){
        if(usesColorEffects) {
            colorEffect.InitColorSwapTex();
        }
        if(colors.Length > 0) {
            ChangeColor(indexColor);
        }
        ChangePart(indexPart);
    }

    //Creates the object
    public TotalFeatureEditor() {

    }

    /**
        Changes the part
        @input What to change the part to
    */
    public void ChangePart(int i)
    {
        part.sprite = parts[i];
        indexPart = i;
        if(usesColorEffects){
            colorEffect.selectColor(colors[indexColor]);
        }
    }

    /**
        Changes the color
        @input What to change the color to
    */
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

    /**
        Gets the index of the current part
        @return The index of the current part
    */
    public int getIndexPart() {
        return indexPart;
    }

    /**
        Gets the index of the current color
        @return The index of the current color
    */
    public int getIndexColor() {
        return indexColor;
    }
}
