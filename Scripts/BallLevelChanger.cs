using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLevelChanger : MonoBehaviour
{
    int ballLevel = 1;
    public MeshRenderer[] meshRenderers;
    public MeshFilter[] meshFilters;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballLevel <=0)
        {
            Destroy(gameObject);
        }
        if (ballLevel == 1)
        {
            ThirtysBall();
        }
        if (ballLevel == 2)
        {
            OldGenBall();
        }
        if (ballLevel == 3)
        {
            NextGenBall();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LU")
        {
            ballLevel++;
        }
        if (other.gameObject.name == "LD")
        {
            ballLevel--;
        }
    }
    private void ThirtysBall()
    {
        Destroy(GetComponent<MeshRenderer>());
        meshRenderers[0] = transform.parent.gameObject.AddComponent(typeof (MeshRenderer)) as MeshRenderer ;
        Destroy(GetComponent<MeshFilter>());
        meshFilters[0] = transform.parent.gameObject.AddComponent(typeof (MeshFilter)) as MeshFilter ;
    }
    private void OldGenBall()
    {
        Destroy(GetComponent<MeshRenderer>());
        meshRenderers[1] = transform.parent.gameObject.AddComponent(typeof (MeshRenderer)) as MeshRenderer ;
        Destroy(GetComponent<MeshFilter>());
        meshFilters[1] = transform.parent.gameObject.AddComponent(typeof (MeshFilter)) as MeshFilter ;
    }
    private void NextGenBall()
    {
        Destroy(GetComponent<MeshRenderer>());
        meshRenderers[2] = transform.parent.gameObject.AddComponent(typeof (MeshRenderer)) as MeshRenderer ;
        Destroy(GetComponent<MeshFilter>());
        meshFilters[2] = transform.parent.gameObject.AddComponent(typeof (MeshFilter)) as MeshFilter ;
    }
}
