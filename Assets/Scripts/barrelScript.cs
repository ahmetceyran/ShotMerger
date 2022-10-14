using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class barrelScript : MonoBehaviour
{

    [SerializeField] private int can;
    [SerializeField] private TextMeshPro tM;
    [SerializeField] private GameObject dieEffect;
    

     void Update()
    {
        tM.text = ""+can;

        if (can <= 0)
        {
            Instantiate(dieEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            can--;
        }
    }
}
