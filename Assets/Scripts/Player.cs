using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float movementSpeed = 0.09f;
    [SerializeField] public int ammo = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        var deltaX = Input.GetAxis("Horizontal");
        var newXPosition = transform.position.x + deltaX * movementSpeed;
        var newYPosition = transform.position.y;
        var newZPosition = transform.position.z;
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }
    public void GetAmmo()
    {
        ammo = ammo + 1;
    }
}
