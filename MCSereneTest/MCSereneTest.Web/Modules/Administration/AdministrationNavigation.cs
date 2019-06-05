using Serenity.Navigation;
using Administration = MCSereneTest.Administration.Pages;

[assembly: NavigationMenu(9000, "Administración", icon: "fa-desktop")]
[assembly: NavigationLink(9000, "Administración/Excepciones", url: "~/errorlog.axd", permission: MCSereneTest.Administration.PermissionKeys.Security, icon: "fa-ban", Target = "_blank")]
[assembly: NavigationLink(9000, "Administración/Idiomas", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(9000, "Administración/Traducciones", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(9000, "Administración/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(9000, "Administración/Administración de usuarios", typeof(Administration.UserController), icon: "fa-users")]