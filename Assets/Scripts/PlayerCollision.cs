﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement; // A reference to our PlayerMovement script

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    private void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false; // Disable the players movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
