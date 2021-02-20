using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KuliBuilder.Common.Scripts.Managers
{
    [RequireComponent(typeof(BuilderManager))]
    public class BuilderInput:MonoBehaviour
    {
        private BuilderManager builderManager;

        private Vector2 currentScreenPosition;



        public InputActionAsset inputAsset;

        private InputAction aim;
        private InputAction put;

        private void Start()
        {
            builderManager = GetComponent<BuilderManager>();

            var desktopMap = inputAsset.FindActionMap("Desktop");
            
            aim = desktopMap.FindAction("Aim");
            put = desktopMap.FindAction("Put");
            
            aim.performed += Aim;
            put.performed += Put;

            inputAsset.Enable();


        }

        private void Put(InputAction.CallbackContext obj)
        {
            var position = aim.ReadValue<Vector2>();
            currentScreenPosition = position;
            builderManager.CreateItem(currentScreenPosition);
        }
        
        public void Aim(InputAction.CallbackContext context)
        {
            currentScreenPosition = context.ReadValue<Vector2>();
        }

    }
}