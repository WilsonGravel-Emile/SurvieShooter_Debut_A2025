using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleScript : MonoBehaviour
{
    //Script à associer à la balle

    /*#################################################
    -- variables publiques à définir dans l'inspecteur
    #################################################*/
    public GameObject impactTir; // Référence au Prefab à instancier lorsque le tir frappe un objet. (Prefab ParticulesHit)
    public GameObject personnage; // Référence au personnage

    /*
     * Fonction OnCollisionEnter. Gère ce qui se passe lorsqu'une balle touche un objet.
     */

    private void OnCollisionEnter(Collision infoCollisions) // joue lorsque la balle entre en collision avec un autre objet
    {

        // Effet de particules à l'impact
        GameObject particuleCopie = Instantiate(impactTir);
        particuleCopie.transform.position = infoCollisions.GetContact(0).point;
        particuleCopie.SetActive(true);
        particuleCopie.transform.LookAt(personnage.transform);
        particuleCopie.transform.Translate(0f, 0.5f, 0f);
        // Si la balle touche un monstre
        if (infoCollisions.gameObject.CompareTag("monstre"))
        {
            infoCollisions.gameObject.GetComponent<ScriptMonstre>().Touche();
        }
        Destroy(gameObject);
        Destroy(particuleCopie, 1f);


    }
}
