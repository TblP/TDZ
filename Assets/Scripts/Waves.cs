using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Waves : MonoBehaviour
{
    public Spawn[] _spawn;
    public Text _waves;
    public int numWave;
    public bool spawn = true;
    private int maxWave = 3;
    // Start is called before the first frame update
    void Start()
    {
        numWave = 1;
        //_spawn = GameObject.Find("Spawner").GetComponent<Spawn[]>();
        //_waves = GetComponent<Text>();
        _spawn[0].b = Random.Range(1, 10);
        _spawn[1].b = Random.Range(1, 10);
        _spawn[2].b = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        /*/
        if (_spawn.check == false && GameObject.FindGameObjectWithTag("Enemy") == false)
        {
            numWave += 1;
            _waves.text = "Волна: " + numWave + "/" + maxWave;
            _spawn.check = true;
            _spawn.check2 = true;
            _spawn.i = 0;
        }/*/
        switch (numWave)
        {
            case 1:
                _waves.text = "Волна: " + numWave + "/" + maxWave;
                if (spawn)
                {
                    _spawn[0].spawnEnemy();
                    _spawn[1].spawnEnemy();
                    _spawn[2].spawnEnemy();
                    _spawn[0].changeName();
                }
                
                if (GameObject.FindGameObjectsWithTag("Enemy").Length == _spawn[0].b + _spawn[1].b + _spawn[2].b + 3)
                {
                    spawn = false;
                }
                Debug.Log(GameObject.FindGameObjectsWithTag("Enemy").Length);
                if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
                {
                    //Thread.Sleep(5000);
                    _spawn[0].b = Random.Range(1, 10);
                    _spawn[1].b = Random.Range(1, 10);
                    _spawn[2].b = Random.Range(1, 10);
                    _spawn[0].i = 0;
                    _spawn[1].i = 0;
                    _spawn[2].i = 0;
                    spawn = true;
                    numWave = 2;
                }

                break;
            case 2:
                _waves.text = "Волна: " + numWave + "/" + maxWave;
                if (spawn)
                {
                    _spawn[0].spawnEnemy();
                    _spawn[1].spawnEnemy();
                    _spawn[2].spawnEnemy();
                    _spawn[0].changeName();
                }
                if (GameObject.FindGameObjectsWithTag("Enemy").Length == _spawn[0].b + _spawn[1].b + _spawn[2].b + 3)
                {
                    spawn = false;
                }

                if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
                {
                    //Thread.Sleep(5000);
                    _spawn[0].b = Random.Range(1, 10);
                    _spawn[1].b = Random.Range(1, 10);
                    _spawn[2].b = Random.Range(1, 10);
                    _spawn[0].i = 0;
                    _spawn[1].i = 0;
                    _spawn[2].i = 0;
                    spawn = true;
                    numWave = 3;
                }

                break;
            case 3:
                _waves.text = "Волна: " + numWave + "/" + maxWave;
                if (spawn)
                {
                    _spawn[0].spawnEnemy();
                    _spawn[1].spawnEnemy();
                    _spawn[2].spawnEnemy();
                    _spawn[0].changeName();
                }
                if (GameObject.FindGameObjectsWithTag("Enemy").Length == _spawn[0].b + _spawn[1].b + _spawn[2].b + 3)
                {
                    spawn = false;
                }
                if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
                {
                    numWave = 0;
                    _spawn[0].i = 0;
                    _spawn[1].i = 0;
                    _spawn[2].i = 0;
                    Debug.Log("3 волны пройдены");
                }
                break;
        }
    }
}
