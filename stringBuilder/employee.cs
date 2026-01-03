using System;

class Employee : IComparable<Employee>
{
    public int Id { get; set; }
    public String Name { get; set; }

    public override string ToString()
    {
        return $"Employee Id {Id} Name is {Name}";
    }

    // Implement IComparable to sort by Id
    public int CompareTo(Employee other)
    {
        if (other == null) return 1;
        return this.Id.CompareTo(other.Id);
    }
}