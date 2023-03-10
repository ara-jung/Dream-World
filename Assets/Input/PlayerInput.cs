//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Input/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""OnFoot"",
            ""id"": ""0d805d1c-4e6f-447a-8385-2ff2b3f79965"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""998f8885-1190-4f74-82fb-a8bd273c5d3d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a2236aad-296c-469a-91c5-856a1e815f4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""e2ff4359-8429-45e2-b558-8b21a833c73e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""OpenCamera"",
                    ""type"": ""Button"",
                    ""id"": ""459cd9dd-372a-47ac-834b-f81c43fae1e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TakePicture"",
                    ""type"": ""Button"",
                    ""id"": ""572a7fec-889c-421a-8d2d-a08e056293d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ArrowDown"",
                    ""type"": ""Button"",
                    ""id"": ""f2b4d2ce-9e57-478b-8b65-755e83e783bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ArrowUp"",
                    ""type"": ""Button"",
                    ""id"": ""26d5c3d5-738c-4611-b98e-4be961cc3175"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ArrowLeft"",
                    ""type"": ""Button"",
                    ""id"": ""93d45140-e4f6-4910-b335-51c56e880d1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ArrowRight"",
                    ""type"": ""Button"",
                    ""id"": ""445d4e15-84b1-4cb7-b9c0-9c51f2880396"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3a64d894-0851-4bce-9716-cc7f27dad7c1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a04c414e-037b-4859-88c9-356bcc435557"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""292fdf23-9280-4561-8890-e33ac0185c86"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""26fc1992-eb41-494e-a6e9-25a0a1296748"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""86a5baeb-c42b-426f-9bd9-db9afedcf7af"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dedd0408-523b-42ea-adf3-651f771f94fa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""399a38aa-c815-48c6-bf3a-a55368df8a92"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f210d55-75f6-43d7-972c-8b1b50a50857"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4606b76-e55a-4a41-8a0b-cb769ae8ff45"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakePicture"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01309039-9504-4fc1-b405-8e677675cf3d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5db08e9-7f4b-417c-8463-f71505db7615"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77fcd3ab-eaca-4f6b-85c7-a30ebaf521f8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""722dd11d-088f-428a-b6d7-bd74153aeecf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // OnFoot
        m_OnFoot = asset.FindActionMap("OnFoot", throwIfNotFound: true);
        m_OnFoot_Movement = m_OnFoot.FindAction("Movement", throwIfNotFound: true);
        m_OnFoot_Jump = m_OnFoot.FindAction("Jump", throwIfNotFound: true);
        m_OnFoot_Look = m_OnFoot.FindAction("Look", throwIfNotFound: true);
        m_OnFoot_OpenCamera = m_OnFoot.FindAction("OpenCamera", throwIfNotFound: true);
        m_OnFoot_TakePicture = m_OnFoot.FindAction("TakePicture", throwIfNotFound: true);
        m_OnFoot_ArrowDown = m_OnFoot.FindAction("ArrowDown", throwIfNotFound: true);
        m_OnFoot_ArrowUp = m_OnFoot.FindAction("ArrowUp", throwIfNotFound: true);
        m_OnFoot_ArrowLeft = m_OnFoot.FindAction("ArrowLeft", throwIfNotFound: true);
        m_OnFoot_ArrowRight = m_OnFoot.FindAction("ArrowRight", throwIfNotFound: true);
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

    // OnFoot
    private readonly InputActionMap m_OnFoot;
    private IOnFootActions m_OnFootActionsCallbackInterface;
    private readonly InputAction m_OnFoot_Movement;
    private readonly InputAction m_OnFoot_Jump;
    private readonly InputAction m_OnFoot_Look;
    private readonly InputAction m_OnFoot_OpenCamera;
    private readonly InputAction m_OnFoot_TakePicture;
    private readonly InputAction m_OnFoot_ArrowDown;
    private readonly InputAction m_OnFoot_ArrowUp;
    private readonly InputAction m_OnFoot_ArrowLeft;
    private readonly InputAction m_OnFoot_ArrowRight;
    public struct OnFootActions
    {
        private @PlayerInput m_Wrapper;
        public OnFootActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_OnFoot_Movement;
        public InputAction @Jump => m_Wrapper.m_OnFoot_Jump;
        public InputAction @Look => m_Wrapper.m_OnFoot_Look;
        public InputAction @OpenCamera => m_Wrapper.m_OnFoot_OpenCamera;
        public InputAction @TakePicture => m_Wrapper.m_OnFoot_TakePicture;
        public InputAction @ArrowDown => m_Wrapper.m_OnFoot_ArrowDown;
        public InputAction @ArrowUp => m_Wrapper.m_OnFoot_ArrowUp;
        public InputAction @ArrowLeft => m_Wrapper.m_OnFoot_ArrowLeft;
        public InputAction @ArrowRight => m_Wrapper.m_OnFoot_ArrowRight;
        public InputActionMap Get() { return m_Wrapper.m_OnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnFootActions set) { return set.Get(); }
        public void SetCallbacks(IOnFootActions instance)
        {
            if (m_Wrapper.m_OnFootActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @OpenCamera.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnOpenCamera;
                @OpenCamera.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnOpenCamera;
                @OpenCamera.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnOpenCamera;
                @TakePicture.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnTakePicture;
                @TakePicture.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnTakePicture;
                @TakePicture.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnTakePicture;
                @ArrowDown.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowDown;
                @ArrowDown.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowDown;
                @ArrowDown.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowDown;
                @ArrowUp.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowUp;
                @ArrowUp.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowUp;
                @ArrowUp.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowUp;
                @ArrowLeft.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowLeft;
                @ArrowLeft.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowLeft;
                @ArrowLeft.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowLeft;
                @ArrowRight.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowRight;
                @ArrowRight.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowRight;
                @ArrowRight.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnArrowRight;
            }
            m_Wrapper.m_OnFootActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @OpenCamera.started += instance.OnOpenCamera;
                @OpenCamera.performed += instance.OnOpenCamera;
                @OpenCamera.canceled += instance.OnOpenCamera;
                @TakePicture.started += instance.OnTakePicture;
                @TakePicture.performed += instance.OnTakePicture;
                @TakePicture.canceled += instance.OnTakePicture;
                @ArrowDown.started += instance.OnArrowDown;
                @ArrowDown.performed += instance.OnArrowDown;
                @ArrowDown.canceled += instance.OnArrowDown;
                @ArrowUp.started += instance.OnArrowUp;
                @ArrowUp.performed += instance.OnArrowUp;
                @ArrowUp.canceled += instance.OnArrowUp;
                @ArrowLeft.started += instance.OnArrowLeft;
                @ArrowLeft.performed += instance.OnArrowLeft;
                @ArrowLeft.canceled += instance.OnArrowLeft;
                @ArrowRight.started += instance.OnArrowRight;
                @ArrowRight.performed += instance.OnArrowRight;
                @ArrowRight.canceled += instance.OnArrowRight;
            }
        }
    }
    public OnFootActions @OnFoot => new OnFootActions(this);
    public interface IOnFootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnOpenCamera(InputAction.CallbackContext context);
        void OnTakePicture(InputAction.CallbackContext context);
        void OnArrowDown(InputAction.CallbackContext context);
        void OnArrowUp(InputAction.CallbackContext context);
        void OnArrowLeft(InputAction.CallbackContext context);
        void OnArrowRight(InputAction.CallbackContext context);
    }
}
