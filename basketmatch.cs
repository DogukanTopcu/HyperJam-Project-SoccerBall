using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Basket
{
    btop1,
    btop2
}
public class basketmatch : MonoBehaviour
{
    public static bool check1=false;
    public static bool check2=false;
    public Basket currentStatus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
      
        if (currentStatus == Basket.btop1)
        {
            if (check1 == false)
            {

                gameObject.transform.Rotate(0, 0, Quaternion.identity.z + 180);
                BasketManager.basket = true;
                BasketManager.kontrol++;
                check1 = true;
            }
         
        }
        if (currentStatus == Basket.btop2)
        {
            if (check2==false)
            {
                gameObject.transform.Rotate(0, 0, Quaternion.identity.z + 180);
                BasketManager.basket2 = true;
                BasketManager.kontrol++;
                check2 = true;
            }
           
        }
        
    }
}
