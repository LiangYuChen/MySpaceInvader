using UnityEngine;

namespace MySpaceInvader.Controller
{
    public class PlayerController : MonoBehaviour
    {
        public Camera mainCamera;
        public GameObject bulletPrefab;
        public float speed = 10.0f;
        private float ammo = 30; // Starting ammo
        private Vector3 _bulletOffset = new Vector3(0, 0.5f, 0);

        void Update()
        {
            // Player movement
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, transform.position.y, 0);

            // Shooting
            if (Input.GetButtonDown("Fire1") && ammo > 0)
            {
                var bullet = Instantiate(bulletPrefab, transform.position + _bulletOffset, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
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