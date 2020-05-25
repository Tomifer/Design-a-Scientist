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
    int featureIndex = 0;

    public void beginDataOutput(){
        StartCoroutine(outputData());
    }


    IEnumerator outputData(){
        bool successful = true;

        WWWForm form = new WWWForm();
        form.AddField("hair", features[0].getIndexPart());
        form.AddField("hair_color", features[0].getIndexColor());
        form.AddField("eyes", features[1].getIndexPart());
        form.AddField("eyes_color", features[1].getIndexColor());
        form.AddField("mouth", features[2].getIndexPart());
        form.AddField("headEffect", body.getIndexHeadEffect());
        form.AddField("skinColor", body.getIndexSkinColor());
        string date = System.DateTime.Now.ToString();
        form.AddField("date", date);

        //This url will likely need to be updated
        WWW www = new WWW("http://localhost/PHP/fromunity.php", form);
        
        yield return www;
        if (www.error != null)
        {
            successful = false;
        } else {
            Debug.Log(www.text);
            successful = true;
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
}
