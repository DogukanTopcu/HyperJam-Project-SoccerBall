using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivor : MonoBehaviour
{
    Material m_Material;
    public bool týklamacontrol = false;

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
        if (týklamacontrol == false)
        {
            m_Material = GetComponent<Renderer>().material;
            m_Material.color = Color.red;
            týklamacontrol = true;
            GameManager.a--;
        }
        else
        {


            m_Material.color = Color.white;
            týklamacontrol = false;
            GameManager.a++;
        }

    }
  
}