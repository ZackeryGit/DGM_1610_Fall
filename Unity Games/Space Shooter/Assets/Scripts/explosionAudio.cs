using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionAudio : MonoBehaviour
{
    public AudioSource audioSource;
    private void Start()
    {
        StartCoroutine(WaitForSound());
    }
    public IEnumerator WaitForSound ()
    {
        yield return new WaitUntil(() => audioSource.isPlaying == false); // once audio is over, delete audio object
        Destroy(gameObject);
    }
}
