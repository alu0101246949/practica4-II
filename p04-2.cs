using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public Transform cylinderTransform;
    public float moveAmount = 1f;
    public float scaleFactor = 1.5f; // factor de aumento para las esferas del tipo 2

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SphereType1"))
        {
            // Si el cubo colisiona con una esfera del tipo 1, las esferas del tipo 2 aumentan de tamaño.
            foreach (GameObject sphere in GameObject.FindGameObjectsWithTag("SphereType2"))
            {
                sphere.transform.localScale *= scaleFactor;
            }
        }
        else if (!other.CompareTag("SphereType2"))
        {
            // Si el cubo colisiona con cualquier objeto que no sea una esfera del tipo 1, las esferas del tipo 1 se acercan al cilindro.
            foreach (GameObject sphere in GameObject.FindGameObjectsWithTag("SphereType1"))
            {
                sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, cylinderTransform.position, moveAmount);
            }
        }
    }
}
