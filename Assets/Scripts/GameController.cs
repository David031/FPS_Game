using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static int playerHP;
    public GameObject enemy;
    public static int score;
    public static int killCount;
    float timer;
    public static bool isGameEnd;
    void Start () {
        isGameEnd = false;
        timer = 0;
        score = 0;
        killCount = 0;
        playerHP = 100;
    }

    void Update () {
        timer += Time.deltaTime;
        if (timer > 10 && !isGameEnd) {
            Instantiate (enemy, new Vector3 (36f, 1f, 0f), Quaternion.Euler (0, 0f, 0));
            Instantiate (enemy, new Vector3 (-36f, 1f, 0f), Quaternion.Euler (0, 0f, 0));
            Instantiate (enemy, new Vector3 (-36f, 1f, -93f), Quaternion.Euler (0, 0f, 0));
            Instantiate (enemy, new Vector3 (36f, 1f, -93f), Quaternion.Euler (0, 0f, 0));
            timer = 0;
        }

        if (playerHP <= 0) {
            isGameEnd = true;
            Menu.gameEnd ();
            Menu.gkillCount = killCount;
            Menu.gscore = score;
            playerHP = 1;
        }
        Debug.Log ("HP " + playerHP);
    }
}