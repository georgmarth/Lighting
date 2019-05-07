using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{

    public float rotationSpeed = 1f;
    
    void Update()
    {
        Vector3 oldRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(
            oldRotation.x,
            oldRotation.y + rotationSpeed * Time.deltaTime,
            oldRotation.z
            );
    }
}
