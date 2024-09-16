using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    int collisionCount = 0;
    private void OnCollisionEnter(Collision other) {
        collisionCount++;
        Debug.Log("You have collided with the wall " + collisionCount + " times");
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
