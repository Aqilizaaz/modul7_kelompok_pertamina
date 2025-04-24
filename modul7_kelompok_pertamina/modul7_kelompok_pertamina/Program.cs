using System;
using static System.Object;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pilih menu:");
        Console.WriteLine("1. Buka Data Mahasiswa");
        Console.WriteLine("2. Buka Team Members");
        Console.WriteLine("3. Buka Glossary");
        Console.Write("Masukkan pilihan (1/3): ");

        String choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                string filePath = "C:/Users/akay/OneDrive - Telkom University/Documents/GitHub/modul7_kelompok_pertamina/modul7_kelompok_pertamina/modul7_kelompok_pertamina/jurnal7_1_1201210018.json";
                DataMahasiswa_1201210018 data = new DataMahasiswa_1201210018();
                data.ReadJSON(filePath);
                break;

            case "2":
                string filePath2 = "C:/Users/akay/OneDrive - Telkom University/Documents/GitHub/modul7_kelompok_pertamina/modul7_kelompok_pertamina/modul7_kelompok_pertamina/jurnal7_2_1201210018.json";
                DataTeamMember_1201210018 data2 = new DataTeamMember_1201210018();
                data2.ReadJSON(filePath2);
                break;

            case "3":
                string filePath3 = "C:/Users/akay/OneDrive - Telkom University/Documents/GitHub/modul7_kelompok_pertamina/modul7_kelompok_pertamina/modul7_kelompok_pertamina/jurnal7_3_1201210018.json";
                DataGlossary_1201210018 data3 = new DataGlossary_1201210018();
                data3.ReadJSON(filePath3);
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
