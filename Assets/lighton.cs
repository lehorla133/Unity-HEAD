using UnityEngine;
using System.Collections;

public class lighton : MonoBehaviour {
    public float maxLight = 8f;
    private float actualLight = 0f;
    public float speed = 1f;
	// Use this for initialization
	void Start () {
        actualLight = GetComponent<Light>().intensity;
        GetComponent<Light>().color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 1f);
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, actualLight, speed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        {
            actualLight = maxLight;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            actualLight = 0f;
        }
    }
}
