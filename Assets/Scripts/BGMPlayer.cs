using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    [SerializeField] AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        if (source == null)
        {
            return;
        }
        source.Play();
    }
}
