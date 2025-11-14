using UnityEngine;

public class CreationZomBunny : MonoBehaviour
{
    public GameObject lapin; // 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Reproduire", 5f, 2f); //car il a plus de vie que le lapin
    }
    void Reproduire()
    {
        GameObject leClone = Instantiate(lapin);
        leClone.SetActive(true);
    }
}
