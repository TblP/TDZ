using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public HealthPoint _healthPoint;
    public Image _menu;
    public Joystick _joystick;
    // Start is called before the first frame update
    void Start()
    {
        
        _healthPoint = GameObject.FindGameObjectWithTag("hp").GetComponent<HealthPoint>();
        _joystick = GameObject.Find("Fixed Joystick").GetComponent<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_healthPoint.width <= 0)
        {
            Debug.Log("Proigral");
            _joystick.gameObject.SetActive(false);
            Time.timeScale = 0;
            
        }
    }
}
