using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class HanoiTower
{
    public int DiscsCount { get; private set; }
    public int MovesCount { get; private set; }
    public Stack<int> From { get; private set; }
    public Stack<int> To { get; private set; }
    public Stack<int> Auxiliary { get; private set; }
    public event EventHandler<EventArgs> MoveCompleted;

    public HanoiTower(int discs)
    {
        if (discs < 1) throw new ArgumentException("discs must be >= 1", nameof(discs));
        DiscsCount = discs;
        MovesCount = 0;
        From = new Stack<int>();
        To = new Stack<int>();
        Auxiliary = new Stack<int>();
        for (int i = discs; i >= 1; i--)
            From.Push(i);
    }

    public void Start() => Move(DiscsCount, From, To, Auxiliary);

    private void Move(int n, Stack<int> from, Stack<int> to, Stack<int> aux)
    {
        if (n <= 0) return;
        if (n == 1)
        {
            to.Push(from.Pop());
            MovesCount++;
            MoveCompleted?.Invoke(this, EventArgs.Empty);
            return;
        }

        Move(n - 1, from, aux, to);
        to.Push(from.Pop());
        MovesCount++;
        MoveCompleted?.Invoke(this, EventArgs.Empty);
        Move(n - 1, aux, to, from);
    }
}

public static class Program
{
    private const int DISCS_COUNT = 10;
    private const int DELAY_MS = 250;
    private static int _columnSize = 30;

    static void Main(string[] args)
    {
        int discs = DISCS_COUNT;
        if (args.Length > 0 && int.TryParse(args[0], out var parsed) && parsed > 0)
            discs = parsed;

        _columnSize = Math.Max(6, GetDiscWidth(discs) + 2);
        var algorithm = new HanoiTower(discs);
        algorithm.MoveCompleted += Algorithm_Visualize;
        Algorithm_Visualize(algorithm, EventArgs.Empty);
        algorithm.Start();
    }

    private static void Algorithm_Visualize(object sender, EventArgs e)
    {
        Console.Clear();
        var algorithm = (HanoiTower)sender;
        if (algorithm.DiscsCount <= 0) return;

        char[][] visualization = InitializeVisualization(algorithm);
        PrepareColumn(visualization, 1, algorithm.DiscsCount, algorithm.From);
        PrepareColumn(visualization, 2, algorithm.DiscsCount, algorithm.To);
        PrepareColumn(visualization, 3, algorithm.DiscsCount, algorithm.Auxiliary);

        Console.WriteLine(Center("FROM") + Center("TO") + Center("AUXILIARY"));
        DrawVisualization(visualization);
        Console.WriteLine();
        Console.WriteLine($"Number of moves: {algorithm.MovesCount}");
        Console.WriteLine($"Number of discs: {algorithm.DiscsCount}");
        Thread.Sleep(DELAY_MS);
    }

    private static char[][] InitializeVisualization(HanoiTower algorithm)
    {
        char[][] visualization = new char[algorithm.DiscsCount][];
        for (int y = 0; y < visualization.Length; y++)
        {
            visualization[y] = new char[_columnSize * 3];
            for (int x = 0; x < _columnSize * 3; x++)
                visualization[y][x] = ' ';
        }
        return visualization;
    }

    private static void PrepareColumn(char[][] visualization, int column, int discsCount, Stack<int> stack)
    {
        int margin = _columnSize * (column - 1);
        for (int y = 0; y < stack.Count; y++)
        {
            int size = stack.ElementAt(y);
            int row = discsCount - (stack.Count - y);
            int columnStart = margin + discsCount - size;
            int columnEnd = columnStart + GetDiscWidth(size) - 1;
            for (int x = columnStart; x <= columnEnd; x++)
                visualization[row][x] = '=';
        }
    }

    private static void DrawVisualization(char[][] visualization)
    {
        for (int y = 0; y < visualization.Length; y++)
            Console.WriteLine(visualization[y]);
    }

    private static string Center(string text)
    {
        int margin = (_columnSize - text.Length) / 2;
        return text.PadLeft(margin + text.Length).PadRight(_columnSize);
    }

    private static int GetDiscWidth(int size) => 2 * size - 1;
}

