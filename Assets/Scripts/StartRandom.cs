using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRandom : MonoBehaviour
{

    public Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomStart());
    }

    IEnumerator RandomStart()
    {
        int rand = Random.Range(0, 6);
        yield return new WaitForSeconds(rand);

        animation.Play();
    }
}
