using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DisplayPlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private TMPro.TMP_Text text;

    private InputAction testAction;


    private void Awake()
    {
        playerInput.onActionTriggered += OnActionTriggered;
        testAction = playerInput.actions.FindAction("Up");
        Debug.Log($"PlayerInput: {playerInput}");
    }

    private void OnActionTriggered(InputAction.CallbackContext context)
    {
        text.text = context.action.name;
    }

}
