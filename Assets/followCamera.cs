using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour {
    [SerializeField] GameObject thingToFollow;
    float cameraZ = -10f;
    void LateUpdate() {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, cameraZ);
    }
}
