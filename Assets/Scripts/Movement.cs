using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // x and y arrays to place ball on random positions

    float[] xPositions = { -3.3f, 2.5f, 5.1f, 2.2f, 6.0f, -1.0f};
    float[] yPositions = { -3.1f, 1.5f, 3.0f, -2.7f, -1.5f, 0.1f};

    int index = 0; // Index for positions array

    float z = 0;



    // Start is called before the first frame update
    
    void Start()
    {
        Debug.Log(transform);
        // Every object has a transform by default
    }


    // Update is called once per frame
    
    void Update()
    {
        z += 1; 
        

        if (z % 150 == 0)   
        {
            if (index < 6)
            index++;          
        }


       

        Debug.Log(index);

        transform.position = new Vector3(xPositions[index], yPositions[index], 0.3f);


    }
}
