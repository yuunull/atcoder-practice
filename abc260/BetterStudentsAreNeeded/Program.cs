using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        // 入力の読み取り
        var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int N = inputs[0], X = inputs[1], Y = inputs[2], Z = inputs[3];
        var mathScores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var englishScores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        // 受験者の情報を保持するクラスのリストを作成
        List<Examinee> examinees = new List<Examinee>();
        for (int i = 0; i < N; i++)
        {
            examinees.Add(new Examinee(i + 1, mathScores[i], englishScores[i]));
        }

        // 数学の点数でソート
        var mathRanked = examinees.OrderByDescending(e => e.MathScore).ThenBy(e => e.Id).ToList();

        // 数学の点数での合格者を取得
        var mathPassed = mathRanked.Take(X).ToList();

        // 残りの受験者を取得
        var remaining = mathRanked.Skip(X).ToList();

        // 英語の点数でソート
        var englishRanked = remaining.OrderByDescending(e => e.EnglishScore).ThenBy(e => e.Id).ToList();

        // 英語の点数での合格者を取得
        var englishPassed = englishRanked.Take(Y).ToList();

        // 残りの受験者を取得
        remaining = englishRanked.Skip(Y).ToList();

        // 合計点でソート
        var totalRanked = remaining.OrderByDescending(e => e.TotalScore).ThenBy(e => e.Id).ToList();

        // 合計点での合格者を取得
        var totalPassed = totalRanked.Take(Z).ToList();

        // 結果の表示
        var result = mathPassed.Concat(englishPassed).Concat(totalPassed).OrderBy(e => e.Id).ToList();
        foreach (var r in result)
        {
            Console.WriteLine(r.Id);
        }
    }
}

class Examinee
{
    public int Id { get; set; }
    public int MathScore { get; set; }
    public int EnglishScore { get; set; }
    public int TotalScore => MathScore + EnglishScore;

    public Examinee(int id, int mathScore, int englishScore)
    {
        Id = id;
        MathScore = mathScore;
        EnglishScore = englishScore;
    }
}
