using UnityEngine;
using UnityEngine.InputSystem;

// Recieves input from a Unity Event assigned in the inspector to point to this script
// Unity events can be a great way to expose functionality to designers
// Or create flexible logic that is easy to adjust later
public class ShowHidePanelExample : MonoBehaviour
{
    public void TogglePanel()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
    // Unity events can also recieve callback context information, such as if the button was pressed down or released
    // https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.InputAction.CallbackContext.html
    public void DebugPrintCallback(InputAction.CallbackContext context)
    {
        Debug.Log($"Action triggered: {context.action.name}");
    }
}
