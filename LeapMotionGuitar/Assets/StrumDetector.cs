using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrumDetector : MonoBehaviour
{

    public GuitarControllerMain controller;

    //Detect collisions between the GameObjects with Colliders attached
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "TriggerCollider") {
            Debug.Log("Guitar strum was detected");
            controller.strumGuitarStrings();
        }
    }
}
