using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyEditor : MonoBehaviour
{
    
    public TotalFeatureEditor headEffect;
    public SpriteRenderer[] bodyParts;
    public int indexSkinColor;
    public Color[] colors;

    void Start()
    {
        headEffect.colors = colors;
        ChangeSkinColor(0);
    }

    public void ChangeHeadEffect(int i)
    {
        headEffect.ChangePart(i);
    }

    public void ChangeSkinColor(int i)
    {
        headEffect.ChangeColor(i);
        for(int p = 0; p < bodyParts.Length; p++) {
            bodyParts[p].color = colors[i];
        }
    }

    public int getIndexHeadEffect() {
        return headEffect.getIndexPart();
    }

    public int getIndexSkinColor() {
        return indexSkinColor;
    }
}
