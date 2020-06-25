using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            pos -= transform.forward * 0.5f;
        }else if (Input.GetKey(KeyCode.D))
        {
            pos += transform.forward * 0.5f;
        }else if (Input.GetKey(KeyCode.W))
        {
            pos -= transform.right * 0.5f;
        }else if (Input.GetKey(KeyCode.Z))
        {
            pos += transform.right * 0.5f;
        }
        transform.position = pos;
    }
}
