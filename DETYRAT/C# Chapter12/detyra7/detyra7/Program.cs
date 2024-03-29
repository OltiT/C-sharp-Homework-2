﻿using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Ivan\Desktop\text.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified path is invalid!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Invalid syntax!");
            }
        }
    }
}
