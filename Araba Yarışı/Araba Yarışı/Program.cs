using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false; // Konsol imlecini gizle
        int finishLine = 50; // Bitiş çizgisi mesafesi

        // Arabaların pozisyonları
        int player1Position = 0;
        int player2Position = 0;

        Console.WriteLine("=== ARABA YARIŞI ===");
        Console.WriteLine("1. Oyuncu 1: 'A' tuşu ile kontrol eder.");
        Console.WriteLine("2. Oyuncu 2: 'L' tuşu ile kontrol eder.");
        Console.WriteLine("Hazır mısınız? Başlamak için bir tuşa basın...");
        Console.ReadKey();

        Console.Clear();

        // Oyun döngüsü
        while (true)
        {
            DrawTrack(player1Position, player2Position, finishLine);

            // Oyuncu 1 hareketi
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.A)
            {
                player1Position++;
            }

            // Oyuncu 2 hareketi
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.L)
            {
                player2Position++;
            }

            // Kazanma kontrolü
            if (player1Position >= finishLine)
            {
                Console.Clear();
                Console.WriteLine("Tebrikler! Oyuncu 1 yarışı KAZANDI! 🏆");
                break;
            }
            else if (player2Position >= finishLine)
            {
                Console.Clear();
                Console.WriteLine("Tebrikler! Oyuncu 2 yarışı KAZANDI! 🏆");
                break;
            }

            Thread.Sleep(100); // Oyunu yavaşlatmak için
        }

        Console.WriteLine("Oyunu kapatmak için bir tuşa basın...");
        Console.ReadKey();
    }

    static void DrawTrack(int player1Position, int player2Position, int finishLine)
    {
        Console.Clear();

        // Pist durumu
        Console.WriteLine(new string('-', finishLine) + "| BİTİŞ");

        // Oyuncu 1 arabası
        Console.SetCursorPosition(player1Position, 1);
        Console.Write("===🚗==="); // Oyuncu 1'in arabası

        // Oyuncu 2 arabası
        Console.SetCursorPosition(player2Position, 2);
        Console.Write("===🚙==="); // Oyuncu 2'nin arabası
    }
}
