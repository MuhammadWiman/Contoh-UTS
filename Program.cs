using System;

namespace Tugas_UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string username;
            string type;
            string merk;
            double diskon;
            double total_diskon;
            double total;
            Console.WriteLine("www.kelompok9.com");
            Console.Write("masukan username anda = ");
            username = Console.ReadLine();

            if (username == "wiman123") {
                Console.Write("Masukan Password Anda = ");
                password = Console.ReadLine();
                if (password =="22421074") {
                    Console.WriteLine("Selamat Datang Muhammad Wiman");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. Xiaomi");
                    Console.WriteLine("2. Sony");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone Xiaomi");
                        Console.WriteLine("1. Redmi 4 : 1.200.000");
                        Console.WriteLine("2. Redmi Note 4x 1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi 4");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1200000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1200000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi Note 4x");
                            Console.WriteLine("RAM : 3 GB");
                            Console.WriteLine("ROM : 32 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Sony");
                        Console.WriteLine("1. Xperia XZ Compact  1.800.000");
                        Console.WriteLine("2. Xperia Z1 Compact  1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xperia XZ Compact");
                            Console.WriteLine("RAM : 3 GB");
                            Console.WriteLine("ROM : 32 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1800000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xperia Z1 Compact");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else if (password =="22421075") {
                    Console.WriteLine("Selamat Datang Wiman Wibisana");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. Xiaomi");
                    Console.WriteLine("2. Sony");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone Xiaomi");
                        Console.WriteLine("1. Redmi 4 : 1.200.000");
                        Console.WriteLine("2. Redmi Note 4x 1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi 4");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1200000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1200000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi Note 4x");
                            Console.WriteLine("RAM : 3 GB");
                            Console.WriteLine("ROM : 32 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Sony");
                        Console.WriteLine("1. Xperia XZ Compact  1.800.000");
                        Console.WriteLine("2. Xperia Z1 Compact  1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xperia XZ Compact");
                            Console.WriteLine("RAM : 3 GB");
                            Console.WriteLine("ROM : 32 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1800000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("***********************");
                            Console.WriteLine("Anda telah memilih Xperia Z1 Compact");
                            Console.WriteLine("RAM : 2 GB");
                            Console.WriteLine("ROM : 16 GB");
                            Console.WriteLine("***********************");
                            Console.WriteLine("****Pembelian****");
                            Console.Write("Masukan Diskon : ");
                            diskon = double.Parse(Console.ReadLine());
                            total_diskon = 1500000 * diskon;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else {
                    Console.WriteLine("Password yang anda Masukan Salah");
                }
            }
            else if (username =="sela123") {
                Console.Write("Masukan Password Anda = ");
                password = Console.ReadLine();
                if (password =="22421075") {
                    Console.WriteLine("Selamat Datang Sela Afify");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. Xiaomi");
                    Console.WriteLine("2. Sony");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone Xiaomi");
                        Console.WriteLine("1. Redmi 4 : 1.200.000");
                        Console.WriteLine("2. Redmi Note 4x 1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi 4");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1200000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1200000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi Note 4x");
                            Console.WriteLine("1. RAM : 3 GB");
                            Console.WriteLine("1. ROM : 32 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Sony");
                        Console.WriteLine("1. Xperia XZ Compact  1.800.000");
                        Console.WriteLine("2. Xperia Z1 Compact  1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xperia XZ Compact");
                            Console.WriteLine("1. RAM : 3 GB");
                            Console.WriteLine("1. ROM : 32 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1800000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xperia Z1 Compact");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.20;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else if (password =="22421076") {
                    Console.WriteLine("Selamat Datang Sela Seli");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Pilih beragam Merk Handphone");
                    Console.WriteLine("1. Xiaomi");
                    Console.WriteLine("2. Sony");
                    merk = Console.ReadLine();
                    if (merk == "1") {
                        Console.WriteLine("Pilih type Handphone Xiaomi");
                        Console.WriteLine("1. Redmi 4 : 1.200.000");
                        Console.WriteLine("2. Redmi Note 4x 1.500.000");
                        Console.Write("Masukan Pilihan type Handphone yang akan di beli : ");
                        type = Console.ReadLine();
                        if (type == "1"){
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi 4");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1200000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1200000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xiaomi Redmi Note 4x");
                            Console.WriteLine("1. RAM : 3 GB");
                            Console.WriteLine("1. ROM : 32 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                    else if (merk == "2") {
                        Console.WriteLine("Pilih type Handphone Sony");
                        Console.WriteLine("1. Xperia XZ Compact  1.800.000");
                        Console.WriteLine("2. Xperia Z1 Compact  1.500.000");
                        Console.WriteLine("Masukan Pilihan type Handphone yang akan di Beli");
                        type = Console.ReadLine();
                        if (type == "1") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xperia XZ Compact");
                            Console.WriteLine("1. RAM : 3 GB");
                            Console.WriteLine("1. ROM : 32 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1800000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1800000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                        else if (type == "2") {
                            Console.WriteLine("*******************");
                            Console.WriteLine("Anda telah memilih Xperia Z1 Compact");
                            Console.WriteLine("1. RAM : 2 GB");
                            Console.WriteLine("1. ROM : 16 GB");
                            Console.WriteLine("*******************");
                            total_diskon = 1500000 * 0.30;
                            Console.WriteLine("Anda Dapat potongan : " + total_diskon);
                            total = 1500000 - total_diskon;
                            Console.WriteLine("Harga total adalah : " + total);
                        }
                    }
                }
                else {
                    Console.WriteLine("Password yang anda Masukan Salah");
                }
            }
            else {
                Console.WriteLine("Username yang anda Masukan Salah");
            }
        }
    }
}