namespace ECommerce.Application.Services;

public interface IEmailConfirmationService
{
    public void SendConfirmationEmail(string toEmail, string userName, int userId);
}