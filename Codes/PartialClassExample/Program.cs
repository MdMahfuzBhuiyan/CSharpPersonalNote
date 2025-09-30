using PartialClassExample;

Product product = new Product(2, "Camera");
product.Price = 3000;
product.IsActive = true;
var price = product.GetPriceAfterDiscount(20);

