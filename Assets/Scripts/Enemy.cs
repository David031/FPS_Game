using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject player;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Quaternion targetRotation = Quaternion.LookRotation (player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, 1 * Time.deltaTime);
        transform.position += transform.forward * 1f * Time.deltaTime;
    }
}