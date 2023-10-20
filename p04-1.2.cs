using UnityEngine;
using System;

public class CylinderCollision : MonoBehaviour
{
    public static event Action CubeCollidedWithCylinder;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cubo"))
        {
            CubeCollidedWithCylinder?.Invoke();
        }
    }
}