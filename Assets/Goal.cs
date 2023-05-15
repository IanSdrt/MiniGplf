using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    public UnityEvent OnBallGoalEnter = new UnityEvent();
    public GameOverPanel gameOverPanel;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Ball"))
        {
            OnBallGoalEnter.Invoke();

            // Tampilkan panel game over
            gameOverPanel.ShowGameOverPanel();
        }
    }
}
