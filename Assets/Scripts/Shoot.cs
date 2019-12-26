using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject ammo;
    public GameObject FPSController;
    public float speed;
    public float lifeTime;
    public float timeInterval;

    public AudioSource gunfire;

    private float stopWatch = 0.0f;
    public Animator animator;
    void Update () {
        if (Input.GetButton ("Fire1") && stopWatch > timeInterval) {
            gunfire.Play ();
            stopWatch = 0;

            GameObject newAmmo = Instantiate (ammo, transform.position + new Vector3 (0f, 0.26f, 0f), FPSController.transform.rotation);
            Rigidbody r = newAmmo.GetComponent<Rigidbody> ();
            r.velocity = -transform.right * speed;
            Destroy (newAmmo, lifeTime);
            animator.ResetTrigger ("DoOpen");
            animator.ResetTrigger ("DoReload");
            animator.SetTrigger ("Shoot");
        } else {
            animator.ResetTrigger ("DoOpen");
            animator.ResetTrigger ("DoReload");
            animator.ResetTrigger ("Shoot");
        }
        stopWatch += Time.deltaTime;
    }
}