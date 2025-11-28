using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScriptUIScoreFinal : MonoBehaviour
{
    private void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Votre Score Final : " + ScriptPerso.score.ToString(); // Met à jour le texte avec le score final du joueur
    }
}

