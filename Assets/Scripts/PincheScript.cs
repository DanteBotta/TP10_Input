using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PincheScript : MonoBehaviour
{
    public float rotationSpeedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            rotationSpeedY = 3f;
        }
        if (Input.GetKeyUp(KeyCode.Space)){
            rotationSpeedY = 0;
        }
        
        transform.Rotate(0, rotationSpeedY, 0);
    }
}
