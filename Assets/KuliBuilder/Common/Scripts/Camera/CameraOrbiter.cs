using System;
using System.Collections;
using System.Collections.Generic;
using KuliBuilder.Common.Scripts.Managers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KuliBuilder.Common.Scripts
{
    public class CameraOrbiter : MonoBehaviour
    {

        private Vector3 startPlaneDownPos;
        private Vector2 startScreenDownPos;
        
        private Vector2 deltaFiringPos;
        private Vector2 prevFiringPos;

        private Camera camera;

        public float PlaneDistanceMultiplier = 5;
        public float RotationFactor = 5;
        public float ZoomFactor = 3;

        private Plane movementPlane;
        

        private Vector3 anchorPosition;
        
        public enum ToolType
        {
            None = 0,
            Pan = 1,
            Rotate = 2
        }

        public ToolType CurrentToolType;

        private BuilderInputAction action;
        
        private void Start()
        {
            
            action = new BuilderInputAction();
            
            action.Desktop.Aim.performed += AimPerformed;
            action.Desktop.Pan.performed += PanPerformed;
            action.Desktop.Rotate.performed += RotatePerformed;
            action.Desktop.Zoom.performed += ZoomPerfomed;
            
            
            action.Enable();

            camera = GetComponent<Camera>();
        }

        private void ZoomPerfomed(InputAction.CallbackContext obj)
        {
            var value = obj.ReadValue<Vector2>();
            if (value.y > 0)
            {
                this.transform.position += this.transform.forward * ZoomFactor;
            }else if (value.y < 0)
            {
                this.transform.position -= this.transform.forward * ZoomFactor;
            }
        }

        private void RotatePerformed(InputAction.CallbackContext obj)
        {
            var downPos = action.Desktop.Aim.ReadValue<Vector2>();
            
            startScreenDownPos = downPos;
            startPlaneDownPos = GetGroundPosition(downPos);
            prevFiringPos = downPos;
        }

        private void PanPerformed(InputAction.CallbackContext obj)
        {
            movementPlane = new Plane(camera.transform.forward, camera.transform.forward * PlaneDistanceMultiplier );

            var downPos = action.Desktop.Aim.ReadValue<Vector2>();
            
            startScreenDownPos = downPos;
            startPlaneDownPos = GetGroundPosition(downPos);
            prevFiringPos = downPos;
        }
        

        private void AimPerformed(InputAction.CallbackContext obj)
        {
            // Debug.Log("Camera aim");
        }

        // Update is called once per frame
        void Update()
        {

            if (Keyboard.current.qKey.isPressed)
            {
                this.CurrentToolType = ToolType.Pan;
            }else if (Keyboard.current.wKey.isPressed)
            {
                this.CurrentToolType = ToolType.Rotate;
            }
            
            if (action.Desktop.Pan.phase == InputActionPhase.Started)
            {
                // pan
                var firingPos = action.Desktop.Aim.ReadValue<Vector2>();
                this.transform.position += startPlaneDownPos - GetGroundPosition(firingPos);
            }

            if (action.Desktop.Rotate.phase == InputActionPhase.Started)
            {
                // rotate
                var firingPos = action.Desktop.Aim.ReadValue<Vector2>();
                deltaFiringPos = prevFiringPos - firingPos;
                prevFiringPos = firingPos;

                var prevRotation = this.transform.localRotation.eulerAngles;
                float xAxisRotation = prevRotation.x + deltaFiringPos.y / RotationFactor;
                float yAxisRotation = prevRotation.y - deltaFiringPos.x / RotationFactor;
                this.transform.localRotation =  Quaternion.Euler(xAxisRotation,yAxisRotation,0);
            }
        }

        private Vector3 GetGroundPosition(Vector3 inputPos)
        {
            var dragRay = camera.ScreenPointToRay(inputPos);
            
            movementPlane.Raycast(dragRay, out var pos);
            var currentPlaneDownPos = dragRay.GetPoint(pos);

            return currentPlaneDownPos;
        }
    }
}