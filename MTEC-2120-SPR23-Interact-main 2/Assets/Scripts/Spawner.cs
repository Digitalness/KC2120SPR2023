using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab; 

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 50; i++)
        {
            var position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            Instantiate(prefab, position, Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
