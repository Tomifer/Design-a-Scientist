using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public RectTransform btnPrefab;

    private FeatureManager manager;
    private Text descText;
    private List<Button> buttons;
    // Start is called before the first frame update
    void Start()
    {
        
        manager = FindObjectOfType<FeatureManager>();
       
        descText = GameObject.Find("Description").GetComponent<Text>();
        GameObject.Find("Previous").GetComponent<Button>().onClick.AddListener(() => manager.PreviousChoice());
        GameObject.Find("Next").GetComponent<Button>().onClick.AddListener(() => manager.NextChoice());
        Debug.Log("Running Start...");
        InitializFeatureButtons();
    }

    void InitializFeatureButtons()
    {
        buttons = new List<Button>();

        float height = btnPrefab.rect.height;
        float width = btnPrefab.rect.width;
        for(int i = 0; i < 2; i++)
        {
            RectTransform temp = Instantiate<RectTransform>(btnPrefab);
            temp.name = i.ToString();
            temp.SetParent(GameObject.Find("Features").GetComponent<RectTransform>());
            temp.localScale = new Vector3(1, 1, 1);
            temp.localPosition = new Vector3(0, 0, 0);
            temp.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, width);
            temp.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, i * height, height);

            Button b = temp.GetComponent<Button>();
            b.onClick.AddListener(() => manager.SetCurrent(int.Parse(temp.name)));
            buttons.Add(b);
        }
    }

    // Update is called once per frame
    void Update()
    {
        descText.text = manager.features[manager.currFeature].ID + " #" + (manager.features[manager.currFeature].currIndex + 1);
    }
}
