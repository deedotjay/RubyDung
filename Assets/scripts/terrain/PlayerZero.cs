using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZero : MonoBehaviour {

    [SerializeField]
    private TerrainController terrainController;

    [SerializeField]
    private float distance = 10;

    private void Update() {
        if (Vector3.Distance(Vector3.zero, transform.position) > distance) {
            terrainController.Level.position -= transform.position;
            transform.position = Vector3.zero;//only necessary if player isn't a child of the level
        }
    }

}