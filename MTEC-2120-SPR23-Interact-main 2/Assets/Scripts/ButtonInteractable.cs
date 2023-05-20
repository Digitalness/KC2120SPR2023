using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations; 
using UnityEngine.Animations.Rigging;


public class ButtonInteractable : MonoBehaviour, IInteractable
{

    private  Rig rig;
    private Vector3 cachedPosition;

    public string GetInteractText()
    {

        Debug.Log("GetInteractText...");
        return "Please press the button";
    }  

    public Transform GetTransform()
    {
        return this.transform; 
    }

    public void Interact(Transform interactorTransform)
    {

        rig = interactorTransform.GetComponentInChildren<Rig>();
        if (rig == null)
        {
            Debug.Log("No Rig Found.");

            return;

        }

        Transform target = rig.transform.Find("Right Arm IK/RH IK Target");
        if (target == null )
        {
            Debug.Log("No IK Target Found.");

            return;

        }


        cachedPosition = target.position;
        target.position = transform.position; 

        rig.weight = 1;

        StartCoroutine(EndInteraction()); 

    }

    IEnumerator EndInteraction()
    {
        yield return new WaitForSeconds(2);

        Transform target = rig.transform.Find("Right Arm IK/RH IK Target");
        if (target == null)
        {
            Debug.Log("No IK Target Found.");
        }
        target.position = cachedPosition;
        rig.weight = 0;
    }


}
