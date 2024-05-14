using System;
using UnityEngine;
using TMPro;

namespace DefaultNamespace
{
    public class Spawner : MonoBehaviour
    {
        public Transform rocksp;
        public Transform papersp;
        public Transform scissorssp;

        public GameObject rock;
        public GameObject paper;
        public GameObject scissors;
        
        [SerializeField] private TMP_Text _rockText;
        [SerializeField] private TMP_Text _paperText;
        [SerializeField] private TMP_Text _scissorsText;
        
        
        
        public int _rockCount{get; set; }
        public int _paperCount{get; set; }
        public int _scissorsCount{get; set; }

        private void Awake()
        {
            _rockCount = 10;
            _paperCount = 10;
            _scissorsCount = 10;
        }

        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(rock, rocksp.position, rocksp.rotation);
                Instantiate(paper, papersp.position, papersp.rotation);
                Instantiate(scissors, scissorssp.position, scissorssp.rotation);
                _rockCount = i + 1;
                _paperCount = i + 1;
                _scissorsCount = i + 1;
            }
        }


        private void Update()
        {
            _rockText.text = _rockCount.ToString();
            _paperText.text = _paperCount.ToString();
            _scissorsText.text = _scissorsCount.ToString();
        }
    }
}