using MySpaceInvader.Define;
using UnityEngine;

namespace MySpaceInvader.Entity
{
    public class Alien : MonoBehaviour
    {
        public int Id { get; protected set; }

        private AlienType _type;
        
        public Alien Clone(int id)
        {
            var alien = Instantiate<Alien>(this);
            alien.Init(id, _type);
            alien.SetState(0);
            alien.gameObject.SetActive(true);
            return alien;
        }
        
        public void Init(int id, AlienType type)
        {
            Id = id;
            _type = type;
        }

        public void SetState(int stateId)
        {
        }
    }
}