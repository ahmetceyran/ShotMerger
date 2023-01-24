using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunMovement : MonoBehaviour
{
    private static GunMovement instance;

    private Vector3 firstTouchPosition;
    private Vector3 curTouchPosition;
    private float speed = 7;
    private float sensitivityMultiplier = 0.01f;
    private float finalTouchX;
    private float xBound = 4.25f;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TextMeshPro tmp;

    [SerializeField] private GameObject bullet;
    private GameObject cloneBullet;
    private float bulletSpeed = 1000;
    [SerializeField] private GameObject losePanel;
    float time,timeDelay;

    void Start()
    {
        time = 0f;
        timeDelay = 1f;
    }

    void Update()
    {
        //Kutu toplanmamissa saniyede bir atis yapmasi icin delay
        time = time + 1f * Time.deltaTime;
        if(time >= timeDelay)
        {
            time = 0f;
            InvokeRepeating("Shot", 0.001f, 1);
        }

        //Saniyede atilan mermi sayisini gosterme
        tmp.text = "" +collectableBox.shotCount + "/sec";
        
        //ileri yonlu hareket
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       
        //Hareket icin yeni input sistemi
        //Bilgisayarda kontrol icin mouse kullanildi
        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            curTouchPosition = Input.mousePosition;

            Vector2 touchDelta = (curTouchPosition - firstTouchPosition);

            finalTouchX = (transform.position.x + (touchDelta.x * sensitivityMultiplier));
            finalTouchX = Mathf.Clamp(finalTouchX, -xBound, xBound);

            transform.position = new Vector3(finalTouchX, transform.position.y, transform.position.z);

            firstTouchPosition = Input.mousePosition;
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        //silah engele carparsa geri gitme
        if(other.gameObject.tag == "obstacle")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - .5f);
        }
        //finishte hızlanma
        if (other.gameObject.tag == "2X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "3X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "4X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "5X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "6X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "7X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "8X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "9X")
        {
            speed = speed + 1;
        }
        if (other.gameObject.tag == "Finish")
        {
            //Time.timeScale = 0;
            winPanel.SetActive(true);
        }

    }

    //Kutu toplanmamis ise tekli ates etme
    //losePanel geldiginde atisin durmasi icin ekstra kontrol
    void Shot()
    {
        if(this.transform.childCount <= 6 && losePanel.activeInHierarchy == false)
        {
            Vector3 bulletPos = transform.position + new Vector3(-.5f, 0, .75f);

            cloneBullet = Instantiate(bullet, bulletPos, transform.rotation);
            cloneBullet.GetComponent<Rigidbody>().AddForce(cloneBullet.transform.forward * bulletSpeed);
            Destroy(cloneBullet, 1.5f);
        }
        
    }
}
