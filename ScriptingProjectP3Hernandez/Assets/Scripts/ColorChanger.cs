using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (Input.GetKeyDown(KeyCode.R)) 
            GetComponent Componet<Renderer>().Material.color = Color.red;
        
    }
     If(Input.getkeydown(KeyCode.g))
        GetComponet<Renderer>().Material.collor = Color.Green;
}
    if(Input.GetKeyDown(KeyCode.G))
    
