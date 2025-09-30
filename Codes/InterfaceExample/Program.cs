
using InterfaceExample;

ShoppingCart cart = new ShoppingCart();
cart.Products[cart.ItemCount++] = new Camera();
cart.Products[cart.ItemCount++] = new Camera();
cart.Products[cart.ItemCount++] = new Toothpaste();

IProduct[] product = new IProduct[10];
product[0] = new Camera();

Camera camera = new Camera();