using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGenerator : MonoBehaviour
{
    public Transform Genpoint;
    public GameObject obstacle;
    public float difference;
    public float minDiff;
    public float maxDiff;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        difference = Random.Range(minDiff, maxDiff);

        if (transform.position.x < Genpoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + difference, Random.Range(1, 4), transform.position.z);
            Instantiate(obstacle, transform.position, transform.rotation);
        }

    }
}
