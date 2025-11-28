using UnityEngine;

public class CreationHellephant : MonoBehaviour
{
    public GameObject elephant; // Référence au prefab de l'hellephant
    public int scoreHellephant = 5; // points attribués pour chaque hellephant créé
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Reproduire", 7f, 5f); // Appelle la fonction CreerHellephant toutes les 7 secondes après un délai de 5 secondes
    }
    void Reproduire()
    {
        GameObject leClone = Instantiate(elephant); // création du clone
        leClone.SetActive(true);
    }
}
