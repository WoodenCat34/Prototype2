using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
   
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xRangeRight = 21.35f;
    public float xRangeLeft = -20.63f;
    public GameObject pizzjectile;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x > xRangeRight)
        {
            transform.position = new Vector3 (xRangeRight, transform.position.y, transform.position.z);
            
        }
        if (transform.position.x < xRangeLeft)
        {
            transform.position = new Vector3(xRangeLeft, transform.position.y, transform.position.z);

        }
    }
}
