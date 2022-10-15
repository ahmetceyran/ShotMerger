using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gunScript : MonoBehaviour
{

    [SerializeField] private GameObject losePanel;


  
    private void OnTriggerEnter(Collider other)
    {
        //Silah varile carptiginda silah parcalanma animasyonun oynamasi
        if (other.gameObject.tag == "barrel")
        {
            this.GetComponent<Animation>().Play("loseAnim");
            StartCoroutine(AnimWait());
           
        }
        
    }

    IEnumerator AnimWait()
    {
        //losePanel aktif olmasi icin animasyonun bitmesini bekleme
        yield return new WaitForSeconds(0.1f);
        
        losePanel.SetActive(true);
    }

  
}
