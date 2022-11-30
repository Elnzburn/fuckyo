using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator DoorAnimator;
    bool _IsOpen;

    public string GetActionMeesage()
    {
        if (_IsOpen)
            return " E close Door";
        else
            return " E Open Door";
    }


    public void Interact()
    {
        _IsOpen = !_IsOpen;
        DoorAnimator.SetBool("IsOpen", _IsOpen);
    }
    
   
}
