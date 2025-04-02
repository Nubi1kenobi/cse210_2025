using System;
class Address 
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _zipCode = "";
    private string _country = "";
    public Address(string streeAddress, string city, string state_Province, string zipCode, string country)
    {
        _streetAddress = streeAddress;
        _city = city;
        _stateProvince = state_Province;
        _zipCode = zipCode;
        _country = country;
    }
    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_zipCode}\n{_country}";
    }
}