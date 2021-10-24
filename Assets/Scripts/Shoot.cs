using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Shoot : MonoBehaviour
{
    public Ray ray;
    public RaycastHit hit;
    public GameObject crosshair;
    public GameObject distant;
    public float heading;
    public Button shoots; 
    private float nextFire = 0f;
    private float fireRate = 1;
    bool isClicked;
    private int patron = 0;
    private Text ammo;

    private EnemyHP _enemyHp;
    
    // Start is called before the first frame update
    void Start()
    {
        ammo = GameObject.FindGameObjectWithTag("AmmoUI").GetComponent<Text>();
        shoots = GameObject.FindGameObjectWithTag("Shoot").GetComponent<Button>();
        crosshair = GameObject.FindGameObjectWithTag("Crosshair");
        distant = GameObject.FindGameObjectWithTag("Enemy");
    }
    
    // Update is called once per frame
    void Update()
    {
        
        shoot();
        ammo.text = "Патронов:"+patron + "/30";
    }
    public void TaskOnClick() 
    {
        isClicked = true;
    }
    public void TaskOnClick2() 
    {
        isClicked = false;
    }
    public void shoot()
    {
        if (Time.time > nextFire && isClicked && patron > 0)
        {
            patron = patron - 1;
            ray = Camera.main.ScreenPointToRay(crosshair.transform.position);
            nextFire = Time.time + 0.1f / fireRate;
            if (Physics.Raycast(ray, out hit))
                {
                    heading = Vector3.Distance(hit.transform.position ,gameObject.transform.position);
                    if (hit.transform.CompareTag("Enemy") && heading < 30 )
                    { 
                        Debug.Log(hit.collider.name);
                        _enemyHp = GameObject.Find(hit.collider.name).GetComponent<EnemyHP>();
                        _enemyHp.healthpoint = _enemyHp.healthpoint - Random.Range(10, 15);
                    }
                }
        }
        
    }

    public void Reload()
    {
        if (patron == 0)
        {
            patron = 30;
        }
    }
}
