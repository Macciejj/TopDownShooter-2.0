// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

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
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Value"",
                    ""id"": ""023b3ebc-4ed9-43f7-a5d2-d06b009a20d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""4fd82e67-fb1b-4c92-af87-58de4c0ff99a"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""53215b16-2d78-4d08-ae74-193fe8f44c79"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c87ce3a5-72dd-479b-897e-9f79242f99f6"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGameActionMap
        m_InGameActionMap = asset.FindActionMap("InGameActionMap", throwIfNotFound: true);
        m_InGameActionMap_Move = m_InGameActionMap.FindAction("Move", throwIfNotFound: true);
        m_InGameActionMap_Shot = m_InGameActionMap.FindAction("Shot", throwIfNotFound: true);
        m_InGameActionMap_Rotate = m_InGameActionMap.FindAction("Rotate", throwIfNotFound: true);
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
    private readonly InputAction m_InGameActionMap_Shot;
    private readonly InputAction m_InGameActionMap_Rotate;
    public struct InGameActionMapActions
    {
        private @InputActions m_Wrapper;
        public InGameActionMapActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_InGameActionMap_Move;
        public InputAction @Shot => m_Wrapper.m_InGameActionMap_Shot;
        public InputAction @Rotate => m_Wrapper.m_InGameActionMap_Rotate;
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
                @Shot.started -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnShot;
                @Rotate.started -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_InGameActionMapActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_InGameActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public InGameActionMapActions @InGameActionMap => new InGameActionMapActions(this);
    public interface IInGameActionMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
