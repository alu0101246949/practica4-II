using UnityEngine;

public class SphereBehaviour1 : MonoBehaviour
{
    public Transform cylinderTransform;
    public float moveSpeed = 2.0f;
    private bool shouldMoveToCylinder = false;

    private void Update()
    {
        if (shouldMoveToCylinder && gameObject.CompareTag("Tipo2"))
        {
            MoveTowardsCylinder();
        }
    }

    public void ReactToCollision()
    {
        if (gameObject.CompareTag("Tipo1"))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (gameObject.CompareTag("Tipo2"))
        {
            shouldMoveToCylinder = true;
        }
    }

    void MoveTowardsCylinder()
    {
        Vector3 targetPosition = new Vector3(cylinderTransform.position.x, transform.position.y, cylinderTransform.position.z);
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;

        // Opcional: Detener el movimiento si está suficientemente cerca del cilindro.
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            shouldMoveToCylinder = false;
        }
    }
}
