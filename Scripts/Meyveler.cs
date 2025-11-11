using UnityEngine;
using System;
using UnityEngine.SocialPlatforms.Impl;
public class Meyveler : MonoBehaviour
{
    [SerializeField] private score _score;
    void Start()
    {
        _score = GameObject.Find("Score").GetComponent<score>();
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (this.tag)
        {
            case "Kavun":
                Destroy(this.gameObject);
                _score.PuanArtma(5);
                break;

            case "Domates":
                Destroy(this.gameObject);
                _score.PuanArtma(2);
                break;

            case "Seftali":
                Destroy(this.gameObject);
                _score.PuanArtma(3);
                break;

            case "Balık":
                Destroy(this.gameObject);
                _score.PuanAzaltma(10);
                break;


        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }



}
