            for (int row = 1; row < 4; row++)
                {

                    Console.Write(new string('#', (D + 1) / row) + '\\');

                    Console.WriteLine();

                }

            Console.WriteLine(new string('.', (width - D - 2) / 2) + 'X' + (new string('#', D)) + 'X' + (new string('.', (width - D - 2) / 2)));

            Console.WriteLine(new string('.', (width - D - 2)/2) + 'X' + (new string ('#', D)) + 'X' + (new string('.', (width - D -2)/2)));

                Console.WriteLine();
     
