using System;

public class Address 
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    public string GetStreet() => _street;
    public string GetCity() => _city;
    public string GetState() => _state;
    public string GetCountry() => _country;

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}