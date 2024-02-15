using UnityEngine;

namespace MySpaceInvader.Controller
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public float speed = 10.0f;
        private float ammo = 30; // Starting ammo

        void Update()
        {
            // Player movement
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, transform.position.y, 0);

            // Shooting
            if (Input.GetButtonDown("Fire1") && ammo > 0)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                ammo--;
                UpdateAmmoDisplay();
            }
        }

        void UpdateAmmoDisplay()
        {
            // Update UI element for ammo
        }
    }
}