using System;
namespace InstanceNObjectVariable{
	class Product{
		
		// class variable
		private static int totalProducts = 0;
		
		//instance variable
		private string productName;
		private int price;
		
		//constructor to initialize value
		public Product(string productName, int price){
		this.productName = productName;
		this.price = price;
		totalProducts++;
		}
		
		//getters and setters
		
		public string GetProductName(){
		return productName;
		}
		
		public void SetProductName(string productName){
		this.productName = productName;
		}
		
		public int GetPrice(){
		return price;
		}
		
		public void SetPrice(int price){
		this.price = price;
		}
		
		public void DisplayProductDetails(){
		Console.WriteLine($"Product name is: {productName}");
		Console.WriteLine($"Price of product is: {price}");
		}
		
		public static void DisplayTotalProducts(){
		Console.WriteLine($"Total Product is: {totalProducts}");
		}
	}
}
		
		
		