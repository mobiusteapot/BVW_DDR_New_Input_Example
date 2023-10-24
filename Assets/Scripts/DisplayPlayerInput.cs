using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DisplayPlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private TMPro.TMP_Text text;
    [SerializeField] private GameObject objectToHide;

    private InputAction exampleAction;


    private void Awake()
    {
        playerInput.onActionTriggered += OnActionTriggered;
        exampleAction = playerInput.actions.FindAction("X");
        exampleAction.performed += XbuttonTriggered;
        Debug.Log($"PlayerInput: {playerInput}");
    }

    private void OnActionTriggered(InputAction.CallbackContext context)
    {
        text.text = context.action.name;
    }

    private void XbuttonTriggered(InputAction.CallbackContext context)
    {
        Debug.Log("X button pressed via Unity C# Events");
        objectToHide.SetActive(!objectToHide.activeSelf);
    }

}
