using UnityEngine;

public class Sphere : MonoBehaviour
{    
    public MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer.material.color= Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
       
        Destroy(gameObject);
    }
    
}
