# VoyaQuest

VoyaQuest is a full-featured blazor web application for booking flights and exploring hotels. It offers seamless search, currency conversion, and PDF itinerary downloads by leveraging multiple external APIs.

---

## Features

- **Flight Search**: Search flights based on origin, destination, dates, and passenger details.
- **Hotel Search**: Browse hotel options based on location with filtering capabilities.
- **Currency Conversion**: Real-time conversion of prices to the user's selected currency.
- **Booking**: Download a detailed itinerary of booked flights in PDF format.
- **Error Handling**: Integrated error handling ensures smooth operation.

---

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
3. [APIs Used](#apis-used)
4. [Screenshots](#screenshots)
5. [Contributing](#contributing)
6. [License](#license)

---

## Installation

To set up VoyaQuest locally:

1. Clone the repository:
   ```bash
   git clone https://github.com/PatrickOrjieh/VoyaQuest.git
   ```
2. Navigate to the project directory:
   ```bash
   cd VoyaQuest
   ```
3. Install the dependencies:
   ```bash
	dotnet restore
   ```
4. Set up the environment variables:
   - Create a `.env` file in the root directory.
   - Add the following environment variables to the `.env` file:
	 ```env
	 AMADEUS_API_KEY=					
	 AMADEUS_API_SECRET=
     HOTEL_BEDS_API_KEY=		
	 HOTEL_BEDS_API_SECRET=
     OPEN_EXCHANGE_RATE_API_KEY=
	 ```
5. Run the application:
   ```bash
   dotnet run
   ```

---

## Usage
1. **Search Flights**: On the home page, users can input travel details like departure and arrival airports, trip type, dates, and passengers.
2. **Explore Hotels**: Users can view available hotels in their destination city and filter them by star ratings.
3. **Currency Conversion**: Users can select their preferred currency to view prices in.
4. **Book Flights**: After selecting a flight, users can book it and download a detailed itinerary in PDF format.

---

## APIs Used
- **Amadeus API**: Used for flight search.
- **Hotel Beds API**: Used for hotel search.
- **Open Exchange Rates API**: Used for currency conversion.

---

## Screenshots

### Home Page
![image](https://github.com/user-attachments/assets/bd62a953-057a-48cd-a1d6-2cf443d1439f)

### Flight Results
![image](https://github.com/user-attachments/assets/545cb857-fa2c-4b33-8ddb-6edd4a9c83f6)

---

## Contributing

If you would like to contribute to this project, please fork the repository and create a pull request. Your contributions are welcome!

---

## License

VoyaQuest is licensed under the MIT License.