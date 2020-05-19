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
    int featureIndex = 0;

    /*
    public void beginDataOutput(){
        StartCoroutine(outputData());
    }
    */

    /*
    IEnumerator outputData(){
        bool successful = true;

        WWWForm form = new WWWForm();
        form.AddField("color", color.getIndex());
        form.AddField("hair", features[0].getIndex());
        form.AddField("shirt", features[1].getIndex());
        form.AddField("item", features[2].getIndex());
        string date = System.DateTime.Now.ToString();
        form.AddField("date", date);
        WWW www = new WWW("http://localhost/PHP/fromunity.php", form);
        
        yield return www;
        if (www.error != null)
        {
            successful = false;
        }
        else 
        {
            Debug.Log(www.text);
            successful = true;
        }
    }
    */

    public void setFeatureIndex(int index){
        featureIndex = index;
    }

    public void partChange(int index){
        features[featureIndex].ChangePart(index);
    }

    public void colorChange(int index){
        features[featureIndex].ChangeColor(index);
    }
}
