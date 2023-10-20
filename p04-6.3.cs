/*
 * ScoreUI.cs
 * 
 * Este script se adjunta a un objeto manager en la escena y gestiona la puntuación del jugador.
 * Actualiza la interfaz de usuario para mostrar la puntuación actual.
 */

using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Método para aumentar la puntuación y actualizar la UI
    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = $"Score: {score}";
    }
}
