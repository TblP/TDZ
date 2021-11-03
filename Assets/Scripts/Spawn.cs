using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] enemyPrefabsOnMap;
    private int i;
    private int b;
    // Start is called before the first frame update
    void Start()
    {
        b = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemy(); 
    }
    void spawnEnemy()
    {
        if (i <= b)
        {
            i += 1;
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], gameObject.transform.position, enemyPrefabs[enemyIndex].transform.rotation);
            
        } 
    }
}
