using UnityEngine;

internal class Ray2
{
    private Vector3 forward;
    private Vector3 position;

    public Ray2(Vector3 position, Vector3 forward)
    {
        this.position = position;
        this.forward = forward;
    }
}