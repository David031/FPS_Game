using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {
    public static int gscore;
    public static int gkillCount;
    private void Awake () {
        gscore = 0;
        gkillCount = 0;
        DontDestroyOnLoad (this.gameObject);
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