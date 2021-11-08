using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] enemyPrefabsOnMap;
    public int i;
    private int b;
    public bool check = true;
    public bool check2 = true;
    private int q;

    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        /*/
        if (check2)
        {
            b = Random.Range(1, 5); 
            spawnEnemy();
        }
        /*/
    }

    void FixedUpdate()
    {
        /*/
        if (check && GameObject.FindGameObjectWithTag("Enemy"))
        {
            changeName();
        }/*/

    }
    void spawnEnemy()
    {
        if (i <= b)
        {
            i += 1;
            //int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[0], gameObject.transform.position, enemyPrefabs[0].transform.rotation);
        } 
    }

    void changeName()
    {
        enemyPrefabsOnMap = GameObject.FindGameObjectsWithTag("Enemy");
        for (int c = 0; c < enemyPrefabsOnMap.Length; c++)
        {
            q+=2;
            enemyPrefabsOnMap[c].name = "enemy" + q;
            if (enemyPrefabsOnMap.Length == b * 3)
            {
                check2 = false;
                check = false;
            }
        }
    }
}
