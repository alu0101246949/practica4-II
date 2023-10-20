/*
 * CubeController.cs
 * 
 * Este script se adjunta al cubo y permite al jugador mover el objeto en la escena.
 * También detecta colisiones y aproximaciones con otros objetos y desencadena acciones relevantes.
 */

using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Transform cylinderTransform;
    public float proximityThreshold = 3.0f;

    private void Update()
    {
        // Control simple para mover el cubo
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Detectar aproximación al cilindro
        float distance = Vector3.Distance(transform.position, cylinderTransform.position);
        if (distance <= proximityThreshold)
        {
            // Aquí puedes desencadenar acciones específicas al acercarte al cilindro
        }
    }
}
