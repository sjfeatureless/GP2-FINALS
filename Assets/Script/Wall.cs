using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject[] fragments; // Prefabs of broken pieces
    public int health = 5;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
        {
            Break();
        }
    }

    public void TakeDamage (int damage){
        health -= damage;
        if (health <= 0){
            Break();
        }
    }

    void Break()
    {
        Destroy(gameObject);
    }
}
