using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //MoveSpeed Varianble
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
       PrintInstructions(); 
    }    

    // Update is called once per frame
    void Update()
    {
        //player movement method call
        MovePlayer();
       
    }

    //printing the game instructions in the console log
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with wasd or arrow keys");
        Debug.Log("Don't hit the walls");
    }

    //Movement of player method
     void MovePlayer()
    {
        //Variables to input movement
        //Timedelta makes game framerate agnostic
        //Input allows you to input horizontal and vertical movemetn on the x and z axis
        float xMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yMovement = 0f;
        float zMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       //Actual movement 
       transform.Translate(xMovement,yMovement,zMovement); 
    }

}
