using UnityEngine;

[ExecuteAlways] // ���� �������� � Editor'� ��� ������� ���
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("������ ������ ����� ������ ����� ��� (360 �������).")]
    public float dayLengthInSeconds = 60f;

    void Update()
    {
        if (dayLengthInSeconds <= 0) return;

        // ���������� ��� ��������� ��� ����� �����
        float rotationPerFrame = 360f / dayLengthInSeconds * Time.deltaTime;

        // �������� ����� ������� �� X
        transform.Rotate(Vector3.right, rotationPerFrame);
    }
}
