
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;

namespace DefaultNamespace
{
    public class Rock : MonoBehaviour
    {
        public GameObject _paper;
        public GameObject _rock;
        
        public float minAngle = 0f;
        public float maxAngle = 360f;
        public float minForce = 5f;
        public float maxForce = 10f;

        public Rigidbody2D rb;

        private Spawner sp;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            Force(rb);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            
            if (other.gameObject.GetComponent<Paper>())
            {
                Destroy(this.gameObject);
                Instantiate(_paper, transform.position, quaternion.identity);
                // sp._paperCount++;
                // sp._rockCount--;
                Force(rb);
            }else if (other.gameObject.GetComponent<Scissors>())
            {
                Destroy(other.gameObject);
                Instantiate(_rock, transform.position, quaternion.identity);
                // sp._rockCount++;
                // sp._scissorsCount--;
                Force(rb);
            }
        }

        public void Force(Rigidbody2D rb2D)
        {
            // Rastgele bir açı seç
            float randomAngle = UnityEngine.Random.Range(minAngle, maxAngle);

            // Açıyı dereceden radyana çevir
            float radianAngle = randomAngle * Mathf.Deg2Rad;

            // Rastgele bir kuvvet değeri belirle
            float randomForce = UnityEngine.Random.Range(minForce, maxForce);

            // Rigidbod'y'e rastgele kuvvet uygula
            Vector2 forceVector = new Vector2(Mathf.Cos(radianAngle), Mathf.Sin(radianAngle)) * randomForce / 4;
            rb2D.AddForce(forceVector, ForceMode2D.Impulse);
        }
    }
}