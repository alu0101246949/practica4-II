using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Velocidad de movimiento, puedes ajustarla desde el Inspector si lo adjuntas a un objeto.

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Flechas izquierda/derecha o teclas A/D
        float vertical = Input.GetAxis("Vertical");     // Flechas arriba/abajo o teclas W/S

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
