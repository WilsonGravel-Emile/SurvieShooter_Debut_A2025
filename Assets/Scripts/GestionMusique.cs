using UnityEngine;

public class GestionMusique : MonoBehaviour
{
    private void Awake() // joué avant le Start
    {
        DontDestroyOnLoad(this.gameObject); // Empêche la destruction de l'objet lors du chargement d'une nouvelle scène
    }
}
