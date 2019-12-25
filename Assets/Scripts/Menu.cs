using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public void gameStart(){
        SceneManager.LoadScene(1);
    }
    public void gameQuit(){
        Application.Quit();
    }
}
