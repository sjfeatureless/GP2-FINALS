using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBullet : MonoBehaviour
{
    public Transform firePoint; // Transform representing the point where bullets are spawned
    public GameObject bulletPrefab; // Prefab of the bullet
    public float bulletSpeed = 10f; // Speed of the bullet

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Perform the shoot
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate a bullet at the firePoint position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody2D component of the bullet
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        // Apply forward force to the bullet in 2D
        bulletRb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
}