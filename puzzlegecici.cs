using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlegecici : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerSphere")
        {
            GetComponent<AudioSource>().Play();
            transform.root.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
