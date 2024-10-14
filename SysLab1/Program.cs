void Method() { for (int i = 0; i <= 50; i++) Console.WriteLine(i); }
Thread thread = new Thread(Method);
thread.Start();