using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    
    void Update()
    {
        GetComponent<TMP_Text>().SetText(Enemy.score.ToString());
    }
}
