// GENERATED AUTOMATICALLY FROM 'Assets/KuliBuilder/InputSystems/BuilderInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BuilderInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BuilderInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BuilderInputAction"",
    ""maps"": [
        {
            ""name"": ""Desktop"",
            ""id"": ""9bf9adc0-782a-49c0-97d9-5b8e67657535"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""86958e2e-c394-45e4-b4f6-ea62d55bded1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""a7ae0a83-fd90-42c5-baa3-348bf4cf573b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pan"",
                    ""type"": ""Button"",
                    ""id"": ""431020d1-66f6-4d49-bde0-1afb6d2c77c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""61c2fa7a-5444-4068-bafe-97f3e4c93ad5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard"",
                    ""type"": ""Value"",
                    ""id"": ""44b40985-4211-43ed-859f-4d0ec006f5e3"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""40fd6772-29e3-4eb4-86ea-d0177e3fe94d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e72b5d1e-64f7-481c-80fe-65afb49148f1"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f483bcc4-15f6-4851-b619-2687d027b49b"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a5ddd1f-ba90-4f6c-bd6f-c74a1355b65b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4157b4ac-0435-4b9e-bdc8-c42978b1a1bb"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""884527f1-380e-4b44-b33a-0920bb83f913"",
                    ""path"": ""<Sensor>"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93897bbe-bb7f-4f74-959c-8ab95cd4d678"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8580b452-d5cc-4380-a8ce-8c74b0befc39"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Desktop
        m_Desktop = asset.FindActionMap("Desktop", throwIfNotFound: true);
        m_Desktop_Aim = m_Desktop.FindAction("Aim", throwIfNotFound: true);
        m_Desktop_Fire = m_Desktop.FindAction("Fire", throwIfNotFound: true);
        m_Desktop_Pan = m_Desktop.FindAction("Pan", throwIfNotFound: true);
        m_Desktop_Rotate = m_Desktop.FindAction("Rotate", throwIfNotFound: true);
        m_Desktop_Keyboard = m_Desktop.FindAction("Keyboard", throwIfNotFound: true);
        m_Desktop_Zoom = m_Desktop.FindAction("Zoom", throwIfNotFound: true);
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

    // Desktop
    private readonly InputActionMap m_Desktop;
    private IDesktopActions m_DesktopActionsCallbackInterface;
    private readonly InputAction m_Desktop_Aim;
    private readonly InputAction m_Desktop_Fire;
    private readonly InputAction m_Desktop_Pan;
    private readonly InputAction m_Desktop_Rotate;
    private readonly InputAction m_Desktop_Keyboard;
    private readonly InputAction m_Desktop_Zoom;
    public struct DesktopActions
    {
        private @BuilderInputAction m_Wrapper;
        public DesktopActions(@BuilderInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_Desktop_Aim;
        public InputAction @Fire => m_Wrapper.m_Desktop_Fire;
        public InputAction @Pan => m_Wrapper.m_Desktop_Pan;
        public InputAction @Rotate => m_Wrapper.m_Desktop_Rotate;
        public InputAction @Keyboard => m_Wrapper.m_Desktop_Keyboard;
        public InputAction @Zoom => m_Wrapper.m_Desktop_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Desktop; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DesktopActions set) { return set.Get(); }
        public void SetCallbacks(IDesktopActions instance)
        {
            if (m_Wrapper.m_DesktopActionsCallbackInterface != null)
            {
                @Aim.started -= m_Wrapper.m_DesktopActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_DesktopActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_DesktopActionsCallbackInterface.OnAim;
                @Fire.started -= m_Wrapper.m_DesktopActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_DesktopActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_DesktopActionsCallbackInterface.OnFire;
                @Pan.started -= m_Wrapper.m_DesktopActionsCallbackInterface.OnPan;
                @Pan.performed -= m_Wrapper.m_DesktopActionsCallbackInterface.OnPan;
                @Pan.canceled -= m_Wrapper.m_DesktopActionsCallbackInterface.OnPan;
                @Rotate.started -= m_Wrapper.m_DesktopActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_DesktopActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_DesktopActionsCallbackInterface.OnRotate;
                @Keyboard.started -= m_Wrapper.m_DesktopActionsCallbackInterface.OnKeyboard;
                @Keyboard.performed -= m_Wrapper.m_DesktopActionsCallbackInterface.OnKeyboard;
                @Keyboard.canceled -= m_Wrapper.m_DesktopActionsCallbackInterface.OnKeyboard;
                @Zoom.started -= m_Wrapper.m_DesktopActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_DesktopActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_DesktopActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_DesktopActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Pan.started += instance.OnPan;
                @Pan.performed += instance.OnPan;
                @Pan.canceled += instance.OnPan;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Keyboard.started += instance.OnKeyboard;
                @Keyboard.performed += instance.OnKeyboard;
                @Keyboard.canceled += instance.OnKeyboard;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public DesktopActions @Desktop => new DesktopActions(this);
    public interface IDesktopActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnPan(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnKeyboard(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}
