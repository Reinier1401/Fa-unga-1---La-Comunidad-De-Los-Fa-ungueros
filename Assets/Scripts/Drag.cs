using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 StartPosition;
    public Transform DropZone;
    private bool IsOverDropzone;
    private bool arrastrando = false;
    private Vector3 offset;
    private Plane plane;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MELEE"))
        {
            IsOverDropzone = true;
            OrganizarCarta(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
       IsOverDropzone = false;
    }
    void OrganizarCarta(GameObject carta)
    {
        carta.transform.position = DropZone.position;

    }
    private void OnMouseDown()
    {
        StartPosition = transform.position; 
        plane = new Plane(Camera.main.transform.forward, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance;
            
        if(plane.Raycast(ray,out distance))
        {
            offset = transform.position - ray.GetPoint(distance);
            arrastrando = true;
        }
    }
    private void OnMouseDrag()
    {
        if (arrastrando)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;
            if(plane.Raycast(ray, out distance))
            {
                transform.position = ray.GetPoint(distance) + offset;
            }
        }
    }
    private void OnMouseUp()
    {
        arrastrando = false;
        if (IsOverDropzone)
        {
            
        }
        else
        {
           transform.position = StartPosition;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}