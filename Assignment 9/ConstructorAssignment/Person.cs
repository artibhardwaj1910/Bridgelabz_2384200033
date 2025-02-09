using System;
namespace ConstructorAssignment{
	class Person{
		
		private string name;
		private int age;
		
		public Person(string name, int age){
		this.name = name;
		this.age = age;
		}
		
		public Person(Person existingPerson){
		this.name = existingPerson.name;
		this.age = existingPerson.age;
		}
		
		public string GetName(){
		return name;
		}
		
		public void SetName(string name){
		this.name = name;
		}
		
		public int GetAge(){
		return age;
		}
		
		public void SetAge(int age){
		this.age = age;
		}
		
		public void display(){
		Console.WriteLine($"Person name is: {name}");
		Console.WriteLine($"Person age is: {age}");
		}
	}
}