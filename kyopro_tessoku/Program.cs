using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("クラス名を指定してください。");
            return;
        }

        string className = args[0];
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type type = assembly.GetType(className);

        if (type == null)
        {
            Console.WriteLine($"指定されたクラス '{className}' が見つかりません。");
            return;
        }

        // クラスのインスタンスを作成
        object instance = Activator.CreateInstance(type);

        // クラスのメソッドを実行
        MethodInfo method = type.GetMethod("Run");
        if (method != null)
        {
            method.Invoke(instance, null);
        }
        else
        {
            Console.WriteLine($"クラス '{className}' に 'Run' メソッドが見つかりません。");
        }
    }
}