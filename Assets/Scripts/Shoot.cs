using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject ammo;
    public float speed;
    public float lifeTime;
    public float timeInterval;

    public AudioSource gunfire;

    private float stopWatch = 0.0f;

    void Update () {
        if (Input.GetButton ("Fire1") && stopWatch > timeInterval) {
            gunfire.Play ();
            stopWatch = 0;
            GameObject newAmmo = Instantiate (ammo, transform.position, transform.rotation);
            Rigidbody r = newAmmo.GetComponent<Rigidbody> ();
            r.velocity = -transform.right * speed;
            Destroy (newAmmo, lifeTime);
            // RaycastHit hit;
            // if (Physics.Raycast (transform.position, transform.forward, out hit, 1000.0f, 1 << 8)) {
            //     var hitObj = hit.collider.gameObject;
            //     if (hitObj.tag == "target") {
            //         hitObj.SendMessage ("Explode");
            //     }
            // }
        }
        stopWatch += Time.deltaTime;
    }
}