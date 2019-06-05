using Serenity.Navigation;
using Northwind = MCSereneTest.Northwind.Pages;

[assembly: NavigationMenu(7000, "Transacciones", icon: "fa-cog")]
[assembly: NavigationLink(7100, "Transacciones/Clientes", typeof(Northwind.CustomerController), icon: "fa-credit-card")]
[assembly: NavigationLink(7200, "Transacciones/Pedidos", typeof(Northwind.OrderController), icon: "fa-shopping-cart")]
[assembly: NavigationLink(7300, "Transacciones/Productos", typeof(Northwind.ProductController), icon: "fa-cube")]
[assembly: NavigationLink(7400, "Transacciones/Categorias", typeof(Northwind.CategoryController), icon: "fa-folder-o")]
//[assembly: NavigationLink(7400, "Northwind/Suppliers", typeof(Northwind.SupplierController), icon: "fa-truck")]
//[assembly: NavigationLink(7500, "Northwind/Shippers", typeof(Northwind.ShipperController), icon: "fa-ship")]
[assembly: NavigationLink(7500, "Transacciones/Regiones", typeof(Northwind.RegionController), icon: "fa-map-o")]
[assembly: NavigationLink(7600, "Transacciones/Territorios", typeof(Northwind.TerritoryController), icon: "fa-puzzle-piece")]
//[assembly: NavigationLink(7900, "Northwind/Reports", typeof(Northwind.ReportsController), icon: "fa-files-o")]
