using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    int vidaPared;

    // Start is called before the first frame update
    void Start()
    {
        vidaPared = 5;

       
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaPared == 0)
        {
            Destroy(gameObject);
        }

        
    }

    void OnCollisionEnter(Collision col)
    {

        

        if (col.gameObject.tag == "Pelotita")
        {

            vidaPared-=1;
            Destroy(col.gameObject);
        }
        
    }
}
