using UnityEngine;
using TMPro; // Necesario para TextMeshPro

public class CubeCollector : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencia al componente TextMeshProUGUI en el UI

    private int score = 0;

    private void Start()
    {
        UpdateScoreText(); // Mostrar la puntuación inicial
    }

    private void OnTriggerEnter(Collider other)
    {
        // Comprobando colisiones con esferas de Tipo1
        if (other.CompareTag("Tipo1"))
        {
            score += 5;
            Destroy(other.gameObject);
        }

        // Comprobando colisiones con esferas de Tipo2
        if (other.CompareTag("Tipo2"))
        {
            score += 10;
            Destroy(other.gameObject);
        }

        UpdateScoreText(); // Actualizar el texto de puntuación cada vez que cambia
    }

    // Función para actualizar el texto de la puntuación
    private void UpdateScoreText()
    {
        scoreText.text = "Puntuación: " + score;
    }
}
