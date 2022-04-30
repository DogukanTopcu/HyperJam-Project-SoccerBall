using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgrader : MonoBehaviour
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
            Scores.doubler++;
            Time.timeScale = 0.1f;
            puzzle.SetActive(true);
        }
        
    }
}
