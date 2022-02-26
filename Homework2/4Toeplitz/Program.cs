namespace Toeplitz
{
    class Toeplitz
    {
        static bool CheckToeplitz(List<List<int>> matrix)
        {
            int row = matrix.Count();
            int col = matrix[0].Count();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i != row - 1 && j != col - 1) // 未到边界
                    {
                        if (matrix[i][j] != matrix[i + 1][j + 1])
                            return false;
                    }
                }
            }

            return true;
        }

        static List<List<int>> Input()
        {
            var matrix = new List<List<int>>();
            int col = -1;

            string str;

            while ((str = Console.ReadLine()) != null && str != "")
            {
                var line = new List<int>();
                foreach (var item in str.Split(' '))
                {
                    try
                    {
                        line.Add(int.Parse(item));
                    }
                    catch { }
                }
                if (col == -1)
                    col = line.Count();
                else
                {
                    if (col != line.Count())
                        throw new Exception("Invalid matrix");
                }
                matrix.Add(line);
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            var matrix = Input();
            
            Console.WriteLine(CheckToeplitz(matrix));
        }
    }
}