using UnityEngine;

public class ScriptScene : MonoBehaviour
{
    public GameObject musique;
    private void Awake()
    {
        DontDestroyOnLoad(musique); // pour que la musique ne se coupe pas entre les scenes
    }
    void Update()
    {
        // si le joeur appuie sur la touche espace il va charger la scene de jeu
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChargerScene();
        }
    }
    void ChargerScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SceneDebut");
    }
}
