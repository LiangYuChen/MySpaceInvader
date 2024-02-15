using MySpaceInvader.Entity;
using UnityEngine;

namespace MySpaceInvader.Controller
{
    public class AlienController : MonoBehaviour
    {
        [SerializeField]
        private Alien[] _alienInstances;

        private void Start()
        {
            // Initialize the aliens' formation
        }

        private void Update()
        {
            // Handle aliens' movement, shooting, and formation
        }

        public void SpawnAliens()
        {

        }    

        private void Spawn(Alien prototype)
        {

        }    

        private void MoveAliens()
        {
            // Move the aliens based on their current direction
        }

        private void Shoot()
        {
            // Shoot a bullet
        }

        private void UpdateFormation()
        {
            // Update the aliens' formation
        }
    }
}