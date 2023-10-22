using UnityEngine;

public class CubeProximityBehavior : MonoBehaviour
{
    public Transform cylinderTransform;
    public float proximityThreshold = 3.0f; // Distancia a la que se activan los efectos
    public Transform objectToLookAt; // Objeto hacia el que las esferas Tipo2 se orientarán
    public Color colorForType1 = Color.red; // Color al que cambiarán las esferas Tipo1
    public float jumpForce = 5.0f; // Fuerza del salto para esferas Tipo1

    private bool effectsActivated = false;

    void Update()
    {
        float distanceToCylinder = Vector3.Distance(transform.position, cylinderTransform.position);

        if (distanceToCylinder <= proximityThreshold && !effectsActivated)
        {
            ActivateEffects();
            effectsActivated = true;
        }
        else if (distanceToCylinder > proximityThreshold && effectsActivated)
        {
            effectsActivated = false;
        }
    }

    void ActivateEffects()
    {
        // Cambiar el color y hacer saltar las esferas Tipo1
        foreach (var sphere in GameObject.FindGameObjectsWithTag("Tipo1"))
        {
            var renderer = sphere.GetComponent<Renderer>();
            if (renderer)
            {
                renderer.material.color = colorForType1;
            }

            var rb = sphere.GetComponent<Rigidbody>();
            if (rb)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }

        // Orientar las esferas Tipo2 hacia el objeto especificado
        foreach (var sphere in GameObject.FindGameObjectsWithTag("Tipo2"))
        {
            sphere.transform.LookAt(objectToLookAt);
        }
    }
}
