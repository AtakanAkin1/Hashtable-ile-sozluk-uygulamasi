using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sozcukUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable sozcuk = new Hashtable();
            string secim;
            do
            {
                Console.Clear();
                Console.WriteLine("1- kelime ekle");
                Console.WriteLine("2- eklenmis kelimeleri goruntule");
                Console.WriteLine("3- cikis yap");
                Console.Write("Secim: ");
                secim = Console.ReadLine();
                switch(secim)
                {
                    case "1":
                        string eh;
                        do
                        {
                            Console.Clear();
                            Console.Write("Lutfen eklemek istediginiz ENG kelimeyi giriniz:");
                            string ENG = Console.ReadLine();
                            if (sozcuk.Contains(ENG))
                            {

                                Console.WriteLine("Bu sozcuk listede mevcut");
                            }
                            else
                            {
                                Console.Write("Eklemek istediginiz {0} degerinin turkce karsiligini giriniz: ", ENG);
                                string TR = Console.ReadLine();
                                sozcuk.Add(ENG, TR);
                                Console.WriteLine("ENG:{0} - TR:{1} olarak sozcuk eklenmistir.", ENG, TR);
                            }
                            Console.Clear();
                            Console.WriteLine("Kelime eklemeye devam etmek ister misiniz(E/H): ");
                            eh = Console.ReadLine();
                        } while (eh.ToUpper()=="E");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Sozcuk icerisine eklenmis kelimeler listeleniyor.");
                        foreach (DictionaryEntry item in sozcuk)
                        {
                            //Console.WriteLine(item.GetType().Name); tip ogrenme
                            Console.WriteLine("ENG: {0} TR: {1}",item.Key,item.Value);
                        }
                        Console.ReadLine();
                        break;
                }
            } while (secim!="3");
            Console.ReadKey();
        }
    }
}
