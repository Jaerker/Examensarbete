namespace AlfaCert.Shared.DTO.Authentication
{
    public record TokenDtoResponse(string AccessToken, string RefreshToken, DateTime ExpirationDate);
}
