using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Basssket
{
    ctop1,
    ctop2
}
public class footbalmatch : MonoBehaviour
{
    public static bool check12 = false;
    public static bool check22 = false;
    // Start is called before the first frame update
    public Basssket currentStatus;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
       
        if (currentStatus == Basssket.ctop1)
        {
            if (check12==false)
            {
                gameObject.transform.Rotate(0, 0, Quaternion.identity.z + 180);
                BasketManager.football = true;
                BasketManager.kontrol++;
                check12 = true;
            }
            
        }
        if (currentStatus == Basssket.ctop2)
        {
            if (check22==false)
            {
                gameObject.transform.Rotate(0, 0, Quaternion.identity.z + 180);
                BasketManager.football2 = true;
                BasketManager.kontrol++;
                check22 = true;
            }
            
        
        }
    }
}
