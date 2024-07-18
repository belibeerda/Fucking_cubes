using System.Collections.Generic;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 EditRotashion, LeftRotashion, RigthRotashion, BackRotashion;
    public Keyboard keyboard;
    public float Speed = 1.5f, Rotate_Y;
    Quaternion rotate;


    // Start is called before the first frame update
    void Start()
    {
        keyboard = Keyboard.current;
        rotate = transform.rotation;
        Rotate_Y = rotate.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard == null)
        {
            Debug.Log("No keybord");
            return;
        }

        //if (keyboard.wKey.isPressed == true)
        //{
        //    transform.Rotate(EditRotashion * Time.deltaTime);
        //    Debug.Log(transform.position);
        //    Debug.Log("Forward");
        //}

        //if (keyboard.aKey.isPressed == true)
        //{
        //    transform.Rotate(LeftRotashion * Time.deltaTime);
        //    Debug.Log("Left");
        //}

        //if (keyboard.dKey.isPressed == true)
        //{
        //    transform.Rotate(RigthRotashion * Time.deltaTime);
        //    Debug.Log("Right");
        //}

        //if (keyboard.sKey.isPressed == true)
        //{
        //    transform.Rotate(BackRotashion * Time.deltaTime);
        //    Debug.Log("Back");
        //}

        if (keyboard.wKey.isPressed == true)
        {
            transform.position += (transform.forward * Time.deltaTime * Speed);
            Debug.Log(transform.position);
            Debug.Log("Forward");
        }

        if (keyboard.aKey.isPressed == true)
        {
            transform.position -= (transform.right * Time.deltaTime * Speed);
            Debug.Log("Left");
        }

        if (keyboard.dKey.isPressed == true)
        {
            transform.position += (transform.right * Time.deltaTime * Speed);
            Debug.Log("Right");
        }

        if (keyboard.sKey.isPressed == true)
        {
            transform.position -= (transform.forward * Time.deltaTime * Speed);
            Debug.Log("Back");
        }

        if (keyboard.eKey.isPressed == true)
        {
            transform.Rotate(RigthRotashion * Time.deltaTime * Speed);
            Debug.Log("Right");
        }

        if (keyboard.qKey.isPressed == true)
        {
            transform.Rotate(LeftRotashion * Time.deltaTime * Speed);
            Debug.Log("Left");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void FixedUpdate()
    {

    }
}
