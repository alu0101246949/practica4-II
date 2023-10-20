/*
 * SphereBehavior.cs
 * 
 * Este script se adjunta a las esferas y define su comportamiento en respuesta a las acciones del cubo.
 * Dependiendo de su tipo, una esfera puede cambiar de color, moverse hacia un objetivo o realizar otras acciones.
 */

using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    public enum SphereType { Type1, Type2 }
    public SphereType sphereType;

    // Lógica específica para responder a las acciones del cubo
    public void ReactToCubeAction()
    {
        if (sphereType == SphereType.Type1)
        {
            // Cambiar color y saltar, por ejemplo
        }
        else if (sphereType == SphereType.Type2)
        {
            // Mover hacia un objetivo u orientarse hacia un objeto, por ejemplo
        }
    }
}
