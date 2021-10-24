using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int healthpoint;
    // Start is called before the first frame update
    void Start()
    {
        healthpoint = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthpoint <= 0)
        {
            Destroy(gameObject);
        }
    }
}
