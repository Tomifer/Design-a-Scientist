using UnityEngine;
using System.Collections;

public class CameraPos : MonoBehaviour
{
    static int frameCount = 0;
    private float currentSize = 5;
    private static double ZOOM_RATE = 60.0;

    CameraLocation currentLocation;
    CameraLocation previousLocation;
    CameraPos instance;

    void Start()
    {
        currentLocation = new CameraLocation(0f, 0f, -10f, 5f);
        previousLocation = currentLocation;
        instance = this;
        GetComponent<Camera>().orthographicSize = 5;
    }

    void Update()
    {
        if (previousLocation.changeLocation(currentLocation, instance))
        {
            previousLocation = currentLocation;
        }
        GetComponent<Camera>().orthographicSize = currentSize;
    }

    //Must be public
    public void ChangePos1()
    {
        currentLocation = new CameraLocation(2f, -0.75f, -10f, 2f);
    }

    //Must be public
    public void ChangePos2()
    {
        currentLocation = new CameraLocation(0f, 0f, -10f, 5f);
    }   

    public class CameraLocation
    {
        public float x, y, z, size;

        public CameraLocation(float x, float y, float z, float size)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.size = size;
        }

        public bool changeLocation(CameraLocation pos, CameraPos camera)
        {
            if (!pos.Equals(this))
            {
                frameCount++;
                double posDiff = frameCount / ZOOM_RATE;
                float newX = (float) (this.x - ((this.x - pos.x) * posDiff));
                float newY = (float)(this.y - ((this.y - pos.y) * posDiff));
                float newZ = (float)(this.z - ((this.z - pos.z) * posDiff));
                float newSize = (float)(this.size - ((this.size - pos.size) * posDiff));
                camera.transform.position = new Vector3(newX, newY, newZ);
                camera.currentSize = newSize;
                if (frameCount % ZOOM_RATE == 0)
                {
                    frameCount = 0; 
                    return true;
                }
            }
            return false;
        }
    }
}