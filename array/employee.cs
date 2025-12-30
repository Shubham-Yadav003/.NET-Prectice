using System;
class Employee: IComparable<Employee> // its interface
{
    public int Id { get; set; }
    public string Name { get; set; }

public int CompareTo(Employee other)
    {
        return this.Id.CompareTo(other.Id);
    }

    public override string ToString()
    {
        return $"Employee ID: {Id}, {Name}";
    }
}