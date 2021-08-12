using Flunt.Notifications;
using Flunt.Validations;
using User.Service.Shared.Commands;

namespace User.Service.Domain.Commands.Input
{
    public class UserNameCommandInput : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string FinalName { get; set; }

        public void Validate()
        {
            AddNotifications(
          new Contract()
              .Requires()
               .IsNotNullOrEmpty(FirstName, "FirstName", "FirstName is Required !")
               .IsNotNullOrEmpty(FinalName, "FinalName", "FinalName is Required !")
               );
        }
    }
}
