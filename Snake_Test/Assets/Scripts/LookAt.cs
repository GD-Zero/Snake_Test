using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // ����, �� ������� ������ �������� ������
    public Transform target;
    public void Update()
    {
        if (target != null)
        {
            // ������� ������ �� ����
            transform.LookAt(target);         
        }
    }
}
