using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downgrader : MonoBehaviour
{
    GameObject previus;
    public GameObject lowLvlBall;
    public GameObject midLvlBall;
    public GameObject highLvlBall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "nodeBall" || other.tag == "Ball")
        {
            GetComponent<AudioSource>().Play();
            if (other.tag == "nodeBall")
            {
                previus = other.GetComponent<NodeBallsMovement>().connectedNode;
                previus.AddComponent<Collector>();
                previus.GetComponent<Collector>().lowLvlBall = lowLvlBall;
                previus.GetComponent<Collector>().midLvlBall = midLvlBall;
                previus.GetComponent<Collector>().highLvlBall = highLvlBall;

            }

            Destroy(other.gameObject);
        }
    }


}
