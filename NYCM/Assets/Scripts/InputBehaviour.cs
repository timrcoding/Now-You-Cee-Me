using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class InputBehaviour : MonoBehaviour
{
    //INPUT
    [SerializeField]
    private TMP_InputField input;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            setContentsText();
        }
    }

    void setContentsText()
    {
        char[] num = input.text.ToCharArray() ;
        int digitOne = num[0];
        int digitThree = num[2];

        if (isIndexPage(digitThree))
        {
            GameManager.instance.createIndexPage(num[0]);
        }
        else
        {

        }


    }

    bool isIndexPage(int i)
    {
        if (i  == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
