using UnityEngine;

namespace MySpaceInvader.Manager
{
    public class LeaderboardManager : MonoBehaviour
    {
        // Reference to other components and game objects

        private void Start()
        {
            // Load the high scores from PlayerPrefs
        }

        public void SaveHighScore(string playerName, int score)
        {
            // Save the high score to PlayerPrefs
        }

        private void UpdateLeaderboardUI()
        {
            // Update the leaderboard UI
        }
    }
}