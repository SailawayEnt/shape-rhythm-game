using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;

    public int currentStreak;
    public int streakTracker;
    public int[] streakThresholds;

    public Text scoreText;
    public Text streakText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentStreak = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying) 
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;
                theMusic.Play();
            }
        }
    }

    public void NoteHit() 
    
    { 
        Debug.Log("Hit On Time");

        if(currentStreak - 1 < streakThresholds.Length)

        { 
            streakTracker++;

            if (streakThresholds[currentStreak - 1] <= streakTracker)
            {
                streakTracker = 0;
                currentStreak++;
            }

        }

        streakText.text = "Streak: x" + currentStreak;

        currentScore += scorePerNote * currentStreak;
        scoreText.text = "Score: " + currentScore;

    }

    public void NoteMissed() 
    
    { 
    
        Debug.Log("Missed Note");

        currentStreak = 1;
        streakTracker = 0;

        streakText.text = "Streak: x" + currentStreak;

    }
}
