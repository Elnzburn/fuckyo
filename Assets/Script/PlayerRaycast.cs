using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public Transform PlayerTransform;
    public ActionUICanvas ActionCanvas;
    public float InteractionRange = 2f;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(PlayerTransform.position,PlayerTransform.TransformDirection(Vector3.forward),out hit, 2f))
        {
            Debug.DrawRay(PlayerTransform.position, PlayerTransform.TransformDirection(Vector3.forward).normalized * 2f, Color.green);
            if (hit.collider.tag == "DoorWing")
            {
                Door hitDoor = hit.collider.GetComponent<Door>();
                string message = hitDoor.GetActionMeesage();
                ActionCanvas.ShowActionText(message);
                if (Input.GetKeyDown(KeyCode.E))
                    hitDoor.Interact();
            }
            else
                ActionCanvas.HideCanvas();
        }
        else
        {
            ActionCanvas.HideCanvas();
            Debug.DrawRay(PlayerTransform.position, PlayerTransform.TransformDirection(Vector3.forward).normalized * 2f, Color.red);
        }
        
    }
}
