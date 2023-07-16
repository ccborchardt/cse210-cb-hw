using System;
class Address
{
    private string street;
    private string city;
    private string stateProvince;
    private string country;

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string StateProvince
    {
        get { return stateProvince; }
        set { stateProvince = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public string GetFormattedAddress()
    {
        return $"Street: {Street}\nCity: {City}\nState/Province: {StateProvince}\nCountry: {Country}";
    }
}