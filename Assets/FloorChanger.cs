using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("1 pressed");
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        else if (Input.GetKeyDown("2"))
        {
            Debug.Log("2 pressed");
            transform.position = new Vector3(transform.position.x, 5.5f, transform.position.z);
        }
    }
}
