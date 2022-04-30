using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stoper : MonoBehaviour
{
    public GameObject lowballPrefab;
    public GameObject midballPrefab;
    public GameObject highballPrefab;
    GameObject lastBall;
    GameObject lastOne;
    GameObject lastTwo;
    AudioClip amsori;
    GameObject newCollector;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "nodeBall")
        {
            GetComponent<AudioSource>().Play();
            lastBall = Collector.LastBall;
            lastOne = lastBall.GetComponent<NodeBallsMovement>().connectedNode;
            lastTwo = lastOne.GetComponent<NodeBallsMovement>().connectedNode;

            Destroy(lastBall);
            Destroy(lastOne);
            Destroy(lastTwo);


            // lastBall.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);
            // lastOne.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);
            // lastTwo.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);


            Destroy(lastBall.GetComponent<NodeBallsMovement>());
            Destroy(lastOne.GetComponent<NodeBallsMovement>());
            Destroy(lastTwo.GetComponent<NodeBallsMovement>());


            newCollector = lastTwo.GetComponent<NodeBallsMovement>().connectedNode;
            newCollector.AddComponent<Collector>();
            newCollector.GetComponent<Collector>().lowLvlBall = lowballPrefab;
            newCollector.GetComponent<Collector>().midLvlBall = midballPrefab;
            newCollector.GetComponent<Collector>().highLvlBall = highballPrefab;


        }
    }
}
