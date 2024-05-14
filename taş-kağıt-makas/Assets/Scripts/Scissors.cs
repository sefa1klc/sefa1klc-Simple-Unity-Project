
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class Scissors : MonoBehaviour
    {
        public Rock Rock;
        
        public Rigidbody2D rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        
        private void Start()
        {
            Rock.Force(rb);
        }
        
        
    }
}