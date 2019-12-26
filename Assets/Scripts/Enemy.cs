using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    GameObject player;
    NavMeshAgent enemy;
    Animator animator;
    bool die;
    int hp;
    void Start () {
        die = false;
        hp = 100;
        player = GameObject.Find ("FPSController");
        enemy = gameObject.GetComponent<NavMeshAgent> ();
        animator = gameObject.GetComponent<Animator> ();
    }

    void Update () {
        enemy.destination = player.transform.position;

        if (enemy.remainingDistance != Mathf.Infinity && enemy.remainingDistance <= enemy.stoppingDistance && !enemy.pathPending && enemy.remainingDistance != 0) {
            animator.SetBool ("isRunning", false);
            animator.SetBool ("isAttack", true);
            animator.SetBool ("isIdel", false);;
            Debug.Log ("true");
            GameController.playerHP -= 10;
        } else {
            animator.SetBool ("isRunning", true);
            animator.SetBool ("isAttack", false);
            animator.SetBool ("isIdel", false);
        }
        if (GameController.isGameEnd) {
            Destroy (gameObject);
        }
    }
    void OnDestroy () {
        GameController.score += 19 * 18;
        GameController.killCount += 1;
    }
    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Ammo") {
            hp -= 10;
        }
        if (hp <= 0) {
            animator.SetBool ("isDying", true);
            animator.SetBool ("isRunning", false);
            animator.SetBool ("isAttack", false);
            animator.SetBool ("isIdel", false);
            Destroy (gameObject, 0.6f);
        }
    }
}