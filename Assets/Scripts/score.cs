using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    Text t;
    int s;
    // Start is called before the first frame update
    void Start () {
        t = GetComponent<Text> ();
        s = Menu.gscore;
        t.text = s.ToString ();
    }

    // Update is called once per frame
    void Update () {
        s = Menu.gscore;
        t.text = s.ToString ();
    }
}