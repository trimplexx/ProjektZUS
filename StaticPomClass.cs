using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZUS
{
    // Statyczna klasa pomocnicza, aby do zmiennych można było się odwołać w całym programie
    static class StaticPomClass
    {
        //string odpowiadający za połaczenie z lokalną bazą danych
        public static string connectionSting = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserRegistrationDB; Integrated Security=true;";

        // ID logującego się użytkownika
        public static int UserID
        { get; set; }

        // lista przechowywująca ID pracowników
        public static List <int> WorkerID = new List<int>();

        // Index do wskazania danego pracownika w tablicy
        public static int Index
        { get; set; }
    }
}
