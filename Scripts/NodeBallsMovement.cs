using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBallsMovement : MonoBehaviour
{
    public GameObject connectedNode;
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, connectedNode.transform.position.x, Time.deltaTime * 20),
            connectedNode.transform.position.y,
            connectedNode.transform.position.z + 0.5f
        );
    }
}
