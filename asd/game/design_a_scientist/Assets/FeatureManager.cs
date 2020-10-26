using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class FeatureManager : MonoBehaviour
{

    public List<Feature> features;
    public int currFeature;

    void OnEnable()
    {
        LoadFeatures();    
    }

    void OnDisable()
    {
        SaveFeatures();
    }

    void LoadFeatures()
    {
        features = new List<Feature>();
        features.Add(new Feature("Hair", GameObject.Find("Hair").GetComponent<SpriteRenderer>()));
    }

    void SaveFeatures()
    {

    }

    public void SetCurrent(int index)
    {
        if (features == null)
            return;
        currFeature = index;
    }

    public void NextChoice()
    {
        if (features == null)
            return;
        features[currFeature].currIndex++;
    }

    public void PreviousChoice()
    {
        if (features == null)
            return;
        features[currFeature].currIndex--;
    }
}

[System.Serializable]
public class Feature
{
    public string ID;
    public int currIndex;
    public Sprite[] choices;
    public SpriteRenderer renderer;

    public Feature(string id, SpriteRenderer rend)
    {
        ID = id;
        renderer = rend;
        UpdateFeature();
    }

    public void UpdateFeature()
    {
        choices = Resources.LoadAll<Sprite>("Textures/" + ID);

        if (choices == null || renderer == null)
            return;

        if (currIndex < 0)
            currIndex = choices.Length - 1;
        if (currIndex >= choices.Length)
            currIndex = 0;

        renderer.sprite = choices[currIndex];
    }
}