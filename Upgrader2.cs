using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrader2 : MonoBehaviour
{
    public GameObject puzzle;
    void Start()
    {

    }

    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0.07f;
            puzzle.SetActive(true);
        }

    }
}
