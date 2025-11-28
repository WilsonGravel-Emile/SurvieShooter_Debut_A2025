using UnityEngine;

public class ScriptScene : MonoBehaviour
{
    void Update()
    {
        // si le joeur appuie sur la touche espace il va charger la scene de jeu
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChargerScene(); // appelle la fonction ChargerScene
        }
    }
    void ChargerScene() // fonction qui charge la scene de jeu de debut
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SceneDebut");
        ScriptPerso.score = 0; // remet le score a 0
    }
}
