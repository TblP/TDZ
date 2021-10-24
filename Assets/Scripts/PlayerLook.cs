using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform head;
    private float rotationY;
    public Joystick _joystick;
    public float sensitivity = 0.2f; // ���������������� ����
    public float headMinY = -40f; // ����������� ���� ��� ������
    public float headMaxY = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float rotationX = head.localEulerAngles.y + _joystick.Horizontal * sensitivity;
        rotationY += _joystick.Vertical * sensitivity;
        rotationY = Mathf.Clamp(rotationY, headMinY, headMaxY);
        head.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
