using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
public class ScriptUIScore : MonoBehaviour
{
    
    //public TextMeshProUGUI scoreText;
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Pointage : " + ScriptPerso.score.ToString();
    }
}
