using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnEvent : MonoBehaviour
{
    Renderer rend;


    private void Start()
    {
        rend = GetComponent<Renderer>(); 
    }
    public void ChangeColor()
    {
        Debug.Log("Change Color.");
        rend.material.color = new Color(Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f)); 
    }
}
