using UnityEngine;

public class SphereResponse : MonoBehaviour
{
    public enum SphereType { Type1, Type2 }
    public SphereType sphereType;
    public Color type1Color = Color.red;
    public Transform cylinderTransform;

    private void Start()
    {
        CylinderCollision.CubeCollidedWithCylinder += RespondToCollision;
    }

    private void OnDestroy()
    {
        CylinderCollision.CubeCollidedWithCylinder -= RespondToCollision;
    }

    void RespondToCollision()
    {
        if (sphereType == SphereType.Type1)
        {
            // Cambiar el color de la esfera
            GetComponent<Renderer>().material.color = type1Color;
        }
        else if (sphereType == SphereType.Type2)
        {
            // Desplazar hacia el cilindro
            transform.position = Vector3.MoveTowards(transform.position, cylinderTransform.position, 1f);
        }
    }
}