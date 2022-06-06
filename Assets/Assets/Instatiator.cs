using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiator : MonoBehaviour
{
    public GameObject CubePrefab;
    public GameObject CubeSpawnPoint;
    public GameObject pelota;
    public float ShootForce;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pelota.transform.position.x > 5 && pelota.transform.position.x < 5.1f)
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(CubePrefab);
                CubePrefab.transform.position = CubeSpawnPoint.transform.position;
                CubePrefab.GetComponent<Rigidbody>().AddForce(Vector3.forward * ShootForce, ForceMode.Impulse);

            }
        }
    }
   
}
