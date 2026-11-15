using UnityEngine;

using TMPro;

using Game.MinigameFramework.Scripts.Framework.PlayerInfo;

namespace Frog {
    public class ScoreTracker : MonoBehaviour
    {
        [SerializeField] public TMP_Text scoreText;
        int pscore_1 = 0;
        int pscore_2 = 0;
        int pscore_3 = 0;
        int pscore_4 = 0;

        int numPlayers = 0;



        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            numPlayers = PlayerManager.GetNumPlayers();
        }

        // Update is called once per frame
        void Update()
        {
            if (numPlayers == 1) {
                scoreText.text = "<color=blue>P1: " + pscore_1 + "</color>";
            }
            else if (numPlayers == 2) {
                scoreText.text = "<color=blue>P1: " + pscore_1 + "</color>   <color=red>P2: " + pscore_2 + "</color>";
            }
            else if (numPlayers == 3) {
                scoreText.text = "<color=blue>P1: " + pscore_1 + "</color>   <color=red>P2: " + pscore_2 + "</color>   <color=green>P3: " + pscore_3 + "</color>";
            }
            else {
                 scoreText.text = "<color=blue>P1: " + pscore_1 + "</color>   <color=red>P2: " + pscore_2 + "</color>.  <color=green>P3: " + pscore_3 + "</color>   <color=yellow>P4: " + pscore_4 + "</color>";
            }
            
            
        }

        public void addScore(int playerNum, int scoreNum) {
            if (playerNum == 1) {
                pscore_1 += scoreNum;
            }
            else if (playerNum == 2) {
                pscore_2 += scoreNum;
            }
            else if (playerNum == 3) {
                pscore_3 += scoreNum;
            }
            else if (playerNum == 4) {
                pscore_4 += scoreNum;
            }
        }
    }
}