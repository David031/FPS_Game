using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killCount : MonoBehaviour {
    Text t;
    int s;
    // Start is called before the first frame update
    void Start () {
        t = GetComponent<Text> ();
        s = Menu.gkillCount;
        t.text = s.ToString ();
    }

    // Update is called once per frame
    void Update () {
        s = Menu.gkillCount;
        t.text = s.ToString ();
    }
}