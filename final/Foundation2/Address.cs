class Address
{
    public string Street { get; }
    public string City { get; }
    public string StateOrProvince { get; }
    public string Country { get; }

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}

// class Address
// {
//     private string _streetAddress = "default";

//     private string _cityName = "default";
    
//     private string _stateName = "default";

//     private string _countryName = "default";

//     public string GetStreetAddress()
//     {
//         return _streetAddress;
//     }

//     public void SetStreetAddress(string streetAddress)
//     {
//         _streetAddress = streetAddress;
//     }

//     public string GetCityName()
//     {
//         return _cityName;
//     }

//     public void SetCityName(string cityName)
//     {
//         _cityName = cityName;
//     }

//     public string GetStateName()
//     {
//         return _stateName;
//     }

//     public void SetStateName(string stateName)
//     {
//         _stateName = stateName;
//     }

//     public string GetCountryName()
//     {
//         return _countryName;
//     }

//     public void SetCountryName(string countryName)
//     {
//         _countryName = countryName;
//     }

//     public void DisplayCustomerAddress()
//     {
//         Console.WriteLine(_streetAddress);
//         Console.WriteLine($"{_cityName}, {_stateName}");
//         Console.WriteLine(_countryName);
//     }

//     public void CountryCheck()
//     {
//         if (_countryName == "USA")
//         {
//             Console.WriteLine("Customer lives in the USA.");
//         }
//         else if (_countryName != "USA")
//         {
//             Console.WriteLine("Customer does not live in the USA.");
//         }
//         else
//         {
//             Console.WriteLine("Country of origin NOT found.");
//         }
//     }
// }