using System.ComponentModel.DataAnnotations;

namespace API_RentalMovie.ViewModels;

public class RegisterVM
{
    public int? PaymentId { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [MaxLength(1, ErrorMessage = "Ex : 0/1"), MinLength(1, ErrorMessage = "Ex : 0/1")]
    public string Active { get; set; }
    [StringLength(255, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    public string Password { get; set; }
    [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
    public DateTime LastUpdate { get; set; }
    public string? PictureUrl { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public int District { get; set; }
    public string PostalCode { get; set; }
    [Phone]
    public string Phone { get; set; }
    public string CityName { get; set; }
    public string CountryName { get; set; }
}
