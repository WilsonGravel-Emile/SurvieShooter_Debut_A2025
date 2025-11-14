using UnityEngine;

public class CreationHellephant : MonoBehaviour
{
    public GameObject elephant; // Référence au prefab de l'hellephant
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Reproduire", 5f, 5f); // Appelle la fonction CreerHellephant toutes les 5 secondes après un délai de 2 secondes
    }
    void Reproduire()
    {
        GameObject leClone = Instantiate(elephant);
        leClone.SetActive(true);
    }
}
