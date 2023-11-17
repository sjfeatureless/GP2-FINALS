using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    public GameObject[] fragments; // Prefabs of broken pieces

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
        {
            Break();
        }
    }

    void Break()
    {
        Destroy(gameObject);
    }
}
