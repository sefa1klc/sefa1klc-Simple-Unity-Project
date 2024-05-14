
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class Paper : MonoBehaviour
    {
        public Rock _rock;
        public GameObject _scissors;
        
        public Rigidbody2D rb;
        

        private Spawner sp;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rock.Force(rb);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            
            if (other.gameObject.GetComponent<Scissors>())
            {
                Destroy(this.gameObject);
                Instantiate(_scissors, transform.position, quaternion.identity);
                //sp._scissorsCount++;
                //sp._paperCount--;
                _rock.Force(rb);            }
        }
    }
}