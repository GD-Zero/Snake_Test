using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class L : MonoBehaviour
{
    [Range(0, 10), SerializeField] private float _rotateSpeed;
    public void onClickL()
    {
        transform.rotation *= Quaternion.Euler(0f, -150f * Time.deltaTime, 0f);
    }

    bool Pressed = false;
    public void onDown()
    {
        Pressed = true;
    }

    public void onUp()
    {
        Pressed = false;
    }

    void Update()
    {
        if (Pressed) transform.rotation *= Quaternion.Euler(0f, -150f * Time.deltaTime, 0f);
    }
}
