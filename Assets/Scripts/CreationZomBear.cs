using UnityEngine;

public class CreationZomBear : MonoBehaviour
{
    public GameObject ours; // 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Reproduire", 5f, 3f); //car il a plus de vie que le lapin
    }
    void Reproduire()
    {
        GameObject leClone = Instantiate(ours);
        leClone.SetActive(true);
    }
}

