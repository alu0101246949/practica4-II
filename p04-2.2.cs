using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    public Transform cylinderTransform;
    public float moveSpeed = 2.0f;
    private bool shouldMoveToCylinder = false;
    public float growSize = 1.5f; // Factor de aumento de tamaño para esferas de Tipo2

    private void Update()
    {
        if (shouldMoveToCylinder && gameObject.CompareTag("Tipo1"))
        {
            MoveTowardsCylinder();
        }
    }

    void MoveTowardsCylinder()
    {
        Vector3 targetPosition = new Vector3(cylinderTransform.position.x, transform.position.y, cylinderTransform.position.z);
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            shouldMoveToCylinder = false;
        }
    }

    public static void NotifyType1ToMove()
    {
        foreach (var sphere in FindObjectsOfType<SphereBehaviour>())
        {
            if (sphere.CompareTag("Tipo1"))
            {
                sphere.shouldMoveToCylinder = true;
            }
        }
    }

    public static void NotifyType2ToGrow()
    {
        foreach (var sphere in FindObjectsOfType<SphereBehaviour>())
        {
            if (sphere.CompareTag("Tipo2"))
            {
                sphere.transform.localScale *= sphere.growSize;
            }
        }
    }
}
