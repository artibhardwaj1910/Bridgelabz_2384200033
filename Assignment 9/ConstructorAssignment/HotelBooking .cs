using System;
namespace ConstructorAssignment{
	 class HotelBooking {
	 
	 private string guestName;
	 private string roomType;
	 private int nights;
	 
	 // default Constructor 
	 public HotelBooking(){
	 this.guestName = "Ankit Singh";
	 this.roomType = "Standard";
	 this.nights = 2;
	 }
	 
	 //parameterized constructor
	 public HotelBooking(string guestName, string roomType, int nights){
	 this.guestName= guestName;
	 this.roomType = roomType;
	 this.nights = nights;
	 }
	 
	 //copy constructor
	 public HotelBooking (HotelBooking existingHotelBooking){
	 this.guestName = existingHotelBooking.guestName;
	 this.roomType= existingHotelBooking.roomType;
	 this.nights = existingHotelBooking.nights;
	 }
	 
	 // getters and setters
	 
	 public string GetGuestName(){
	 return guestName;
	 }
	 
	 public void SetGuestName(string guestName){
	 this.guestName = guestName;
	 }
	 
	 public string GetRoomType(){
	 return roomType;
	 }
	 
	 public void SetRoomType(string roomType){
	 this.roomType = roomType;
	 }
	 
	 public int GetNights(){
	 return nights;
	 }
	 
	 
	 public void SetNights(int nights){
	 this.nights = nights;
	 }
	 
	 //Display
	 public void display(){
	 Console.WriteLine($"Guest name is: {guestName}");
	 Console.WriteLine($"RoomType is: {roomType}");
	 Console.WriteLine($"Guest staying for {nights} nights");
	 }
	}
}
	 
	 