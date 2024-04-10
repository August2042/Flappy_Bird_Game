using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGenScropt : MonoBehaviour
{
    public GameObject coinObject;
    public Transform coinGenPoint;

    float distance;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Random.Range(0, 4);
        if (transform.position.x < coinGenPoint.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + Random.Range(1, 5), distance, transform.position.z);
            Instantiate(coinObject, transform.position, transform.rotation);
        }

    }


}
