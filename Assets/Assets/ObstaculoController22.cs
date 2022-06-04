using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController22 : MonoBehaviour
{

    bool isRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= -4.3f)
        {
            isRight = false;
        }


        else if (transform.position.z >= 0f)
        {
            isRight = true;
        }

        if (!isRight)
        {
            transform.Translate(0, 0, 0.1f);
        }

        if (isRight)
        {
            transform.Translate(0, 0, -0.1f);
        }
    }
}
