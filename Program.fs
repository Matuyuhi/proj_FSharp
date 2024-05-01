// 変数宣言
let message = "Hello, F#"

// 関数定義
let square x = x * x

// パイプライン操作
let squaredResults = [1;2;3;4;5] 
                    |> List.map square 

// タプル
let person = ("John", 32)

// レコード型
type Student = { Name : string; Age : int }
let student = { Name = "Amy"; Age = 20 }

printfn $"{student.Name} {student.Age}"