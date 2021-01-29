using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public Terrain terrain;
    public bool test = false;
    public float speed = 10;
    public float size = 1;


    private int height;
    private int width;

    // Start is called before the first frame update
    void Start()
    {
        height = terrain.terrainData.heightmapResolution;
        width = terrain.terrainData.heightmapResolution;
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            float[,] heights = terrain.terrainData.GetHeights(0, 0, width, height);

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    heights[i, j] = Mathf.PerlinNoise((float)(i + Time.time * speed) / width * size, (float)(j + Time.time * speed) / height * size);
                }
            // set the new height
            terrain.terrainData.SetHeights(0, 0, heights);
        }
    }
}
