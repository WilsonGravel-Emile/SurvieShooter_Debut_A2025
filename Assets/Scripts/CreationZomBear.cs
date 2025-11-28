using UnityEngine;

public class CreationZomBear : MonoBehaviour
{
    public GameObject ours; // 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Reproduire", 5f, 3f); //car il a plus de vie que le lapin, il va etre créer apres 5 secondes et va se reproduire chaque 3 secondes
    }
    void Reproduire()
    {
        GameObject leClone = Instantiate(ours); // création du clone
        leClone.SetActive(true);
    }
}

