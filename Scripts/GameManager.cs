using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int ballNumber;
    public static GameObject Player;
    public static int a=0;
    public GameObject puzzle;
    public AudioClip siu;
    void Start()
    {
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.Find("Player");
        Survivorcontrol();
    }
    void Survivorcontrol()
    {
        if (a==4)
        {
            Time.timeScale = 1;
            puzzle.SetActive(false) ;
            a--; GetComponent<AudioSource>().clip = siu;

            GetComponent<AudioSource>().Play();
        }   
    }
}
