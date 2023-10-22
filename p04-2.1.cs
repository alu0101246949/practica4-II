using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Si colisiona con el terreno, simplemente regresa y no hagas nada más.
        if (collision.gameObject.CompareTag("Terreno")) return;

        if (!collision.gameObject.CompareTag("Tipo1"))
        {
            SphereBehaviour.NotifyType1ToMove();
        }
        else if (collision.gameObject.CompareTag("Tipo1"))
        {
            SphereBehaviour.NotifyType2ToGrow();
        }
    }
}
