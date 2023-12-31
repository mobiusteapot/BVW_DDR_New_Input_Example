//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/DDR_Pad_Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DDR_Pad_Input: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DDR_Pad_Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DDR_Pad_Input"",
    ""maps"": [
        {
            ""name"": ""DefaultActionMap"",
            ""id"": ""f43d13b1-c02e-4a11-9c95-bb2c6a5c1049"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""343b2467-d961-478c-88e3-480056ba52cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""ec9c37e8-4f5d-44b6-a09c-7835d3ad1f17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""81a5429d-0e54-44f0-bf88-454ca5849688"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""1a5b6b90-12ab-4fd9-bf0f-374b9385d32d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""8815f12c-6247-47c3-bb3a-005ac0834c60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""O"",
                    ""type"": ""Button"",
                    ""id"": ""a9ea7ccb-494f-44ea-b37c-4233d3ca346b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""11130898-d669-40eb-9e41-a143c43a7a6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""7d346457-d958-4f04-83a1-46ffd7e6bb1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""cd1480d5-1caf-4e91-954b-eee9e8f8c5b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""2b7f201e-0581-4708-b9ce-5e40bb9f4f3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""87fc646b-d8be-4c96-8de7-32eed3a361c7"",
                    ""path"": ""<HID::USB Gamepad >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64770ee1-43a3-4095-be5a-1723f82b49ea"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef9ea253-139e-4214-9fb3-3a0bc0a1878f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""814776b2-4ced-456b-ae63-ae0d3a8153dd"",
                    ""path"": ""<HID::USB Gamepad >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0896fa3-865a-4607-a3d7-5e422e64c994"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb70216e-f7b6-4d7b-8fa5-2924e51e5829"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59faf188-e15d-439b-a28b-cac697143054"",
                    ""path"": ""<HID::USB Gamepad >/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50ba2e32-b75f-4bb2-8021-c30c5a4746a9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b24d56a5-00f8-49e0-b86c-ffb87fbe9620"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1b9bcf6-66ba-4b72-af14-5e92832258c0"",
                    ""path"": ""<HID::USB Gamepad >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""290c0ab7-47ad-4da3-a50f-6cdc41670630"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eff332f-d9c3-432d-acce-450f066feaf3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c7b8f28-014d-49cd-8094-80b411195c71"",
                    ""path"": ""<HID::USB Gamepad >/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5267c47-029c-43b6-9319-a542e8ff85b1"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47091fa4-9742-44a4-984d-ac9c1f919ea8"",
                    ""path"": ""<HID::USB Gamepad >/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""O"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a73a303a-ece4-4055-850e-14d17deda28d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""O"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4953cf0-4a1f-4674-bd52-ef1add132279"",
                    ""path"": ""<HID::USB Gamepad >/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72a1aa75-e73b-4d9e-9f84-924ea1e08818"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f28cc78d-11a7-4be1-8bbb-75a595be3efb"",
                    ""path"": ""<HID::USB Gamepad >/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ede3a8e7-a2c0-48df-8afb-cef6cd86b3e4"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6f65885-629f-4e17-99ee-89bb76c98c57"",
                    ""path"": ""<HID::USB Gamepad >/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41c6fc92-7654-4fbc-809e-4d9ba14c8a5b"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1afea78-4cde-4544-839b-fcff51e99e99"",
                    ""path"": ""<HID::USB Gamepad >/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03defbf5-2f75-4e22-91e4-e96956476210"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DefaultActionMap
        m_DefaultActionMap = asset.FindActionMap("DefaultActionMap", throwIfNotFound: true);
        m_DefaultActionMap_Up = m_DefaultActionMap.FindAction("Up", throwIfNotFound: true);
        m_DefaultActionMap_Down = m_DefaultActionMap.FindAction("Down", throwIfNotFound: true);
        m_DefaultActionMap_Left = m_DefaultActionMap.FindAction("Left", throwIfNotFound: true);
        m_DefaultActionMap_Right = m_DefaultActionMap.FindAction("Right", throwIfNotFound: true);
        m_DefaultActionMap_X = m_DefaultActionMap.FindAction("X", throwIfNotFound: true);
        m_DefaultActionMap_O = m_DefaultActionMap.FindAction("O", throwIfNotFound: true);
        m_DefaultActionMap_Triangle = m_DefaultActionMap.FindAction("Triangle", throwIfNotFound: true);
        m_DefaultActionMap_Square = m_DefaultActionMap.FindAction("Square", throwIfNotFound: true);
        m_DefaultActionMap_Select = m_DefaultActionMap.FindAction("Select", throwIfNotFound: true);
        m_DefaultActionMap_Start = m_DefaultActionMap.FindAction("Start", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // DefaultActionMap
    private readonly InputActionMap m_DefaultActionMap;
    private List<IDefaultActionMapActions> m_DefaultActionMapActionsCallbackInterfaces = new List<IDefaultActionMapActions>();
    private readonly InputAction m_DefaultActionMap_Up;
    private readonly InputAction m_DefaultActionMap_Down;
    private readonly InputAction m_DefaultActionMap_Left;
    private readonly InputAction m_DefaultActionMap_Right;
    private readonly InputAction m_DefaultActionMap_X;
    private readonly InputAction m_DefaultActionMap_O;
    private readonly InputAction m_DefaultActionMap_Triangle;
    private readonly InputAction m_DefaultActionMap_Square;
    private readonly InputAction m_DefaultActionMap_Select;
    private readonly InputAction m_DefaultActionMap_Start;
    public struct DefaultActionMapActions
    {
        private @DDR_Pad_Input m_Wrapper;
        public DefaultActionMapActions(@DDR_Pad_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_DefaultActionMap_Up;
        public InputAction @Down => m_Wrapper.m_DefaultActionMap_Down;
        public InputAction @Left => m_Wrapper.m_DefaultActionMap_Left;
        public InputAction @Right => m_Wrapper.m_DefaultActionMap_Right;
        public InputAction @X => m_Wrapper.m_DefaultActionMap_X;
        public InputAction @O => m_Wrapper.m_DefaultActionMap_O;
        public InputAction @Triangle => m_Wrapper.m_DefaultActionMap_Triangle;
        public InputAction @Square => m_Wrapper.m_DefaultActionMap_Square;
        public InputAction @Select => m_Wrapper.m_DefaultActionMap_Select;
        public InputAction @Start => m_Wrapper.m_DefaultActionMap_Start;
        public InputActionMap Get() { return m_Wrapper.m_DefaultActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Add(instance);
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @Left.started += instance.OnLeft;
            @Left.performed += instance.OnLeft;
            @Left.canceled += instance.OnLeft;
            @Right.started += instance.OnRight;
            @Right.performed += instance.OnRight;
            @Right.canceled += instance.OnRight;
            @X.started += instance.OnX;
            @X.performed += instance.OnX;
            @X.canceled += instance.OnX;
            @O.started += instance.OnO;
            @O.performed += instance.OnO;
            @O.canceled += instance.OnO;
            @Triangle.started += instance.OnTriangle;
            @Triangle.performed += instance.OnTriangle;
            @Triangle.canceled += instance.OnTriangle;
            @Square.started += instance.OnSquare;
            @Square.performed += instance.OnSquare;
            @Square.canceled += instance.OnSquare;
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @Start.started += instance.OnStart;
            @Start.performed += instance.OnStart;
            @Start.canceled += instance.OnStart;
        }

        private void UnregisterCallbacks(IDefaultActionMapActions instance)
        {
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @Left.started -= instance.OnLeft;
            @Left.performed -= instance.OnLeft;
            @Left.canceled -= instance.OnLeft;
            @Right.started -= instance.OnRight;
            @Right.performed -= instance.OnRight;
            @Right.canceled -= instance.OnRight;
            @X.started -= instance.OnX;
            @X.performed -= instance.OnX;
            @X.canceled -= instance.OnX;
            @O.started -= instance.OnO;
            @O.performed -= instance.OnO;
            @O.canceled -= instance.OnO;
            @Triangle.started -= instance.OnTriangle;
            @Triangle.performed -= instance.OnTriangle;
            @Triangle.canceled -= instance.OnTriangle;
            @Square.started -= instance.OnSquare;
            @Square.performed -= instance.OnSquare;
            @Square.canceled -= instance.OnSquare;
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @Start.started -= instance.OnStart;
            @Start.performed -= instance.OnStart;
            @Start.canceled -= instance.OnStart;
        }

        public void RemoveCallbacks(IDefaultActionMapActions instance)
        {
            if (m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultActionMapActions @DefaultActionMap => new DefaultActionMapActions(this);
    public interface IDefaultActionMapActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnO(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
