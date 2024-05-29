### Overview

This project implements a basic inventory system in Unity, fetching data from a remote API and displaying it in the user interface (UI). It uses C# scripting and asynchronous programming with UniTask to handle data fetching and UI updates.

### Project Structure

1. **Main Script**: Manages the loading and displaying of inventory items in the UI.
2. **Inventory Object UI**: Manages the representation and interaction of individual inventory items.
3. **Inventory Data and Items**: Defines the structure and properties of the inventory data and items.
4. **Service Container**: Manages service initialization and provides a singleton instance for easy access.
5. **Image Database**: Manages storage and retrieval of item sprites.
6. **API Service**: Handles communication with the remote API to fetch inventory data.
7. **Equipment and Weapon Items**: Defines specific types of inventory items with additional properties.

### Key Components

1. **Main Script (`Main.cs`)**:
   - **Responsibilities**:
     - Manages the lifecycle of the inventory UI.
     - Clears previous UI elements and fetches new data from the API.
     - Instantiates UI elements for each inventory item and displays them.
   - **Usage**: Attach this script to a GameObject in your scene. Configure references to the prefab, UI holder, and information panel in the Unity editor.

2. **Inventory Object UI (`InventoryObjectUI.cs`)**:
   - **Responsibilities**:
     - Initializes the UI representation of an inventory item.
     - Sets the item icon and handles click events to show item details.
   - **Usage**: Create a prefab with this script attached, representing a single inventory item in the UI.

3. **Inventory Data and Items**:
   - **Responsibilities**:
     - Define the structure of inventory data and individual items.
     - Provide methods for adding and removing items from the inventory.
   - **Usage**: These classes are used to structure the data fetched from the API and manage it within the application.

4. **Service Container (`ServiceContainer.cs`)**:
   - **Responsibilities**:
     - Initializes and provides access to services such as the API service and image database.
     - Ensures services are ready before they are accessed.
   - **Usage**: Attach this script to a GameObject in your scene. It will manage the initialization and access to necessary services.

5. **Image Database (`ImageDataBase.cs`)**:
   - **Responsibilities**:
     - Stores and retrieves sprites based on item types.
     - Ensures the correct sprite is displayed for each inventory item.
   - **Usage**: Configure the sprite list in the Unity editor, ensuring each sprite name matches the item type.

6. **API Service (`APIService.cs`)**:
   - **Responsibilities**:
     - Handles HTTP requests to the remote API.
     - Fetches inventory data asynchronously and parses it into usable objects.
   - **Usage**: This service is initialized and used by the `ServiceContainer`. Ensure the API URL is correctly configured.

7. **Equipment and Weapon Items**:
   - **Responsibilities**:
     - Define additional properties and behaviors for specific types of inventory items (e.g., weapons with damage calculations).
   - **Usage**: Extend these classes to create new types of inventory items with specific properties and behaviors.

### How to Run

1. **Open Scene `Main`**: Double-click on the Main scene to open it.
2. **Run the Scene**: Press the Play button at the top of the Unity Editor to run the scene.
3. **Press Load**: In the Game view, locate and press the "Load" button to trigger data fetching from the API.
4. **Wait for Loading to Complete**: The system will fetch inventory data from the API and populate the UI with inventory items.
