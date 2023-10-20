using UnityEngine;

public class CubeApproach : MonoBehaviour
{
    public Transform cylinderTransform;
    public float proximityThreshold = 3.0f; // Distancia a la que se desencadenan los comportamientos
    public Color newColor = Color.blue; // Nuevo color para las esferas del grupo 1
    public float jumpForce = 5.0f; // Fuerza de salto para las esferas del grupo 1
    public Transform referenceObject; // Objeto de referencia hacia el cual se orientarán las esferas del grupo 2

    private bool actionsTriggered = false;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, cylinderTransform.position);
        
        if (distance <= proximityThreshold && !actionsTriggered)
        {
            actionsTriggered = true; // Para que las acciones solo se desencadenen una vez

            // Cambia el color y haz saltar las esferas del grupo 1
            foreach (GameObject sphere in GameObject.FindGameObjectsWithTag("SphereType1"))
            {
                sphere.GetComponent<Renderer>().material.color = newColor;
                Rigidbody rb = sphere.GetComponent<Rigidbody>();
                if (rb)
                {
                    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                }
            }

            // Orienta las esferas del grupo 2 hacia el objeto de referencia
            foreach (GameObject sphere in GameObject.FindGameObjectsWithTag("SphereType2"))
            {
                sphere.transform.LookAt(referenceObject);
            }
        }
    }
}
