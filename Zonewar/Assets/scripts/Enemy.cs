using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int player;


    public GameObject deathEffect;

    public void TakeDamage(int damage) {
        health -= damage;

        if(health <= 0) {
            die();
        }
    }

    void die () {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }



}
