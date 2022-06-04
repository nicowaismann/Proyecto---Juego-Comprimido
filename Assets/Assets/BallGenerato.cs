using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerato : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BallPrefab;
    public GameObject BallSpawnPoint;
    public float ShootForce;
  




    // Start is called before the first frame update
    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clonBola;
            clonBola = Instantiate(BallPrefab);
            clonBola.transform.position = BallSpawnPoint.transform.position;
            clonBola.GetComponent<Rigidbody>().AddForce(Vector3.left * ShootForce, ForceMode.Impulse);
            Destroy(clonBola, 2);
        }

    }
}