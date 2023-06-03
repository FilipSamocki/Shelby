using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(upKey) && transform.position.y < 5) 
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(downKey) && transform.position.y > -5)
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
         
        }
     
    }
}
