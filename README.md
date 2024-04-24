This Unity project implements a flexible and scalable inventory system that connects to an API to manage items.
The inventory system is built using object-oriented programming (OOP) principles, making it easy to extend and maintain.

## Features

- Inventory Management: Easily add, remove, and update items in the inventory.
- API Integration: Connects to a remote API to fetch item data, allowing for dynamic updates.
- Object-Oriented Design: Utilizes OOP principles for item management, enhancing modularity and code reusability.
- Simple Item Action

## How to Use

To use this project:

1. Add Newtonsoft package `com.unity.nuget.newtonsoft-json`
2. Attach script `ServiceContainer` for make the network service is Singleton and Dontdestroyonload.
3. Attach script `Main` to call the service for get inventory from api.
4. Play unity andd observe debug it's will show data from api.
5. Feel free to explore the scripts in the `Assets/Script` folder to understand how the inventory is implemented.
