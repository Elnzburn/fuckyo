using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public Light LightComponent;


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.F))
        {
            LightComponent.enabled = !LightComponent.enabled;
        }
    }
}
