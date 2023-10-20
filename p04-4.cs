using UnityEngine;

public class CubeScore : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SphereType1"))
        {
            score += 5; // Suma 5 puntos por esfera del tipo 1
            Destroy(other.gameObject); // Elimina la esfera recogida de la escena
        }
        else if (other.CompareTag("SphereType2"))
        {
            score += 10; // Suma 10 puntos por esfera del tipo 2
            Destroy(other.gameObject); // Elimina la esfera recogida de la escena
        }

        Debug.Log($"Score: {score}"); // Muestra la puntuación actual en la consola
    }
}
