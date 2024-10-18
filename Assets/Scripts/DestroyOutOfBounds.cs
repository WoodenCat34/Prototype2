using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBoundry = 19.0f;
    public float bottomBoundry = -5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundry)
        {
            Destroy (gameObject);
        
        }
        else if (transform.position.z < bottomBoundry)
        { Destroy (gameObject); 
        }
    }
}
