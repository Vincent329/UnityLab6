using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement player;
    private TextMeshProUGUI textCheck;
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        textCheck = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textCheck.text = "Score: " + player.GetScore();
    }
}
