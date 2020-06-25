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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos -= transform.forward * 0.5f;
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos += transform.forward * 0.5f;
        }else if (Input.GetKey(KeyCode.UpArrow))
        {
            pos -= transform.right * 0.5f;
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            pos += transform.right * 0.5f;
        }
        transform.position = pos;
    }
}
