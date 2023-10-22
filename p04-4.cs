using UnityEngine;

public class CubeCollector1 : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Comprobando colisiones con esferas de Tipo1
        if (other.CompareTag("Tipo1"))
        {
            score += 5;
            Destroy(other.gameObject); // Destruye la esfera después de recogerla
        }

        // Comprobando colisiones con esferas de Tipo2
        if (other.CompareTag("Tipo2"))
        {
            score += 10;
            Destroy(other.gameObject); // Destruye la esfera después de recogerla
        }

        // Mostrar la puntuación en la consola
        Debug.Log("Puntuación: " + score);
    }
}
