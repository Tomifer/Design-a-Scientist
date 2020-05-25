using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEffects : MonoBehaviour
{
    Texture2D mColorSwapTex;
    SpriteRenderer mSpriteRenderer;
    Color[] mSpriteColors;

    void Start()
    {
        InitColorSwapTex();
    }

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

    public void SwapColor(int index, Color color)
    {
        mSpriteColors[(int)index] = color;
        mColorSwapTex.SetPixel((int)index, 0, color);
    }

    public void selectColor(Color newColor)
    {
        if(newColor != null){
            SwapColor(51, newColor);
            mColorSwapTex.Apply();
        }
    }
}
