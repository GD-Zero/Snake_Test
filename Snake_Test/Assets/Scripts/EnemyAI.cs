using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //��������� �� ������� �� �������� ������ ������
    public float seeDistance = 20f;
    //��������� �� �����
    public float attackDistance = 1f;
    //�������� �����
    public float speed = 3;
    //�����
    private Transform target;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackDistance)
            {
                //walk
                transform.LookAt(target.transform);
                transform.Translate(new Vector3(0, Time.deltaTime, speed * Time.deltaTime));
            }
        }
        else
        {
            //idle
        }
    }
}