using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
    public class Reset : MonoBehaviour
    {
        public GameObject pLAYER;
       
       private void OnTriggerEnter(Collider other)
       {
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(pLAYER);
                SceneManager.LoadScene(1);
            }
        }
    }
}
