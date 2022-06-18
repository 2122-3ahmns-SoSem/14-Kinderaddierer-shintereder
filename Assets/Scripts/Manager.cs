using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; 
public enum MyScene
{
    WelcomeScene, 
    Scene1,
    Scene2,
    Scene3,
    EndScene
}

public class Manager : MonoBehaviour
{

    public InputField ipfKidsName;
    public TMP_Text displayKidsName; 

    private SORuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SORuntimeData>("KinderaddiererRuntimeData");

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScene.Scene1)
        {
            displayKidsName.text = runtimeData.nameKid; 
        }
    }

    public void SwitchTheScene(int x)
    {
        Debug.Log("BTN Pressed, get kidsname " + ipfKidsName.text);
        runtimeData.nameKid = ipfKidsName.text; 

        SceneManager.LoadScene(x);

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScene.WelcomeScene)
        {
            displayKidsName.text = runtimeData.nameKid;
        }


    }

    
} 
