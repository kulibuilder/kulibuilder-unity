using System;
using System.Collections;
using System.Collections.Generic;
using KuliBuilder.Common.Scripts.Managers;
using UnityEditor;
using UnityEngine;

public class BuilderManager : MonoBehaviour
{

    public Camera TargetCamera;
    public LayerMask TargetLayer;
    
    public List<ItemModel> Items = new List<ItemModel>();
    private ItemModel CurrentItem;
    
    // Start is called before the first frame update
    void Start()
    {
        if (TargetCamera == null)
        {
            this.TargetCamera = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
    }

    public void CreateItem(Vector2 screenPosition)
    {
        var cameraRay = TargetCamera.ScreenPointToRay(screenPosition);
        if (Physics.Raycast(cameraRay, out var hitInfo, TargetLayer))
        {
            var item = InstantiateItem();
            item.SetActive(true);

            var targetPosition = hitInfo.point;

            
            var bottomPos = GetMostBottomCollider(item);
            
            item.transform.position = targetPosition - (Vector3.up * bottomPos.y);

            item.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitInfo.normal);

        }
    }

    GameObject InstantiateItem()
    {
        CurrentItem = this.Items[0];
        var newObject = Instantiate(CurrentItem.Prefab);

        return newObject;
    }

    private Vector3 startPos;
    private Vector3 endPos;
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(startPos, endPos);
    }

    Vector3 GetMostBottomCollider(GameObject item)
    {
        var collider = item.GetComponent<Collider>();

        if (collider != null)
        {
            // var rayStartPos = item.transform.position;
            // Ray ray = new Ray(rayStartPos, Vector3.down);
            //
            // this.startPos = rayStartPos;
            // this.endPos = Vector3.down * 5;
            //
            // if (Physics.Raycast(ray, out var hitInfo, TargetLayer))
            // {
            //     return hitInfo.point;
            // }
            
            Vector3 bottom = new Vector3(0, -collider.bounds.max.y,0);
            return bottom;

        }
        else
        {
            var meshCollider = item.GetComponent<MeshCollider>();
            var vertices = meshCollider.sharedMesh.vertices;
            var bottomVertex = new Vector3(0, float.PositiveInfinity, 0);

            for (int i = 0; i < vertices.Length; i++)
            {
                Vector3 vert = item.transform.TransformPoint(vertices[i]);
                if (vert.y < bottomVertex.y)
                {
                    bottomVertex = vert;
                }
            }

            return bottomVertex;

        }

        return Vector3.zero;
    }
}
