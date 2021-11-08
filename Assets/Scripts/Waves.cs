using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waves : MonoBehaviour
{
    public Spawn _spawn;
    public Text _waves;
    public int numWave;

    private int maxWave = 3;
    // Start is called before the first frame update
    void Start()
    {
        numWave = 1;
        _spawn = GameObject.Find("Spawner").GetComponent<Spawn>();
        _waves = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
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
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
}
