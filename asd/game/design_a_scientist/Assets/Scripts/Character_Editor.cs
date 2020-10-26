using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks; 
using UnityEngine;
using UnityEngine.UI;

public class Character_Editor : MonoBehaviour
{
    public TotalFeatureEditor[] features;
    public BodyEditor body;
    public SpriteRenderer pant;
    public GameObject tick;
    public GameObject tick1;
    public GameObject glasses;
    public bool tucked = false;
    public bool glassesOn = false;
    int featureIndex = 0;
    public bool forAvatar;
    public SaveData save;

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


    public void setFeatureIndex(int index){
        featureIndex = index;
    }

    public void partChange(int index){
        features[featureIndex].ChangePart(index);
    }

    public void colorChange(int index){
        features[featureIndex].ChangeColor(index);
    }

    public void changeHeadEffect(int i)
    {
        body.ChangeHeadEffect(i);
    }

    public void changeSkinColor(int i)
    {
        body.ChangeSkinColor(i);
    }

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
