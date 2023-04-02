using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace DefaultNamespace
{
    public class PickUp : MonoBehaviour
    {
        [SerializeField] private int _bonusAmount = 200;
        [SerializeField] private string _playerTag = "Player";

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(_playerTag))
            {
                Pick();
            }
        }

        private void Pick()
        {
            PickupManager.Instance.AddMoney(_bonusAmount);
            CoinAnimationManager.Instance.Animate(_bonusAmount, transform.position);
            Destroy(gameObject);
        }
        
        
    }
}