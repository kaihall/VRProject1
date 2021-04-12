using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlockCountinator : MonoBehaviour
{
    public NVBoids flock;
	public string flockName;
	
	private TextMeshProUGUI counter;
	
	// Start is called before the first frame update
    void Start()
    {
		counter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = flockName + ": " + flock.birdsNum;
    }
}
