using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button resButton;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private Button nextButton;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject gun;


    void Start()
    {
        //Restart ve NextLevel fonksiyonun cagrilmasi
        resButton.onClick.AddListener(Restart);
        nextButton.onClick.AddListener(NextLevel);
    }

    void Update()
    {
        //panel aktif oldugunda silahin durmasi
        if(losePanel.activeInHierarchy)
        {
            gun.GetComponent<GunMovement>().enabled = false;
        }
        else
        {
            gun.GetComponent<GunMovement>().enabled = true;
        }
    }

    //Restart butonu fonksiyonu
    void Restart()
    {
        losePanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void NextLevel()
    {
        winPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
