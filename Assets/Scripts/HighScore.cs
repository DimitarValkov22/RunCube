using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    void Update()
    {
        GetComponent<TMP_Text>().SetText("Highscore: " + Enemy.highScore.ToString());
    }
}
