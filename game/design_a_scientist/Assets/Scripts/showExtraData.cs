using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showExtraData : MonoBehaviour
{  
    public GameObject extraData;
    // Start is called before the first frame update
    void Start()
    {
        extraData.SetActive(SaveData.extra_info);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
