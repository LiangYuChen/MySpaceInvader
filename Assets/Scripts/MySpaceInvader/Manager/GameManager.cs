using System.Collections;
using System.Collections.Generic;
using MySpaceInvader.Controller;
using UnityEngine;

namespace MySpaceInvader.Manager
{
    public class GameManager : MonoBehaviour
    {
        public GameController gameController;
        public PlayerController playerController;
        public AlienController alienController;
        public ScoreManager scoreManager;
        public UIController uiController;
        public LeaderboardManager leaderboardManager;

        private void Start()
        {
            // Initialize the game components
        }
    }
}
