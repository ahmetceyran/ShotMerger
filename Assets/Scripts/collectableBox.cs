using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableBox : MonoBehaviour
{
    public static int  shotCount=1;
    private bool isActive;
    [SerializeField] private GameObject bullet;
    private GameObject cloneBullet;
    [SerializeField] private float bulletSpeed;
    private bool yapisik;

    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        yapisik = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true)
        {
            if (this.gameObject.tag == "x2")
            {
                InvokeRepeating("Shot2x", 0.001f, .5f);
                shotCount *= 2;
                isActive = false;
            }
            if (this.gameObject.tag == "x3")
            {
                InvokeRepeating("Shot3x", 0.001f, .33f);
                shotCount *= 3;
                isActive = false;
            }
            if (this.gameObject.tag == "+1")
            {
                InvokeRepeating("Shot", 0.001f, 1);
                shotCount++;
                isActive = false;

            }
            if (this.gameObject.tag == "+2")
            {
                InvokeRepeating("Shot", 0.001f, .5f);
                shotCount += 2;
                isActive = false;

            }
            if (this.gameObject.tag == "+3")
            {
                InvokeRepeating("Shot", 0.001f, .33f);
                shotCount += 3;
                isActive = false;

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "barrel" || other.gameObject.tag == "obstacle")
        {
            if (this.gameObject.tag == "+1" && shotCount > 1)
            {
                shotCount -= 1;
            }
            if (this.gameObject.tag == "+2")
            {
                shotCount -= 2;
            }
            if (this.gameObject.tag == "+3")
            {
                shotCount -= 3;
            }
            if (this.gameObject.tag == "x2")
            {
                shotCount /= 2;
            }
            if (this.gameObject.tag == "x3")
            {
                shotCount /= 3;
            }
            Destroy(this.gameObject);
            
        }

        if (yapisik == false)
        {
            if (other.gameObject.tag == "gun")
            {
                transform.parent = other.transform;
                transform.localPosition = new Vector3(-.0115f, 0, -0.018f);
                yapisik = true;
                isActive = true;
            }
            if (other.gameObject.tag == "+1")
            {
                transform.parent = other.transform;
                transform.localPosition = new Vector3(-.0115f, 0, .5f);
                yapisik = true;

                isActive = true;
            }
            if (other.gameObject.tag == "+2")
            {
                transform.parent = other.transform;
                transform.localPosition = new Vector3(-.0115f, 0, 1f);
                yapisik = true;
                isActive = true;
            }
            if (other.gameObject.tag == "+3")
            {
                transform.parent = other.transform;
                transform.localPosition = new Vector3(-.0115f, 0, 1.5f);
                yapisik = true;
                isActive = true;
            }
            if (other.gameObject.tag == "x2")
            {
                transform.parent = other.transform;
                transform.localPosition = new Vector3(-.0115f, 0, .5f);
                yapisik = true;
                isActive = true;
            }
            if (other.gameObject.tag == "x3")
            {
                transform.parent = other.transform;
                transform.localPosition = new Vector3(-.0115f, 0, .5f);
                yapisik = true;
                isActive = true;
            }

        }

        
       
       
    }
    void Shot()
    {
        Vector3 bulletPos = transform.position + new Vector3(0, 0, .25f);

        cloneBullet = Instantiate(bullet, bulletPos, transform.rotation);
        cloneBullet.GetComponent<Rigidbody>().AddForce(cloneBullet.transform.forward * bulletSpeed);
        Destroy(cloneBullet, 1.5f);
    }

    void Shot2x()
    {
        Vector3 bulletPosx2 = transform.GetChild(0).transform.position + new Vector3(0, 0, .25f);
        Vector3 bulletPosx22 = transform.GetChild(1).transform.position + new Vector3(0, 0, .25f);

        cloneBullet = Instantiate(bullet, bulletPosx2, transform.rotation);
        cloneBullet.GetComponent<Rigidbody>().AddForce(cloneBullet.transform.forward * bulletSpeed);
        Destroy(cloneBullet, 1.5f);


        cloneBullet = Instantiate(bullet, bulletPosx22, transform.rotation);
        cloneBullet.GetComponent<Rigidbody>().AddForce(cloneBullet.transform.forward * bulletSpeed);
        Destroy(cloneBullet, 1.5f);

    }
    void Shot3x()
    {
        Vector3 bulletPosx3 = transform.GetChild(0).transform.position + new Vector3(0, 0, .25f);
        Vector3 bulletPosx32 = transform.GetChild(1).transform.position + new Vector3(0, 0, .25f);
        Vector3 bulletPosx33 = transform.GetChild(2).transform.position + new Vector3(0, 0, .25f);


        cloneBullet = Instantiate(bullet, bulletPosx3, transform.rotation);
        cloneBullet.GetComponent<Rigidbody>().AddForce(cloneBullet.transform.forward * bulletSpeed);
        Destroy(cloneBullet, 1.5f);


        cloneBullet = Instantiate(bullet, bulletPosx32, transform.rotation);
        cloneBullet.GetComponent<Rigidbody>().AddForce(cloneBullet.transform.forward * bulletSpeed);
        Destroy(cloneBullet, 1.5f);


        cloneBullet = Instantiate(bullet, bulletPosx33, transform.rotation);
        cloneBullet.GetComponent<Rigidbody>().AddForce(cloneBullet.transform.forward * bulletSpeed);
        Destroy(cloneBullet, 1.5f);

    }

 

}
