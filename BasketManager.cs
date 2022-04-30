using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketManager : MonoBehaviour
{
    private int ej;
    bool artti;
    bool artti2;
    public static int kontrol=0; 
    public static bool basket=false;
    public static bool football=false;
    public static bool basket2 = false;
    public static bool football2 = false;
    public GameObject a;
    public GameObject b;
    public GameObject e;
    public GameObject r;
    public GameObject main;

    public AudioClip asd;
    // Start is called before the first frame update
    void Start()
    {
        basket = false;
        football = false;
        basket2 = false;
        football2 = false;
        kontrol = 0;
        ej = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (basket==true&& basket2==true )
        {
            StartCoroutine(destroyBasket());
        }
        if (football==true && football2==true)
        {
            StartCoroutine(destroyFootball());
        }
        if (kontrol == 0)
        {
           
            basket = false;
            football = false;
            basket2 = false;
            football2 = false;
            basketmatch.check1 = false;
            basketmatch.check2 = false;
            footbalmatch.check12 = false;
            footbalmatch.check22 = false;
        }
        if (kontrol == 2)
        {
            StartCoroutine(hepsiDown());
            
            kontrol = 0;
        }
        if (ej==2)
        {
            main.SetActive(false);
            Time.timeScale = 1;
        }
    }
    IEnumerator hepsiDown()
    {
        yield return new WaitForSeconds(0.02f);
        if (a != null && r!= null)
        {
            a.transform.rotation = Quaternion.Euler(0, 0, 180);
            b.transform.rotation = Quaternion.Euler(0, 0, 180);
            r.transform.rotation = Quaternion.Euler(0, 0, 180);
            e.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }
    IEnumerator destroyBasket()
    {
        if (!artti2)
        {
            ej++;
            artti2 = true;
        }
        yield return new WaitForSeconds(0.015f);
        if (e != null && r != null)
        {
            Destroy(e);
            Destroy(r);
            basket = false;
        }
    }
    IEnumerator destroyFootball()
    {
        if (!artti)
        {
            ej++;
            artti = true;
        }
        yield return new WaitForSeconds(0.015f);
        if (a != null && b != null)
        {
            Destroy(a);
            Destroy(b);
            football = false;
        }
    }
    

}
