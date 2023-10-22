using UnityEngine;

public class CylinderCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            SendMessageToSpheres();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cubo"))
        {
            SendMessageToSpheres();
        }
    }

    void SendMessageToSpheres()
    {
        SphereBehaviour1[] spheres = FindObjectsOfType<SphereBehaviour1>();
        foreach (SphereBehaviour1 sphere in spheres)
        {
            sphere.ReactToCollision();
        }
    }
}
