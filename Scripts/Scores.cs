using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public float duration;
    public Text Scoreboard;
    private float mainscore;
    public static int doubler;
    public GameObject endGameMenu;
    public GameObject inGameMenu;
    public GameObject Player;
    public Transform one;
    public Transform two;
    public Transform five;
    public Transform eight;
    public Transform fifteen;
    public Transform tt;
    void Start()
    {
        
    }


    void Update()
    {
        print(doubler);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            Destroy(other.gameObject);
            mainscore++;
        }
        if (other.gameObject.layer == 7)
        {
            Destroy(other.gameObject);
            mainscore += 2;
        }
        if (other.gameObject.layer == 8)
        {
            Destroy(other.gameObject);
            mainscore += 3;
        }
        if (other.gameObject.tag == "Player")
        {
            EndGame();
        }
    }
    private void EndGame()
    {
        PlayerController.movementSpeed = 5;
        PlayerController.horizontalSpeed = 0;
        endGameMenu.SetActive(true);
        inGameMenu.SetActive(false);
        Scoreboard.text = mainscore.ToString();
        StartCoroutine(Doublermesh());
    }
    IEnumerator Doublermesh()
    {
        if (doubler >= 1)
        {
            yield return new WaitForSeconds(2);
            Scoreboard.text += "x2";
            yield return new WaitForSeconds(1);
            Scoreboard.text = (mainscore*2).ToString();
            yield return new WaitForSeconds(1);
        }
        if (doubler >=2)
        {
            Scoreboard.text += "x2";
            yield return new WaitForSeconds(1);
            Scoreboard.text = (mainscore * 4).ToString();
            yield return new WaitForSeconds(1);
        }
        if (mainscore * 4 < 30)
        {
            Player.transform.position = one.position;
            PlayerController.movementSpeed = 0;

        }
        else if (mainscore * 4 >= 30 && mainscore * 4 < 55)
        {
            Player.transform.position = two.position;
            Scoreboard.text = (mainscore * 4 * 2).ToString();
            PlayerController.movementSpeed = 0;
        }
        else if (mainscore * 4 >= 55 && mainscore * 4 < 70)
        {
            Player.transform.position = five.position;
            Scoreboard.text = (mainscore * 4 * 5).ToString();
            PlayerController.movementSpeed = 0;
        }
        else if (mainscore * 4 >= 70 && mainscore * 4 < 80)
        {
            Player.transform.position = eight.position;
            Scoreboard.text = (mainscore * 4 * 8).ToString();
            PlayerController.movementSpeed = 0;
        }
        else if (mainscore * 4 >= 80 && mainscore * 4 < 92)
        {
            Player.transform.position = fifteen.position;
            Scoreboard.text = (mainscore * 4 * 15).ToString();
            PlayerController.movementSpeed = 0;
        }
        else if (mainscore * 4 >= 92)
        {
            Player.transform.position = tt.position;

            Scoreboard.text = (mainscore * 4 * 23).ToString();
            PlayerController.movementSpeed = 0;
        }
    }
}
