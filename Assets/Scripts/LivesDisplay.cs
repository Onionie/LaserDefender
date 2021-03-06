using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{


        TextMeshProUGUI livesText;
    Player player;

        // Start is called before the first frame update
        void Start()
        {
            livesText = GetComponent<TextMeshProUGUI>();
            player = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            livesText.text = "Lives: " + player.GetHealth().ToString();
        }
 }
