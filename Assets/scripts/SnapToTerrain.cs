using UnityEngine;

public class SnapToTerrain : MonoBehaviour
{
    public float extraOffset = 0f;

    public void SnapNow()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position + Vector3.up * 100f, Vector3.down, out hit, 500f))
        {
            Collider col = GetComponent<Collider>();

            if (col != null)
            {
                float offset = transform.position.y - col.bounds.min.y;
                transform.position = hit.point + Vector3.up * (offset + extraOffset);
            }
            else
            {
                transform.position = hit.point + Vector3.up * extraOffset;
            }
        }
    }
}