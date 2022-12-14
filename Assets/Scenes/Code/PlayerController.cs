using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

     //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
 
    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

   void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.CompareTag("PickUp"))
       {
       other.gameObject.SetActive(false);
           count = count + 2;
       }

       if(other.gameObject.CompareTag("PickUpS"))
       {
       other.gameObject.SetActive(false);
           count = count + 1;
       }

       if(other.gameObject.CompareTag("PickUpL"))
        {
        other.gameObject.SetActive(false);
            count = count + 4;
        }
   }
    
}

