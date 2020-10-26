using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SaveData : MonoBehaviour
{
    //Navigational data
    public static bool tutorial;
    public static bool making_par;
    public static bool extra_info;

    /*
    0 Main
    1 Par Gender
    2 Par Description
    3 Par Make
    4 Avatar Gender
    5 Avatar Description
    6 Avatar Make
    */

    //Used in describing an Avatar
    public static int avatar_gender = -1;
    public static int avatar_hair = -1;
    public static int avatar_hair_color = -1;
    public static int avatar_eyes = -1;
    public static int avatar_eyes_color = -1;
    public static int avatar_mouth = -1;
    public static int avatar_skinColor = -1;
    public static int avatar_shirt = -1;
    public static int avatar_shirt_color = -1;
    public static int avatar_pant = -1;
    public static int avatar_pant_color = -1;
    public static int avatar_shoe = -1;
    public static int avatar_shoe_color = -1;
    public static String avatar_tucked = "";
    public static String avatar_glasses = "";
    public static String avatar_name = "";
    public static String avatar_description = "";
    
    //Used in describing a participant
    public static int par_gender = -1;
    public static int par_hair = -1;
    public static int par_hair_color = -1;
    public static int par_eyes = -1;
    public static int par_eyes_color = -1;
    public static int par_mouth = -1;
    public static int par_skinColor = -1;
    public static int par_shirt = -1;
    public static int par_shirt_color = -1;
    public static int par_pant = -1;
    public static int par_pant_color = -1;
    public static int par_shoe = -1;
    public static int par_shoe_color = -1;
    public static String par_tucked = "";
    public static String par_glasses = "";
    public static String par_id = "";
    public static String par_name = "";
    public static String par_description = "";

    //Variables used when gathering information
    public Text name;
    public Text id;
    public TextMeshProUGUI  description;
    public Text test;
    public Text test1;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void moveMain()
    {
        StartCoroutine(inputData());
        /*
        if(making_par)
            SceneManager.LoadScene (sceneBuildIndex:1);
        else
            SceneManager.LoadScene (sceneBuildIndex:4);
            */
    } 

    public void moveAvatarGender(int i)
    {
        avatar_gender = i;
        if(tutorial && !making_par)
            SceneManager.LoadScene (sceneBuildIndex:7);
        else
            SceneManager.LoadScene (sceneBuildIndex:6);
    } 
    
    public void moveParGender(int i)
    {
        par_gender = i;
        if(making_par && !tutorial)
            SceneManager.LoadScene (sceneBuildIndex:3);
        else if(making_par && tutorial)
            SceneManager.LoadScene (sceneBuildIndex:7);
        else
            SceneManager.LoadScene (sceneBuildIndex:2);
    }   

    public void moveParDescription()
    {
        par_id = id.text;
        par_name = name.text;
        par_description = description.text;
        if(making_par)
            SceneManager.LoadScene (sceneBuildIndex:4);
        else {
            StartCoroutine(outputData());
            SceneManager.LoadScene (sceneBuildIndex:0);
        }
    }

    public void moveAvatarDescription()
    {
        avatar_name = name.text;
        avatar_description = description.text;
        if(making_par) {
            StartCoroutine(outputData());
            SceneManager.LoadScene (sceneBuildIndex:0);
        } else 
            SceneManager.LoadScene (sceneBuildIndex:1);
    }

    public void moveCreationTutorial()
    {
        if(making_par)
            SceneManager.LoadScene (sceneBuildIndex:3);
        else 
            SceneManager.LoadScene (sceneBuildIndex:6);
    }

    //Don't forget to update save data
    public void moveAvatarCreater()
    {
        SceneManager.LoadScene (sceneBuildIndex:5);
    }

    //Don't forget to update save data
    public void moveParCreater()
    {
        SceneManager.LoadScene (sceneBuildIndex:2);
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator inputData(){
        Debug.Log("Starting Data Input");
        bool successful = true;
        WWWForm form = new WWWForm();
        //This url will likely need to be updated
        WWW www = new WWW("http://107.15.99.155:8080/PHP/fromphp.php", form);
        yield return www;
        test.text = www.text;
        String temp = www.text;
        String[] vals = temp.Split(',');
    
        if (vals[0].Equals("1"))
            tutorial = true;
        else 
            tutorial = false;
        if (vals[1].Equals("1"))
            making_par = true;
        else 
            making_par = false;
        if (vals[2].Equals("1"))
            extra_info = true;
        else 
            extra_info = false;

        if (www.error != null)
        {
            Debug.Log("Failed input");
            successful = false;
        } else {
            Debug.Log("Success");
            successful = true;
        }
        Debug.Log("Finished Data Input");
    }

    IEnumerator outputData(){

        bool successful = true;
        string date = System.DateTime.Now.ToString();
        WWWForm form = new WWWForm();

        avatar_description.Replace(',',' ');
        avatar_name.Replace(',',' ');
        par_description.Replace(',',' ');
        par_name.Replace(',',' ');
        par_id.Replace(',',' ');

        form.AddField("avatar_gender", avatar_gender );
        form.AddField("avatar_hair", avatar_hair );
        form.AddField("avatar_hair_color", avatar_hair_color );
        form.AddField("avatar_eyes", avatar_eyes );
        form.AddField("avatar_eyes_color", avatar_eyes_color );
        form.AddField("avatar_mouth", avatar_mouth );
        form.AddField("avatar_skinColor", avatar_skinColor );
        form.AddField("avatar_shirt", avatar_shirt );
        form.AddField("avatar_shirt_color", avatar_shirt_color );
        form.AddField("avatar_pant", avatar_pant );
        form.AddField("avatar_pant_color", avatar_pant_color );
        form.AddField("avatar_shoe", avatar_shoe );
        form.AddField("avatar_shoe_color", avatar_shoe_color );
        form.AddField("avatar_tucked", avatar_tucked );
        form.AddField("avatar_glasses", avatar_glasses );
        form.AddField("avatar_name", avatar_name );
        form.AddField("avatar_description", avatar_description );

        
        form.AddField("par_gender", par_gender );
        form.AddField("par_hair", par_hair );
        form.AddField("par_hair_color", par_hair_color );
        form.AddField("par_eyes", par_eyes );
        form.AddField("par_eyes_color", par_eyes_color );
        form.AddField("par_mouth", par_mouth );
        form.AddField("par_skinColor", par_skinColor  );
        form.AddField("par_shirt", par_shirt );
        form.AddField("par_shirt_color", par_shirt_color );
        form.AddField("par_pant", par_pant );
        form.AddField("par_pant_color", par_pant_color );
        form.AddField("par_shoe", par_shoe );
        form.AddField("par_shoe_color", par_shoe_color );
        form.AddField("par_tucked", par_tucked );
        form.AddField("par_glasses", par_glasses );
        form.AddField("par_id", par_id );
        form.AddField("par_name", par_name );
        form.AddField("par_description", par_description );

        
        form.AddField("tutorial", tutorial.ToString() );
        form.AddField("making_par", making_par.ToString() );
        form.AddField("extra_info", extra_info.ToString() );
        form.AddField("date", date);

        //This url will likely need to be updated
        WWW www = new WWW("http://107.15.99.155:8080/PHP/fromunity.php", form);
        
        yield return www;
        if (www.error != null)
        {
            successful = false;
        } else {
            Debug.Log(www.text);
            successful = true;
        }
    }

}
