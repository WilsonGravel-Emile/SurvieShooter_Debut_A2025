using UnityEngine;

public class CreationZomBunny : MonoBehaviour
{
    public GameObject lapin; // 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Reproduire", 4f, 2f); //car le lapin a moins de vie, il va etre créer apres 4 secondes et va se reproduire chaque 2 secondes
    }
    void Reproduire()
    {
        GameObject leClone = Instantiate(lapin); // création du clone
        leClone.SetActive(true); 
    } 
}
