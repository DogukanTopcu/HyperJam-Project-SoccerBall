using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivor : MonoBehaviour
{
    Material m_Material;
    public bool t�klamacontrol = false;

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
        if (t�klamacontrol == false)
        {
            m_Material = GetComponent<Renderer>().material;
            m_Material.color = Color.red;
            t�klamacontrol = true;
            GameManager.a--;
        }
        else
        {


            m_Material.color = Color.white;
            t�klamacontrol = false;
            GameManager.a++;
        }

    }
  
}