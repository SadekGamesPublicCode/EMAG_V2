using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneMN : MonoBehaviour
{
    //Variables
    sbyte tutotPresstime = 0;

    //Objects
    StringLoadSC stringsLoad = new StringLoadSC();

    Text textTuto;
    void Start()
    {

    }

    private void LoadTutorialStrings()
    {
        for (int i = 0; i <= 8; i++)
        {
            
        }
    }

    public void ShowTutotorial()
    {
        tutotPresstime++;
        textTuto = stringsLoad.tuto
    }
}
