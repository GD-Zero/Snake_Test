using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //дистанция от которой он начинает видеть игрока
    public float seeDistance = 20f;
    //дистанция до атаки
    public float attackDistance = 1f;
    //скорость енеми
    public float speed = 3;
    //игрок
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