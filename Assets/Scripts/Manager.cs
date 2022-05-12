using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum MyScene
{
    Scene1,
    Scene2,
    Scene3
}

public class Manager : MonoBehaviour
{
    public void SwitchTheScene(int x)
    {
        SceneManager.LoadScene(x);
    }

   
} 
