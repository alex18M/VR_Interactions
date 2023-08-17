using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
   [SerializeField] private GameObject _bullet;
   [SerializeField] private Transform _SpawnPoint;
   [SerializeField] private float _bulletSpeed = 10;

   public void FireBullet()
   {
      GameObject spawnBullets = Instantiate(_bullet, _SpawnPoint.position, _SpawnPoint.rotation);

      spawnBullets.GetComponent<Rigidbody>().velocity = _SpawnPoint.forward * _bulletSpeed;
      
      Destroy(_bullet, 5f);
   }
}
