using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movestraight : MonoBehaviour
{
    private float speed = 40;
    private float leftBound = 37;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if(transform.position.x > leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
