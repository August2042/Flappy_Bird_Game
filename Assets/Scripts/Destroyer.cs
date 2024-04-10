using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    GameObject distroyerObj;
    // Start is called before the first frame update
    void Start()
    {
        distroyerObj = GameObject.Find("Distroyer");


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < distroyerObj.transform.position.x)
        {
            Destroy(gameObject);
        }


    }
}
