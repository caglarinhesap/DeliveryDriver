using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector3 cameraDistanceToTarget = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        transform.position = target.transform.position + cameraDistanceToTarget;
    }
}
