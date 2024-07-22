using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Crouch : MonoBehaviour
{

    [SerializeField] private CharacterController character;
    public float crouchHeight = 1f;
    public float standHeight = 2f;
    private bool isCrouching = false;



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            ToggleCrouch();
        }
    }


    private void Start()
    {
        character = GetComponent<CharacterController>();
    }


    void ToggleCrouch()
    {
        if (isCrouching)
        {
            character.height = standHeight;
            isCrouching = false;
        }
        else
        {
            character.height = crouchHeight;
            isCrouching = true;
        }
    }



}
