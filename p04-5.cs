using UnityEngine;
using UnityEngine.UI;

public class CubeScoreUI : MonoBehaviour
{
    private int score = 0;
    public Text scoreText; // Referencia al componente de texto

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SphereType1"))
        {
            score += 5;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("SphereType2"))
        {
            score += 10;
            Destroy(other.gameObject);
        }

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = $"Score: {score}"; // Actualiza el texto del componente Text con la puntuación actual
    }
}
