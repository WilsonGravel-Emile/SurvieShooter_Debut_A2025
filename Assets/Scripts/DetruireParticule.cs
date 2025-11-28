using UnityEngine;

public class DetruireParticule : MonoBehaviour
{
    void Update()
    {
        Invoke("Detruire", 2f); // Détruit l'objet après 2 secondes
    }
    void Detruire()
    {
        Destroy(gameObject); // Détruit l'objet de particules
    }
}
