using System;
namespace ConstructorAssignment{
	class Book{
	
		//Declaring Attributes
		private string title;
		private string author;
		private int price;
		
		//Default Constructor
		public Book(){
		this.title = "Programming in C#";
		this.author = "Anders Heilsjberg";
		this.price = 799;
		}
		
		//parameterised constructor
		public Book(string title, string author, int price){
		this.title = title;
		this.author = author;
		this.price = price;
		}
		
		//Getters and Setters
		
		public string GetTitle(){
		return title;
		}	
		
		public void SetTitle(string title){
		this.title = title;
		}
		
		public string GetAuthor(){
		return author;
		}
		
		public void SetAuthor(string author){
		this.author = author;
		}
		
		public int GetPrice(){
		return price;
		}
		
		public void SetPrice(int price){
		this.price = price;
		}
		
		// Method to display
		public void display(){
		Console.WriteLine($"Title name: {title}");
		Console.WriteLine($"Author name: {author}");
		Console.WriteLine($"Price is: {price}");
		}
		
	
}