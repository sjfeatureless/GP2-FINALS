using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 5;

    void OnTriggerEnter2D(Collider2D hitInfo){
        Wall wall =hitInfo.GetComponent<Wall>();
        if(wall !=null){
            wall.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}