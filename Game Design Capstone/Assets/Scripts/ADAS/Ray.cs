using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Diagnostics;

public class RaycastResultsUpdatedEventArgs
{
    public RaycastHit[,] Results { get; private set; }

    public RaycastResultsUpdatedEventArgs(RaycastHit[,] results)
    {
        this.Results = results;
    }
}

//public event EventHandler<RaycastResultsUpdatedEventArgs> OnRaycastResultsUpdated;

public class Ray : MonoBehaviour
{
    public GameObject Player;

    public float raycastDistance = 1f; // The distance the ray wills travel
    public LayerMask layerMask; // Layers to consider for the raycast
    public Vector3 rayDirection;
    public float drawDistance = 5.0f;
    public float lifeSpan = 1.0f;


    /* funny new algo */
    public float sStep = 16f;
    public float tStep = 16f;

    public float sLeft = 2;
    public float sRight = 2;
    public float tTop = 2;
    public float tBot = 2;

    // Define a delegate for the event within the class
    public delegate void RaycastResultsUpdatedEventHandler(object sender, RaycastResultsUpdatedEventArgs e);

    // Declare a public event of the delegate type within the class
    public event RaycastResultsUpdatedEventHandler OnRaycastResultsUpdated;


    //[SerializeField] LineRenderer lineRend;


    private void DrawCircle(Vector3 center, float radius, int segments)
    {
        float stepAngle = Mathf.PI * 2f / segments;
        for (int i = 0; i < segments; i++)
        {
            float currentAngle = stepAngle * i;
            Vector3 point = center + new Vector3(Mathf.Cos(currentAngle) * radius, 0, Mathf.Sin(currentAngle) * radius);
            if (i > 0)
            {
                UnityEngine.Debug.DrawLine(point, center + new Vector3(Mathf.Cos(currentAngle - stepAngle) * radius, 0, Mathf.Sin(currentAngle - stepAngle) * radius), Color.white);
            }
        }
    }

    void Update()
    {
        float sL = Mathf.PI / sLeft; float sR = Mathf.PI / sRight; float sS = (sL + sR) / sStep;
        float tB = Mathf.PI / tBot; float tT = Mathf.PI / tTop; float tS = (tT + tB) / tStep;

            RaycastHit[,] results = new RaycastHit[(int)sStep + 1, (int)tStep + 1];
            int sIter = 0;
            int tIter = 0;

            //float sAdjust = Mathf.Atan(transform.forward.z/transform.forward.x);
            //UnityEngine.Debug.Log(sAdjust);
            for (float s = (-sL); s <= sR; s += sS) // horizontal
            {
                tIter = 0;
                for (float t = (-tB); t <= tT; t += tS) // vertical
                {
                    Vector3 direction = new Vector3(
                         Mathf.Sin(s) * Mathf.Cos(t),
                         Mathf.Sin(t),
                         Mathf.Cos(s)
                    );

                    RaycastHit hit;

                    direction = Player.transform.rotation * direction;

                    if (Physics.Raycast(transform.position, direction.normalized, out hit, drawDistance, layerMask))
                    {
                        UnityEngine.Debug.Log("Raycast hit: " + hit.collider.name);
                        //UnityEngine.Debug.Log(sIter);//UnityEngine.Debug.Log(tIter);
                        results[sIter, tIter] = hit;
                    }
                    UnityEngine.Debug.DrawLine(transform.position, transform.position + direction.normalized * drawDistance, Color.blue, lifeSpan, true);

                    tIter++;
                }

                sIter++;
            }
            OnRaycastResultsUpdated?.Invoke(this, new RaycastResultsUpdatedEventArgs(results));
            //UnityEngine.Debug.Log(results);
    }
}


// Define the origin of the ray. This should be a point on the exterior of the Robot.
// For simplicity, let's assume the Robot has a Collider and we'll use its bounds.
//Vector3 rayOrigin = transform.position;

//UnityEngine.Debug.Log(transform.position);

// Define the direction of the ray. This example sends the ray forwards.
//Vector3 rayDirection = transform.TransformDirection(Vector3.forward);
/*
// Perform the raycast
RaycastHit hit;
if (Physics.Raycast(rayOrigin, rayDirection, out hit, raycastDistance))
{
     // The ray hit something
     UnityEngine.Debug.Log("Raycast hit: " + hit.collider.name);
     //lineRend.enabled = true;
    // lineRend.SetPosition(0, transform.position);
     //lineRend.SetPosition(1, hit.point);
     //Destroy(hit.transform.gameObject);
}
else
{
     // The ray did not hit anything
     UnityEngine.Debug.Log("Raycast did not hit anything.");
     //lineRend.enabled = false;
}*/


/*
private void depricated ()
{
     // intended for interpolation ratio of 1.0
          
     if (false)
     {
          // Adjust the step size to ensure more uniform distribution within the specified range
          float xStep = 360f / xSteps; // Assuming xSteps is the number of steps you want within the 360-degree range
          float yStep = 90f / ySteps; // Assuming ySteps is the number of steps you want within the 90-degree range

          for (float x = 0; x <= 360; x += xStep)
          {
               for (float y = -45; y <= 45; y += yStep)
               {
                    // Convert spherical coordinates to Cartesian coordinates
                    float xRad = x * Mathf.Deg2Rad;
                    float yRad = y * Mathf.Deg2Rad;

                    // Calculate the direction vector for the ray
                    // Rotate around the forward vector to create circles around it
                    Vector3 direction = Quaternion.Euler(0, x, 0) * transform.forward;
                    direction += Quaternion.Euler(y, 0, 0) * transform.right;

                    // Normalize the direction vector
                    direction = direction.normalized;

                    // Draw the ray
                    UnityEngine.Debug.DrawLine(transform.position, transform.position + direction * drawDistance, Color.blue, lifeSpan, false);
               }
          }
     }



     if (gemini)
     {
          float stepAngle = angle / (segments - 1);

          for (int i = 0; i < segments; i++)
          {
               float currentAngle = stepAngle * i;
               Vector3 dir = Quaternion.Euler(0, currentAngle, 0) * transform.forward;

               // Draw circle at current distance relative to the robot
               DrawCircle(transform.position + dir * radius * (i / (float)(segments - 1)), radius * (i / (float)(segments - 1)), segments);
          }
     }

     


     float xWidth = xAngle/2;
     float yWidth = yAngle/2;

     if (phind)
     {
          for (float x = -xWidth; x <= xWidth; x += stepDensity)
          {
               for (float y = -yWidth; y <= yWidth; y += stepDensity)
               {
                    // Convert spherical coordinates to Cartesian coordinates
                    float xRad = x * Mathf.Deg2Rad;
                    float yRad = y * Mathf.Deg2Rad;

                    // Calculate the direction vector for the ray
                    Vector3 direction = new Vector3(
                         Mathf.Sin(yRad) * Mathf.Cos(xRad),
                         Mathf.Cos(yRad),
                         Mathf.Sin(yRad) * Mathf.Sin(xRad)
                    );

                    // Ensure the direction vector is pointing in the same hemisphere as the forward vector
                    if (Vector3.Dot(direction, transform.forward) < 0)
                    {
                         direction *= -1;
                    }

                    // Draw the ray
                    UnityEngine.Debug.DrawLine(transform.position, transform.position + direction.normalized * drawDistance, Color.blue, lifeSpan, false);
               }
          }
     }

     else if (normal)
     {
          for (float x = 0.0f; x < xSteps; x += stepDensity)
          {
               for (float y = 0.0f; y < ySteps; y += stepDensity)
               {
                    UnityEngine.Debug.DrawLine(transform.position, transform.position + ( (transform.forward + Vector3.Lerp(-transform.up, transform.up, y) + Vector3.Lerp(-transform.right, transform.right, x)) ).normalized * drawDistance, Color.blue, lifeSpan, false);
               }
          }
     }
     else if (quads)
     {
          {
          for (float x = 0.0f; x < xSteps; x += stepDensity)
          {
               for (float y = 0.0f; y < ySteps; y += stepDensity)
               {
                    //UnityEngine.Debug.DrawLine(transform.position, transform.position + (Vector3.Lerp(transform.up, -transform.up + transform.forward, y)).normalized * drawDistance, Color.green, lifeSpan, false);
                    //UnityEngine.Debug.DrawLine(transform.position, transform.position + (Vector3.Lerp(transform.up, transform.forward, y)).normalized * drawDistance, Color.green, lifeSpan, false);

                    UnityEngine.Debug.DrawLine(transform.position, transform.position + ( 
                         (Vector3.Lerp(transform.forward, transform.up, y) + 
                         Vector3.Lerp(transform.forward, -transform.right, x)) 
                    ) * drawDistance, Color.blue, lifeSpan, false);

               }
          }
     }
     }
     if (myCode){
          for (float x = 0.0f; x < interpolationRatio; x += stepDensity)
          {
               for (float y = 0.0f; y < interpolationRatio; y += stepDensity)
               {
                    Vector3 horizontalVec = new Vector3(
                                                  (transform.right.x - (transform.right.x) * 2 * x ), 
                                                  (transform.up.y - (transform.up.y) * 2 * y ), 
                                                  (transform.right.z - (transform.right.z) * 2 * x )
                    ); //.normalized
                    UnityEngine.Debug.DrawLine(transform.position, transform.position + (transform.forward + horizontalVec) * drawDistance, Color.red, lifeSpan, false);
                    //UnityEngine.Debug.DrawLine(transform.position, transform.position + (transform.forward + Vector3.Lerp(-transform.up, transform.up, y) + Vector3.Lerp(-transform.right, transform.right, x)) * drawDistance, Color.blue, lifeSpan, false);
                    //UnityEngine.Debug.DrawLine(transform.position, transform.position + (transform.forward + Vector3.Lerp(-transform.up, transform.up, y) + Vector3.Lerp(-transform.right, transform.right, x)) * drawDistance, Color.blue, lifeSpan, false);
               }
          }
     }
}*/