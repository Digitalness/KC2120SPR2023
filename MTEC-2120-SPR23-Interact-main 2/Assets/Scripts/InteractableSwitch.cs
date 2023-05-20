using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class MyBoolEvent : UnityEvent<bool>
{
}
public class InteractableSwitch : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;

    private bool isOn = false;

    public MyBoolEvent OnInteract; 

    string IInteractable.GetInteractText()
    {
        return interactText; 
    }

    Transform IInteractable.GetTransform()
    {
        return this.transform; 
    }

    void IInteractable.Interact(Transform interactorTransform)
    {
        isOn = !isOn; 
        OnInteract.Invoke(isOn); 

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
