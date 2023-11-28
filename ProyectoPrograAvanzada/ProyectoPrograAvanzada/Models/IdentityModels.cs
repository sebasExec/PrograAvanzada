using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProyectoPrograAvanzada.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Rol { get; set; }

        [Required]
        public DateTime UltimaConexion { get; set; }

        [Required]
        public bool Activo { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, string> manager)
        {
            // Tenga en cuenta que authenticationType debe coincidir con el valor definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar reclamaciones de usuario personalizadas aquí
            this.UltimaConexion = DateTime.UtcNow;
            await manager.UpdateAsync(this);
            return userIdentity;
        }
    }

    public class Role : IdentityRole
    {
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public bool Activo { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, Role, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}