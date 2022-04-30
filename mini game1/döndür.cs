using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class döndür : MonoBehaviour
{
    public static float rotationCount;
    // Start is called before the first frame update
    void Start()
    {
        rotationCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        gameObject.transform.Rotate(0,Quaternion.identity.y + 90, 0);
        rotationCount++;
        if (gameObject.transform.eulerAngles.y%270 == 0)
        {

            rotationgecici.score += 4;
        }
        else
        {
            rotationgecici.score--;

        }
    }
}
