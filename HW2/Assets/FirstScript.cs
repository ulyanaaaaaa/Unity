using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    [SerializeField] int _health;
    [SerializeField] int _hunger;
    [SerializeField] int _sleep;
    bool _flag = false;
    void Start()
    {
        CheckHealth(_health);
        CheckHunger(_hunger);
        CheckSleep(_sleep);

    }

    void CheckHealth(int health)
    {
        if (health < 50) health += 100 - _hunger;

        if (_flag == true) Debug.Log("�������� �����!");
        else if (health < 0) PersonalDied();
        else Debug.Log("�������� ��������!");
    }

    void CheckHunger(int hunger)
    {
        if (hunger > 50) hunger += _sleep;

        if (_flag == true) Debug.Log("�������� �����!");
        else if (hunger > 100) PersonalDied();
        else Debug.Log("�������� �� �������!");
    }

    void CheckSleep(int sleep)
    {
        if (sleep < 50) sleep += _health;

        if(_flag == true) Debug.Log("�������� �����!");
        else if (sleep < 0) PersonalDied();
        else Debug.Log("�� ���� ��� ������!");
    }

    void PersonalDied()
    {
        _health = 0;
        _hunger = 0;
        _sleep = 0;
        Debug.Log("��� �������� ����!");
        _flag = true;
    }
}
