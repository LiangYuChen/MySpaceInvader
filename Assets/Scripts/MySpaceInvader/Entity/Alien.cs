using MySpaceInvader.Define;
using UnityEngine;
using UnityEngine.Serialization;

namespace MySpaceInvader.Entity
{
    public class Alien : MonoBehaviour
    {
        public int Id { get; protected set; }
        public int Score { get; protected set; }
        
        [SerializeField]
        private AlienType type;
        
        public Alien Clone(int id, int score)
        {
            var alien = Instantiate<Alien>(this);
            alien.Init(id, score);
            alien.SetState(0);
            alien.gameObject.SetActive(true);
            return alien;
        }
        
        public void Init(int id, int score)
        {
            Id = id;
            Score = score;
        }

        public void SetState(int stateId)
        {
        }
    }
}