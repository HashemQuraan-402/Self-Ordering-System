# Restaurant Self-Ordering System

A Windows Forms kiosk-style ordering prototype for a restaurant. Customers can choose an order type, browse menu categories, add products to a cart, adjust quantities, review the total in Jordanian dinars, and generate an on-screen receipt.

## Features

- Take-in and take-out order selection
- Menu navigation for burgers, chicken, breakfast, fries, drinks, desserts, and kids' meals
- Popular-items screen
- Add-to-cart confirmation
- Automatic quantity increase for repeated items
- Cart item removal and quantity adjustment
- Total-price calculation in JOD
- On-screen order receipt
- Interface color customization
- Settings and social-links screen
- Optional background-audio control with a user-provided MP3 file

## Technologies

- C#
- Windows Forms
- .NET Framework 4.8
- Visual Studio
- Windows Media Player COM library for optional audio playback

## Prerequisites

- Windows 10 or later
- Visual Studio 2022 with the **.NET desktop development** workload
- .NET Framework 4.8 targeting pack
- Windows Media Player component available on the machine if optional audio is enabled

## Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/HashemQuraan-402/Self-Ordering-System.git
   ```

2. Open `Self-Ordering-System-Project/Self-Ordering-System-Project.sln` in Visual Studio.
3. Confirm that the `WMPLib` reference is available. If Visual Studio marks it as missing, add the **Windows Media Player** COM reference.
4. Select **Build > Build Solution**.
5. Press `F5` to run with debugging, or `Ctrl+F5` to run without debugging.

## Optional Audio Setup

The repository does not include an MP3 file. To enable the background-audio button:

1. Add a legally licensed file named `ukulele.mp3` to `Self-Ordering-System-Project/Resources/`.
2. Select the file in Visual Studio and set **Build Action** to `Content`.
3. Set **Copy to Output Directory** to `Copy if newer`.

Without this optional file, the application continues to work and displays a clear message when the audio button is selected.

## Typical Workflow

1. Choose **Take In** or **Take Out**.
2. Browse a menu category and select an item.
3. Confirm the item to add it to the cart.
4. Review quantities, remove unwanted items, and check the total.
5. Select **Pay** to display the receipt.

## Project Structure

```text
Self-Ordering-System/
├── Images/
├── Self-Ordering-System-Project/
│   ├── Properties/
│   ├── Resources/
│   ├── Form1.cs
│   ├── GlobalList.cs
│   ├── Item.cs
│   ├── OrderTypeScreen.cs
│   ├── frmCartScreen.cs
│   ├── frmHomeScreen.cs
│   ├── frmPopular.cs
│   ├── frmSettings.cs
│   ├── Self-Ordering-System-Project.csproj
│   └── Self-Ordering-System-Project.sln
├── .gitignore
└── README.md
```

## Data and Configuration

The cart is stored in application memory only. The project does not connect to a production database, payment gateway, or external restaurant service. Closing the application clears the current order.

## Current Scope

This repository is an educational kiosk prototype. Production concerns such as authentication, persistent orders, inventory synchronization, payment processing, logging, and automated tests are outside its current scope.

## Future Improvements

- Replace global static state with application services
- Separate UI, business, and data-access responsibilities
- Store menu items and orders in a database
- Move prices and settings into configuration
- Add unit and UI tests
- Add proper asset licensing documentation

## Asset Notice

Images are included for educational demonstration. Background audio is optional and is not included in the repository. Verify the license and attribution requirements for all assets before commercial reuse or redistribution.

## Author

**Hashem Quraan**

- [GitHub](https://github.com/HashemQuraan-402)
- [LinkedIn](https://www.linkedin.com/in/hashem-quraan-b561453ab)
