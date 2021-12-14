// GENERATED AUTOMATICALLY FROM 'Assets/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""DPad"",
            ""id"": ""2700388e-44e4-446b-8dbd-a5f26b443832"",
            ""actions"": [
                {
                    ""name"": ""DpadMove"",
                    ""type"": ""Button"",
                    ""id"": ""471f1fc2-9bda-488e-b1ff-458d80bfefc1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""79a9ec33-5a70-4815-95a5-4f75d4b33f08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""9eb64536-a3ab-49f0-959a-dab1a522ca92"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3d910022-d9cd-41d7-afff-dd040abb053e"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a35b2b79-0f33-4fd1-92ae-69fc55a97f76"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""3ac70ad8-31e3-4e71-8331-d44480aed5d1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5d88eeaa-dbc9-4e8a-b4e7-ad7f7c4637a7"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""93ddd6c5-b325-48b8-970e-7edff6908e1d"",
                    ""path"": ""<HID::Unknown DUALSHOCK 4 Wireless Controller>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""94fcf2b8-462c-4947-b48e-73709dacb7bb"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DPad
        m_DPad = asset.FindActionMap("DPad", throwIfNotFound: true);
        m_DPad_DpadMove = m_DPad.FindAction("DpadMove", throwIfNotFound: true);
        m_DPad_Select = m_DPad.FindAction("Select", throwIfNotFound: true);
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

    // DPad
    private readonly InputActionMap m_DPad;
    private IDPadActions m_DPadActionsCallbackInterface;
    private readonly InputAction m_DPad_DpadMove;
    private readonly InputAction m_DPad_Select;
    public struct DPadActions
    {
        private @Controller m_Wrapper;
        public DPadActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @DpadMove => m_Wrapper.m_DPad_DpadMove;
        public InputAction @Select => m_Wrapper.m_DPad_Select;
        public InputActionMap Get() { return m_Wrapper.m_DPad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DPadActions set) { return set.Get(); }
        public void SetCallbacks(IDPadActions instance)
        {
            if (m_Wrapper.m_DPadActionsCallbackInterface != null)
            {
                @DpadMove.started -= m_Wrapper.m_DPadActionsCallbackInterface.OnDpadMove;
                @DpadMove.performed -= m_Wrapper.m_DPadActionsCallbackInterface.OnDpadMove;
                @DpadMove.canceled -= m_Wrapper.m_DPadActionsCallbackInterface.OnDpadMove;
                @Select.started -= m_Wrapper.m_DPadActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_DPadActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_DPadActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_DPadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DpadMove.started += instance.OnDpadMove;
                @DpadMove.performed += instance.OnDpadMove;
                @DpadMove.canceled += instance.OnDpadMove;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public DPadActions @DPad => new DPadActions(this);
    public interface IDPadActions
    {
        void OnDpadMove(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
