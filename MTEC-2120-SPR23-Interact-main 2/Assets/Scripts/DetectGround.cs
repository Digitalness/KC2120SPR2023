using UnityEngine;
using System.Collections;

public class DetectGround : MonoBehaviour
{
    //CharacterController charCtrl;
    public Transform leftFoot;
    public Transform rightFoot; 

    void Start()
    {
        //charCtrl = GetComponent<CharacterController>();
    }

    void Update()
    {
        RaycastHit hit;

        Vector3 p1 = leftFoot.position;
        float distanceToObstacle = 0;

        // Cast a sphere wrapping character controller 10 meters forward
        // to see if it is about to hit anything.
        if (Physics.SphereCast(p1, 0.3f, -transform.up, out hit, 10))
        {

            Debug.Log("Foot touched ground.");
            distanceToObstacle = hit.distance;
        }
    }
}