using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public HealthPoint _healthPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _healthPoint = GameObject.FindGameObjectWithTag("hp").GetComponent<HealthPoint>();
    }

    private void OnCollisionStay(Collision other)
    {
        for (int i = 2; i < 7; i++)
        {
            if (other.gameObject.CompareTag("Cont" + i))
            {
                _healthPoint.width = _healthPoint.width - 5;
            }
        }
    }
}
