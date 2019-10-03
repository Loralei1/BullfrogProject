
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   

    public Material[] materials;
    public float duration; 

    public Renderer rend;
    

    private void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    private void Update()
    {
       

        if (Input.GetKeyDown( "Space"))
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.Lerp(materials[1], materials[0], lerp); 

        }
        
    }
}
