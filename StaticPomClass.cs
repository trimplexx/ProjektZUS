using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZUS
{
    static class StaticPomClass
    {
        //string odpowiadający za połaczenie z lokalną bazą danych
        public static string connectionSting = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserRegistrationDB; Integrated Security=true;";
        // string przechowywujący nazwę użytwkonika z panelu logowania do późniejszego odwołania się w innych oknach
        public static int UserID
        { get; set; }
        public static string ImiePracownika
        { get; set; }
        public static string NaziwskoPracownika
        { get; set; }
        public static string PeselPrac
        { get; set; }
        public static int WorkerID
        { get; set; }
    }
}
