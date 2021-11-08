using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPoint : MonoBehaviour
{
    public float width;
    public RectTransform HP;
    public RectTransform HP2;
    // Start is called before the first frame update
    void Start()
    {
        HP2 = GameObject.Find("BackgroundHP").GetComponent<RectTransform>();
        width = HP2.sizeDelta.x;
        HP = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        HP.sizeDelta = new Vector2(width, HP.sizeDelta.y);
    }
}
