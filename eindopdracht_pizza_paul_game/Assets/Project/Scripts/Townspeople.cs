
using UnityEngine;

public class Townspeople : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    public Score score;
    public ParticleSystem happyParticles;

    public float health = 10f;

    public AudioClip CheerClip;
    public AudioSource Cheer;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        Cheer.clip = CheerClip;
        happyParticles.Stop();

    }


    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health == 0f)
        {
            FullStomache();
            Score.scoreAmount += 1;
            Cheer.Play();
            

        }

    }

    private void FullStomache ()
    {
        happyParticles.Play();
        rend.sharedMaterial = material[1];
        




    }
}
