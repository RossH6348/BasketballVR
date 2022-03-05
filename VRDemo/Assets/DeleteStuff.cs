using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class DeleteStuff : MonoBehaviour
{

    [SerializeField] private GameObject basketballSpawn;
    [SerializeField] private Text scoreBoard;
    [SerializeField] private ParticleSystem particles;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject reenableObj = null;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Basketball"))
        {
            other.gameObject.transform.parent.gameObject.transform.position = basketballSpawn.transform.position + Vector3.up;
            other.gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        }

        if (gameObject.tag.Equals("Net"))
        {
            //Score them a point.
            score++;
            scoreBoard.text = score.ToString();
            if(particles.isPlaying)
                particles.Stop();
            particles.Play();
        }
    }
}
