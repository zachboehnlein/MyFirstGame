using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xrotate = 0f;
    [SerializeField] float yrotate = 1f;
    [SerializeField] float zrotate = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(xrotate,yrotate,zrotate);   
    }
}
