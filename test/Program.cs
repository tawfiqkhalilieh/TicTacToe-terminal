class Program
{
    static string check(char[,] XO)
    {
        if (XO[0,0].Equals(XO[0, 1]) && XO[0, 0].Equals(XO[0, 2])) if (!XO[0, 0].Equals(' ')) return "" + XO[0,0] + " is the winner";
        if (XO[0,0].Equals(XO[1,0]) && XO[0,0].Equals(XO[2,0])) if (!XO[0, 0].Equals(' ')) return "" + XO[0, 0] + " is the winner";
        if (XO[0,0].Equals(XO[1,1]) && XO[0,0].Equals(XO[2,2])) if (!XO[0, 0].Equals(' ')) return "" + XO[0, 0] + " is the winner";
        if (XO[0, 1].Equals(XO[1, 1]) && XO[0, 1].Equals(XO[2, 1])) if (!XO[0, 1].Equals(' ')) return "" + XO[0, 1] + " is the winner";
        if (XO[2,0].Equals(XO[2,1]) && XO[2,0].Equals(XO[2,2])) if (!XO[2,0].Equals(' ')) return "" + XO[2,0] + " is the winner";
        if (XO[0,2].Equals(XO[1,2]) && XO[0,2].Equals(XO[2,2])) if (!XO[0,2].Equals(' ')) return "" + XO[0, 2] + " is the winner";
        if (XO[2,0].Equals(XO[1,1]) && XO[2,0].Equals(XO[0,2])) if (!XO[0,2].Equals(' ')) return "" + XO[0, 2] + " is the winner";
        if (XO[1,2].Equals(XO[1,1]) && XO[1,2].Equals(XO[1,0])) if (!XO[1, 2].Equals(' ')) return "" + XO[1, 2] + " is the winner";
        if (XO[2,0].Equals(XO[2,1]) && XO[2,0].Equals(XO[2,2])) if (!XO[2,0].Equals(' ')) return "" + XO[2,0] + " is the winner";
        for(int i = 0; i < XO.GetLength(0);i++) for(int j=0;i<XO.GetLength(0);j++) if (XO[i,j].Equals(' ')) return "not ended";
        return "Draw";
    }
    static void Main()
    {
        while (true)
        {
            int s = 0;
        bool p = true;
        char[,] XO = new char[3,3];
        for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) XO[i, j] = ' ';
        for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) { if (s == 0) { Console.WriteLine(); Console.WriteLine(" ____________________________"); } Console.Write("|   " + XO[i, j] + "    |"); s++; if (s == 3) { Console.WriteLine(); Console.WriteLine(" ____________________________"); s = 0; }}
        for (int m = 0; m < 9; m++)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int pl = int.Parse(Console.ReadLine());
                while (XO[x, pl] != ' ')
                {
                    x = int.Parse(Console.ReadLine());
                    pl = int.Parse(Console.ReadLine());
                }
                if (p) { XO[x, pl] = 'x'; p = false;}
                else { XO[x, pl] = 'o'; p = true;}
                Console.Clear();
                for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) { if (s == 0) { Console.WriteLine(); Console.WriteLine(" ____________________________"); } Console.Write("|   " + XO[i, j] + "    |"); s++; if (s == 3) { Console.WriteLine(); Console.WriteLine(" ____________________________"); s = 0; } }
                if (check(XO) != "not ended") { Console.WriteLine(check(XO)); break; }

            }
            catch
            {
                Console.Clear();
                for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) { if (s == 0) { Console.WriteLine(); Console.WriteLine(" ____________________________"); } Console.Write("|   " + XO[i, j] + "    |"); s++; if (s == 3) { Console.WriteLine(); Console.WriteLine(" ____________________________"); s = 0; } }
                Console.WriteLine("Value Error !");
            }
        }
        }
    }
}