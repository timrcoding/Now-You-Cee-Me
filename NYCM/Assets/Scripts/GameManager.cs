using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<TextAsset> indexTexts;
    public List<TextAsset> contentsTexts;

    [SerializeField]
    private GameObject indexObject;
    [SerializeField]
    private GameObject contentsObject;


    void Start()
    {
        instance = this;    
    }

    public void createIndexPage(int i)
    {
        GameObject obj = Instantiate(indexObject, transform.position, transform.rotation);
    }
}
