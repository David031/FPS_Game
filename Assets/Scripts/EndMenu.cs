using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndMenu : MonoBehaviour {
    void Start () {
        Screen.lockCursor = false;
    }
    public void gameStart () {
        SceneManager.LoadScene (1);
    }
    public static void gameEnd () {
        SceneManager.LoadScene (2);
    }
    public void gameQuit () {
        Application.Quit ();
    }
}