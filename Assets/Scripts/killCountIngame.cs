using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killCountIngame : MonoBehaviour {
    Text t;
    int s;
    // Start is called before the first frame update
    void Start () {
        t = GetComponent<Text> ();
        s = GameController.killCount;
        t.text = "Kill Count : " + s.ToString ();
    }

    // Update is called once per frame
    void Update () {
        s = GameController.killCount;
        t.text = "Kill Count : " + s.ToString ();
    }
}