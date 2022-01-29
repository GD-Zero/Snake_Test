using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.tag == "Death")
    //    {
    //        SceneManager.LoadScene(8);
    //    }
    //}

    public GameObject RestartButton;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Death")
        {
            Time.timeScale = 0;
            RestartButton.SetActive(true);
        }
    }
}
