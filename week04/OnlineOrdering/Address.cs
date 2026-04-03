using System;
using System.Collections.Concurrent;

public class Address

{
    private string _street;
    private string _city;
    private string _states;
    private string _country;



    public Address(string street, string city, string states, string country)
    {
        _street = street;
        _city = city;
        _states = states;
        _country = country;
    }
    public bool IsInUsa()
    {
        if (string.IsNullOrWhiteSpace(_country))
            return false;

        string country = _country.ToUpper();
        return country == "USA" || country == "UNITED STATES";
    }

    public string GetFullAddress()
    {
        return $"{_street} {_city}, {_states}{_country}";
    }
}