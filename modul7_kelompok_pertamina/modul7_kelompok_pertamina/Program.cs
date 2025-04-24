using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "jurnal7_1_1201210018.json"; 

        DataMahasiswa_1201210018 data = new DataMahasiswa_1201210018();
        data.ReadJSON(filePath);
    }
}
