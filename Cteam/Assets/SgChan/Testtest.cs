using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using NotificationServices = UnityEngine.iOS.NotificationServices;
using LocalNotification = UnityEngine.iOS.LocalNotification;
public class Testtest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NotificationServices.RegisterForNotifications(
    NotificationType.Alert |
    NotificationType.Badge |
    NotificationType.Sound

);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetNotification(string message, int delayTime, int badgeNumber = 1)
    {
        var l = new LocalNotification();
        l.applicationIconBadgeNumber = badgeNumber;
        l.fireDate = System.DateTime.Now.AddSeconds(delayTime);
        l.alertBody = message;
        NotificationServices.ScheduleLocalNotification(l);
    }

    void OnApplicationPause(bool isPause)
    {
        if (isPause)
        {
            // 3秒間遊ばれていなかったら通知を出す
            SetNotification("Play the game!!",  3);
            SetNotification("Play the game!!", 10);
        }
        else
        {
            // 起動時、復帰時に登録してある通知を削除する
            NotificationServices.CancelAllLocalNotifications();
        }
    }
}
