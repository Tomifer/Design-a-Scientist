using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Allows you to select a certain color in an image and change it to another
    @author Anthony Bulthuis
    @author Thomas Batchelder
*/
public class ColorEffects : MonoBehaviour
{
    //The color swap texture
    Texture2D mColorSwapTex;
    //The curent sprite renderer
    SpriteRenderer mSpriteRenderer;
    //The colors
    Color[] mSpriteColors;

    /**
        Initializes things
    */
    void Start()
    {
        InitColorSwapTex();
    }

    /**
        Prepares the color swap texture
    */
    public void InitColorSwapTex()
    {
        mSpriteRenderer = GetComponent<SpriteRenderer>();
        Texture2D colorSwapTex = new Texture2D(256, 1, TextureFormat.RGBA32, false, false);
        colorSwapTex.filterMode = FilterMode.Point;
    
        for (int i = 0; i < colorSwapTex.width; ++i)
            colorSwapTex.SetPixel(i, 0, new Color(0.0f, 0.0f, 0.0f, 0.0f));
    
        colorSwapTex.Apply();
    
        mSpriteRenderer.material.SetTexture("_SwapTex", colorSwapTex);
    
        mSpriteColors = new Color[colorSwapTex.width];
        mColorSwapTex = colorSwapTex;
    }

    /**
        Swaps the color with the color at the index
        @input index The index of the color to swap to
        @input color The color you are swapping out
    */
    public void SwapColor(int index, Color color)
    {
        mSpriteColors[(int)index] = color;
        mColorSwapTex.SetPixel((int)index, 0, color);
    }

    /**
        Selects a new color to swap out
        @input The new color
    */
    public void selectColor(Color newColor)
    {
        if(newColor != null){
            SwapColor(51, newColor);
            mColorSwapTex.Apply();
        }
    }

    /**
        Selects a color
        @input rValue The r value of the color to select
        @input newColor The new color to set it to
    */
    public void selectColor(int rValue, Color newColor)
    {
        if(newColor != null){
            SwapColor(rValue, newColor);
            mColorSwapTex.Apply();
        }
    }
}
