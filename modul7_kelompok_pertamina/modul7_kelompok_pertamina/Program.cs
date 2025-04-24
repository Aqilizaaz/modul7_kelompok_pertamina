using System;
using static System.Object;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pilih menu:");
        Console.WriteLine("1. Buka Data Mahasiswa");
        Console.WriteLine("2. Buka Team Members");
        Console.Write("Masukkan pilihan (1/2): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                string filePath = "D:/pertamini/modul7_kelompok_pertamina/modul7_kelompok_pertamina/modul7_kelompok_pertamina/jurnal7_1_1201210018.json";
                DataMahasiswa_1201210018 data = new DataMahasiswa_1201210018();
                data.ReadJSON(filePath);
                break;
                
            case "2":
                string filePath2 = "D:/pertamini/modul7_kelompok_pertamina/modul7_kelompok_pertamina/modul7_kelompok_pertamina/jurnal7_2_1201210018.json";
                DataTeamMember_1201210018 data2 = new DataTeamMember_1201210018 ();
                data2.ReadJSON(filePath2);
                break;

            default:
                Console.WriteLine("Pilihan tidak valid.");
                break;
        }
    }
}

public class TeamMembers_1201210005_TeguhSambadaAbrielKarisma
{
    public void DisplayTeamMembers()
    {
        Console.WriteLine("Team Members:");
        Console.WriteLine("1. Teguh Sambada");
        Console.WriteLine("2. Abriel Karisma");
    }
}
