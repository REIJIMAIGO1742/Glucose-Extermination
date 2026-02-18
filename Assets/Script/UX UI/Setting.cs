using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider sensitivitySlider;

    void Start()
    {
        // ดึงค่าปัจจุบันมาแสดงที่ Slider เมื่อเปิดหน้าเมนู
        sensitivitySlider.value = GameSettings.Mosuesensitivity;

        // เพิ่ม Listener เมื่อมีการเลื่อน Slider
        sensitivitySlider.onValueChanged.AddListener(delegate { UpdateSensitivity(); });
    }

    public void UpdateSensitivity()
    {
        // บันทึกค่าลงใน Static Variable
        GameSettings.Mosuesensitivity = sensitivitySlider.value;
        
    }
}