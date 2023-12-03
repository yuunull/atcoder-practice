using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Program
{
    /// <summary>
    ///  Bit全探索
    ///  ・最初のループで1をnビットシフトする。これにより2のn乗を表現できる
    ///  ・二つ目のループでiに対して各ビットをチェックする。
    ///  　a）現在のビットが1の場合"）"を追加しデクリメントする
    ///  　b）現在のビットが0の場合"（"を追加しインクリメントする
    ///  ・途中でanswerCountが負になったらダメ
    ///  ・最後にanswerCountが0になっていないとダメ
    ///  ・上記2つをクリアした場合、正しいカッコ
    /// </summary>
	static void Main()
	{
        int n = int.Parse(Console.ReadLine());
        var answers = new StringBuilder();
    
        for(long i = 0; i < (1 << n); i++)
        {
            var answer = new StringBuilder();
            bool isAnswer = true;
            int answerCount = 0;
            
            for(long j = n - 1; j >= 0; j--)
            {
                if((i & (1<<(int)j)) != 0)
                {
                    answer.Append(")");
                    answerCount--;
                    if(answerCount < 0)
                    {
                        isAnswer = false;
                        break;
                    }
                }
                else
                {
                    answer.Append("(");
                    answerCount++;
                }
            }

            if(answerCount == 0 && isAnswer)
            {
                answers.AppendLine(answer.ToString());
            }
        }

        Console.Write(answers);
	}
}