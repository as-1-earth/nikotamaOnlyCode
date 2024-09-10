using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("ステージの情報")]
    [SerializeField] private GameObject first_stage;
    [SerializeField] private GameObject[] stage_types;
    [SerializeField] int stage_length = 60;
    [SerializeField] private float speed_open_door = 1.5f;
    
    
    [Header("壁の情報")]
    [SerializeField] private GameObject[] wall_types;

    [SerializeField] private int wall_max_number;
    [SerializeField] private int wall_minimum_number;
    
    [Header("ボールの情報")] 
    [SerializeField] private GameObject ball;
    [SerializeField] float ball_speed;

    [Header("PlayUIの情報")]
    [SerializeField] private GameObject play_screen;
    [SerializeField] private GameObject restart_screen;
    [SerializeField] private GameObject stop_screen;
    [SerializeField] private GameObject result_screen;

    public int calculate_current_score()
    {
        return (int)ball.transform.position.z;
    }
    
    void calculate_if_high_score(String level)
    {
        if (PlayerPrefs.GetInt(level) < calculate_current_score())
        {
            PlayerPrefs.SetInt(level, calculate_current_score());
        }
    }
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
