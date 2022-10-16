using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;
    public bool isAlive = true;

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > 1f)
        {
            scoreText.text = player.position.z.ToString("0");
        }
        else if (player.position.y < 0f){}
            
    }
}
