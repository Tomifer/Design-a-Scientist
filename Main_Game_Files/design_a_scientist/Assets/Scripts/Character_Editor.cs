using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks; 
using UnityEngine;
using UnityEngine.UI;

/**
    Used to manage all of a character's features
    @author Anthony Bulthuis
    @author Thomas Batchelder
*/
public class Character_Editor : MonoBehaviour
{
    //A list of all of the features
    public TotalFeatureEditor[] features;
    //The body editor
    public BodyEditor body;
    //The pants used
    public SpriteRenderer pant;
    //If the pants are tucked
    public bool tucked = false;
    //The tick used to indicate that the pants are tucked
    public GameObject tick;
    //The glasses
    public GameObject glasses;
    //The tick used to indicate that there are glasses
    public GameObject tick1;
    //If there are glasses on
    public bool glassesOn = false;
    //The feature selected for editing
    int featureIndex = 0;
    //If this is for the scientist avatar as opposed the the user's avatar
    public bool forAvatar;
    //The save data
    public SaveData save;

    /**
        Exports all the data to save data
    */
    public void storeData(){
        if(forAvatar){
            SaveData.avatar_hair = features[0].getIndexPart();
            SaveData.avatar_hair_color = features[0].getIndexColor();
            SaveData.avatar_eyes = features[1].getIndexPart();
            SaveData.avatar_eyes_color = features[1].getIndexColor();
            SaveData.avatar_mouth = features[2].getIndexPart();
            SaveData.avatar_skinColor = body.getIndexSkinColor();
            SaveData.avatar_shirt = features[3].getIndexPart();
            SaveData.avatar_shirt_color = features[3].getIndexColor();
            SaveData.avatar_pant = features[4].getIndexPart();
            SaveData.avatar_pant_color = features[4].getIndexColor();
            SaveData.avatar_shoe = features[5].getIndexPart();
            SaveData.avatar_shoe_color = features[5].getIndexColor();
            SaveData.avatar_tucked = tucked.ToString();
            SaveData.avatar_glasses = glassesOn.ToString();
            save.moveAvatarCreater();
        } else {
            SaveData.par_hair = features[0].getIndexPart();
            SaveData.par_hair_color = features[0].getIndexColor();
            SaveData.par_eyes = features[1].getIndexPart();
            SaveData.par_eyes_color = features[1].getIndexColor();
            SaveData.par_mouth = features[2].getIndexPart();
            SaveData.par_skinColor = body.getIndexSkinColor();
            SaveData.par_shirt = features[3].getIndexPart();
            SaveData.par_shirt_color = features[3].getIndexColor();
            SaveData.par_pant = features[4].getIndexPart();
            SaveData.par_pant_color = features[4].getIndexColor();
            SaveData.par_shoe = features[5].getIndexPart();
            SaveData.par_shoe_color = features[5].getIndexColor();
            SaveData.par_tucked = tucked.ToString();
            SaveData.par_glasses = glassesOn.ToString();
            save.moveParCreater();
        }
    }

    /**
        Sets the feature index
        @intput The index of the desired feature
    */
    public void setFeatureIndex(int index){
        featureIndex = index;
    }

    /**
        Changes the feature's part
        @intput The index of the desired feature's part
    */
    public void partChange(int index){
        features[featureIndex].ChangePart(index);
    }

    /**
        Changes the feature's color
        @intput The index of the desired feature's color
    */
    public void colorChange(int index){
        features[featureIndex].ChangeColor(index);
    }

    /**
        Changes the head effect
        @input The index of the desired head effect
    */
    public void changeHeadEffect(int i)
    {
        body.ChangeHeadEffect(i);
    }

    /**
        Changes the character's skin color
        @input The index of the desired skin color
    */
    public void changeSkinColor(int i)
    {
        body.ChangeSkinColor(i);
    }

    /**
        Tucks the shirt if it is untucked and untucks the shirt if it is tucked
    */
    public void tuck(){
        if(tucked){
            tucked = false;
            tick.SetActive(false);
            pant.sortingOrder = 6;
        } else {
            tucked = true;
            tick.SetActive(true);
            pant.sortingOrder = 8;
        }
    }

    /**
        Puts on the glasses if it they are not on and takes off the glasses if they are on
    */
    public void toggleGlasses(){
        if(glassesOn){
            glassesOn = false;
            tick1.SetActive(false);
            glasses.SetActive(false);
        } else {
            glassesOn = true;
            tick1.SetActive(true);
            glasses.SetActive(true);
        }
    }
}
