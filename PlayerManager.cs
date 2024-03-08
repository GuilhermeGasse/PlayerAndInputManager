using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputmanager;
    PlayerMovement playerMovement;

    private void Awake()
    {
        inputmanager = GetComponent<InputManager>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        inputmanager.handleallinputs();
    }

    private void FixedUpdate()
    {
        playerMovement.handleallmovement();
    }
}
