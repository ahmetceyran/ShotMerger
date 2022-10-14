using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    [SerializeField] private int shot = 1, shotCounter = 1;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "+1")
        {
           transform.parent = other.transform;
            shot++;
            shotCounter++;
            InvokeRepeating("Shot", 0.001f, 1f / shot);
        }
        if (other.gameObject.tag == "+2")
        {
            transform.parent = other.transform;
            shot += 2;
            shotCounter += 2;

            InvokeRepeating("Shot", 0.001f, 1f / shot);
        }
        if (other.gameObject.tag == "+3")
        {
            transform.parent = other.transform;
            shot += 3;
            shotCounter += 3;
            InvokeRepeating("Shot", 0.001f, 1f / shot);
        }
        if (other.gameObject.tag == "x2")
        {
            transform.parent = other.transform;
            shot *= 2;
            shotCounter *= 4;
            InvokeRepeating("Shot2x", 0.001f, 1f / shot);
        }
        if (other.gameObject.tag == "x3")
        {
            transform.parent = other.transform;
            shot *= 3;
            shotCounter *= 9;
            //3 yerden...
        }
    }
}
