using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform generationPoint;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        width = platform.GetComponent<BoxCollider2D>().size.x;
         
         

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + width,transform.position.y,transform.position.z);
            Instantiate(platform,transform.position,transform.rotation);                    //Duplicating the background
        }
         

    }
}
