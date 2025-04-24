using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}

public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }
}

public class DataMahasiswa_1201210018
{
    public void ReadJSON(string filePath)
    {
     
        string jsonContent = File.ReadAllText(filePath);
        Person person = JsonSerializer.Deserialize<Person>(jsonContent);
        
        Console.WriteLine("=== DATA MAHASISWA ===");
        Console.WriteLine($"Nama Lengkap : {person.firstName} {person.lastName}");
        Console.WriteLine($"Jenis Kelamin: {person.gender}");
        Console.WriteLine($"Usia         : {person.age} tahun");
        Console.WriteLine("Alamat:");
        Console.WriteLine($"  Jalan : {person.address.streetAddress}");
        Console.WriteLine($"  Kota  : {person.address.city}");
        Console.WriteLine($"  Prov  : {person.address.state}");
        Console.WriteLine("Mata Kuliah:");
        foreach (var course in person.courses)
        {
            Console.WriteLine($"  - {course.code} | {course.name}");
        }
    }
}
