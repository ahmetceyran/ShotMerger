using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawRotation : MonoBehaviour
{
    private float rotateSpeed = -1;

    void Update()
    {
        this.transform.Rotate(rotateSpeed, 0, 0, Space.World);
    }
}
