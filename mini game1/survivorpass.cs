using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivorpass : MonoBehaviour
{
    Material n_Material;
    public bool kontrol = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        if (kontrol == false)
        {
            n_Material = GetComponent<Renderer>().material;
            n_Material.color = Color.red;

            kontrol = true;
            GameManager.a++;

        }
        else
        {


            n_Material.color = Color.white;
          
            kontrol = false;
            GameManager.a--;

        }
        
    }
}