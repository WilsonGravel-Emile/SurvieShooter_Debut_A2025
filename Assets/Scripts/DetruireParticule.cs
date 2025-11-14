using UnityEngine;

public class DetruireParticule : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Detruire", 2f, 2f); // Appelle la fonction Detruire toutes les 2 secondes après un délai de 2 secondes    
    }
    void Detruire()
    {
        Destroy(gameObject); // Détruit l'objet de particules
    }
}
