using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    float VerticalMovement;
    float HorizontalMovement;
    float MovementSpeed;
    [SerializeField]
    GameObject fireBall, target;
    // Start is called before the first frame update
    void Start()
    {
        MovementSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        VerticalMovement = Input.GetAxis("Vertical");
        HorizontalMovement = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(HorizontalMovement, 0, VerticalMovement);
        if (movement != Vector3.zero)
        {
            transform.position += (transform.TransformDirection(movement) * MovementSpeed) * Time.deltaTime;
        }

       // transform.rotation *= Quaternion.Euler(0, HorizontalMovement, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(fireBall, transform.position + (Vector3.forward * 2), Quaternion.identity);
        }
    }
}
