using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Obstaculo1")
        {

            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

        if (col.gameObject.name == "Obstaculo2 (1)")
        {

            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

        if (col.gameObject.name == "Obstaculo2 (2)")
        {

            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

        if (col.gameObject.name == "Obstaculo3 (1)")
        {

            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

        if (col.gameObject.name == "Obstaculo3 (2)")
        {

            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

        if (col.gameObject.name == "Obstaculo3 (3)")
        {

            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

    }
}
