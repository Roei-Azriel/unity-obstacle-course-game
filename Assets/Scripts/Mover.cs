using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();

    }

    //function


    void PrintInstruction(){
        Debug.Log("Welcome to the game \n"); // Debbug print to the console
        Debug.Log("Starting the game now");
        Debug.Log("Move your player with WASD or arrow keys");
    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // pushing left or right in the keboard (D or A)
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue); // x and z can move, but y is up and down so its constant
    }
}
