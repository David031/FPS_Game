using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    public GameObject player;
    public NavMeshAgent enemy;
    public Animator animator;
    static int hp = 100;
    void Start () { }

    void Update () {
        if (hp > 0) {
            if (enemy.remainingDistance != Mathf.Infinity && enemy.remainingDistance <= enemy.stoppingDistance) {
                animator.SetBool ("isRunning", false);
                animator.SetBool ("isAttack", true);
                enemy.destination = player.transform.position;
            } else {
                animator.SetBool ("isRunning", true);
                animator.SetBool ("isAttack", false);
                enemy.destination = player.transform.position;
            }
        } else {
            animator.SetBool ("isDying", true);
            animator.SetBool ("isRunning", false);
            animator.SetBool ("isAttack", false);
            Destroy (gameObject, 0.6f);
        }

    }
}