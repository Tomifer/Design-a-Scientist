using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Used to change the skin color and cycle between head effects
    @author Anthony Bulthuis
    @author Thomas Batchelder
*/
public class BodyEditor : MonoBehaviour
{
    //The current head effect
    public TotalFeatureEditor headEffect;
    //An array of the character's body parts
    public SpriteRenderer[] bodyParts;
    //The index of the current skin color
    public int indexSkinColor;
    //A list of the skin colors
    public Color[] colors;

    /**
        Upon starting up, the sprite will be set to the first skin color
    */
    void Start()
    {
        headEffect.colors = colors;
        ChangeSkinColor(0);
    }

    /**
        Changes the head effect
        @input The index of the desired head effect
    */
    public void ChangeHeadEffect(int i)
    {
        headEffect.ChangePart(i);
    }

    /**
        Changes the skin color
        @input The index of the desired skin color
    */
    public void ChangeSkinColor(int i)
    {
        headEffect.ChangeColor(i);
        indexSkinColor = i;
        for(int p = 0; p < bodyParts.Length; p++) {
            bodyParts[p].color = colors[i];
        }
    }

    /**
        Gets the index of the current head effect
        @output The current head effect's index
    */
    public int getIndexHeadEffect() {
        return headEffect.getIndexPart();
    }

    /**
        Gets the index of the skin color
        @output The current skin color's index
    */
    public int getIndexSkinColor() {
        return indexSkinColor;
    }
}
