using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public GameObject lowLvlBall;
    public GameObject midLvlBall;
    public GameObject highLvlBall;
    GameObject newBall;
    public static GameObject LastBall;


    private void Update()
    {
        if (GetComponent<Collector>())
        {
            LastBall = this.gameObject;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball" || other.tag == "nodeBall")
        {
            Destroy(other.gameObject);
            GameManager.ballNumber++;

            if (other.gameObject.layer == 6)
            {
                newBall = Instantiate(lowLvlBall, transform.position + Vector3.forward, Quaternion.identity);
                newBall.tag = "nodeBall";

                newBall.AddComponent<Collector>();
                newBall.GetComponent<Collector>().lowLvlBall = lowLvlBall;
                newBall.GetComponent<Collector>().midLvlBall = midLvlBall;
                newBall.GetComponent<Collector>().highLvlBall = highLvlBall;
            }
            else if (other.gameObject.layer == 7)
            {
                newBall = Instantiate(midLvlBall, transform.position + Vector3.forward, Quaternion.identity);
                newBall.tag = "nodeBall";

                newBall.AddComponent<Collector>();
                newBall.GetComponent<Collector>().lowLvlBall = lowLvlBall;
                newBall.GetComponent<Collector>().midLvlBall = midLvlBall;
                newBall.GetComponent<Collector>().highLvlBall = highLvlBall;
            }
            else if (other.gameObject.layer == 8)
            {
                newBall = Instantiate(highLvlBall, transform.position + Vector3.forward, Quaternion.identity);
                newBall.tag = "nodeBall";

                newBall.AddComponent<Collector>();
                newBall.GetComponent<Collector>().lowLvlBall = lowLvlBall;
                newBall.GetComponent<Collector>().midLvlBall = midLvlBall;
                newBall.GetComponent<Collector>().highLvlBall = highLvlBall;
            }




            newBall.AddComponent<NodeBallsMovement>();
            newBall.GetComponent<NodeBallsMovement>().connectedNode = gameObject;

            newBall.GetComponent<Animator>().SetBool("isCollected", true);

            newBall.GetComponent<BoxCollider>().isTrigger = false;



            Destroy(GetComponent<Collector>());

        }
    }
}
