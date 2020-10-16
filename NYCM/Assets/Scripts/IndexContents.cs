using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IndexContents : MonoBehaviour
{
    [SerializeField]
    private TextAsset indexText;
    [SerializeField]
    private List<string> indexContents;

    //GENERAL
    [SerializeField]
    private GameObject headlineAndTopic;
    [SerializeField]
    private GameObject pageContents;

    //PAGE CONTENTS
    [SerializeField]
    private TextAsset contentsText;
    [SerializeField]
    private List<string> pageText;

    //TOPIC & HEADLINE
    [SerializeField]
    private TextMeshProUGUI topic;
    [SerializeField]
    private TextMeshProUGUI[] headline;
    [SerializeField]
    private TextMeshProUGUI[] indexNumber;

    //PAGE CONTENTS
    [SerializeField]
    private TextMeshProUGUI pageContentsText;

    
    //SETS BASE NUMBER FOR PAGES
    public int pageBaseNumber;
    void Start()
    {
        setToText();
        setTopicAndHeadlines();
        setIndexNumbers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setToText()
    {
        indexContents = new List<string>(indexText.text.Split('\n'));
        pageText = new List<string>(contentsText.text.Split('\n'));
    }

    void setTopicAndHeadlines()
    {
        topic.text = indexContents[0];

        for(int i = 1; i < indexContents.Count; i++)
        {
            headline[i-1].text = indexContents[i];
        }

    }

    void setIndexNumbers()
    {
        for(int i = 0; i < indexNumber.Length; i++)
        {
            indexNumber[i].text = (pageBaseNumber + i).ToString();
        }
    }
    
    

}
