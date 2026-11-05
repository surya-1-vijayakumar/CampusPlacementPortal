using Microsoft.AspNetCore.Identity;
using CampusPlacementPortal.Enums;

namespace CampusPlacementPortal.Models
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string FullName { get; set; } = string.Empty;

        public AccountStatus AccountStatus { get; set; }
            = AccountStatus.Active;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
}