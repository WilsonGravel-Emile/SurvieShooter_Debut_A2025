using System.Threading;
using UnityEngine;
using UnityEngine.AI;
public class ScriptMonstre : MonoBehaviour
{
    public GameObject cible; // Référence au joueur¸
    public GameObject particulesMort; // Référence aux particules de mort
    [Header("Statistiques du monstre")]
    public int pointsVie; // Points de vie du monstre
    public int pointsDonner; // Points attribués au joueur lorsqu'il tue le monstre
    [Header("reference a l'audio") ]
    public AudioClip sonMort; // Référence au son de mort du monstre
    public AudioClip sonMal; // Référence au son de douleur du monstre
    private AudioSource sourceAudio; // Composant AudioSource pour jouer les sons
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sourceAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!DeplacementPersoScript.jeuTerminer)
        {
            GetComponent<NavMeshAgent>().SetDestination(cible.transform.position);//Déplace le navmeshagent vers le joueur
            GetComponent<Animator>().SetFloat("vitesse", GetComponent<NavMeshAgent>().velocity.magnitude); // Active l'animation de marche
        }
        else
        {
            GetComponent<NavMeshAgent>().speed = 0; // Désactive le NavMeshAgent
        }
    }
    public void Touche()
    {
        sourceAudio.PlayOneShot(sonMal); // Joue le son de douleur
        pointsVie--; // Réduit les points de vie du monstre
        if (pointsVie == 0)
        {
            Meurt();
        }
    }
    void Meurt()
    {
        print("mort");
        sourceAudio.PlayOneShot(sonMort); // Joue le son de mort
        GetComponent<Animator>().SetBool("isDead", true); // Active l'animation de mort
        // le prof va me revenir pour trouver pouquoi l'animation de mort ne marche pas
        //GetComponent<NavMeshAgent>().isStopped = true; // Arrête le déplacement du monstre
        GetComponent<Animator>().SetTrigger("isReallyDead"); // Active l'animation de mort
        GetComponent<NavMeshAgent>().speed = 0; // Désactive le NavMeshAgent
        ScriptPerso.score += pointsDonner; // Ajoute des points au score du joueur
        Invoke("Disparition", 3f); // Appelle la fonction Disparition après 3 secondes
        gameObject.tag = "Untagged"; // Change le tag du monstre pour éviter les collisions avec les balles
        
    }
    void Disparition()
    {
        transform.Find("DeathParticles").gameObject.SetActive(true); // Active les particules de mort
        transform.Find("DeathParticles").parent = null; // Détache les particules de mort du monstre
        Destroy(gameObject); // Détruit le monstre
    }
}
