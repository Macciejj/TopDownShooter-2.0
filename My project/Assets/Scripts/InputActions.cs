// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""InGameActionMap"",
            ""id"": ""60bba5be-e5d9-48c5-9ff4-a43ae622f165"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e0b0abd9-2a1e-41ff-a937-4b8e3aab3669"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""68d5e53f-3f50-487d-9ef6-623285f08ca4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f27f4c7a-8dde-4890-b04f-c6d85ca06caa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""061766df-49c3-47c5-8948-f6f370d1c358"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""78124cba-5170-4372-8a2c-e45328270231"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d505a1a5-7a6f-4af5-bb03-a942fc35598c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGameActionMap
        m_InGameActionMap = asset.FindActionMap("InGameActionMap", throwIfNotFound: true);
        m_InGameActionMap_Move = m_InGameActionMap.FindAction("Move", throwIfNotFound: true);
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

    // InGameActionMap
    private readonly InputActionMap m_InGameActionMap;
    private IInGameActionMapActions m_InGameActionMapActionsCallbackInterface;
    private readonly InputAction m_InGameActionMap_Move;
    public struct InGameActionMapActions
    {
        private @InputActions m_Wrapper;
        public InGameActionMapActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_InGameActionMap_Move;
        public InputActionMap Get() { return m_Wrapper.m_InGameActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActionMapActions instance)
        {
            if (m_Wrapper.m_InGameActionMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_InGameActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public InGameActionMapActions @InGameActionMap => new InGameActionMapActions(this);
    public interface IInGameActionMapActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
