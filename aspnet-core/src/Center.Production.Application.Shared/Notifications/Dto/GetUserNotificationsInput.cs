using Abp.Notifications;
using Center.Production.Dto;

namespace Center.Production.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}