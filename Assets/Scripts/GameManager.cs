using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button resButton;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject gun;


    void Start()
    {
        
        resButton.onClick.AddListener(Restart);
    }

    void Update()
    {
        if(losePanel.activeInHierarchy)
        {
            gun.GetComponent<GunMovement>().enabled = false;
        }
        else
        {
            gun.GetComponent<GunMovement>().enabled = true;
        }
    }

    
    void Restart()
    {
        losePanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
