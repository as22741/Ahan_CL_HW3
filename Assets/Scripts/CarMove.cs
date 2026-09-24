using UnityEngine;

public class CarMove : MonoBehaviour
{
     public float speed;
     public float maxDistance;
        public Vector3 targetPosition;
        public bool movingForward = true;
       private Vector3 startingPos;
        void Start()
        {
            startingPos = transform.position;
        }

        void Update()
        {
            // Calculate how far the car(?) moved from origin along the Z axis
            float currentOffset = transform.position.z - startingPos.z;

            if (movingForward)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                if (currentOffset >= maxDistance)
                {
                    movingForward = false;
                }
            }

            else
            {
                transform.position = Vector3.MoveTowards(transform.position, startingPos, speed * Time.deltaTime);
                if (currentOffset <= 0)
                {
                    movingForward = true;
                }
            }
        }
    }
