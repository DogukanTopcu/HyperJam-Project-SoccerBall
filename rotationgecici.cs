using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationgecici : MonoBehaviour
{
    public static int score;

    public Transform First;
    public Transform Second;
    public Transform Third;
    public Transform Fourth;
    public Transform Fifth;

    bool isFirstOk = false;
    bool isSecondOk = false;
    bool isThirdOk = false;
    bool isFourthOk = false;
    bool isFifthOk = false;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (First.transform.eulerAngles.y == 270)
        {
            isFirstOk = true;
        }
        else
        {
            isFirstOk = false;
        }

        if (Second.transform.eulerAngles.y == 270)
        {
            isSecondOk = true;
        }
        else
        {
            isSecondOk = false;
        }

        if (Third.transform.eulerAngles.y == 270 || Third.transform.eulerAngles.y == 90)
        {
            isThirdOk = true;
        }
        else
        {
            isThirdOk = false;
        }

        if (Fourth.transform.eulerAngles.y == 270)
        {
            isFourthOk = true;
        }
        else
        {
            isFourthOk = false;
        }

        if (Fifth.transform.eulerAngles.y == 270)
        {
            isFifthOk = true;
        }
        else
        {
            isFifthOk = false;
        }


        if (isFirstOk && isSecondOk && isThirdOk && isFourthOk && isFifthOk)
        {
            GetComponent<AudioSource>().Play();
            transform.root.gameObject.SetActive(false);
            Time.timeScale = 1;
        }



    }
}
