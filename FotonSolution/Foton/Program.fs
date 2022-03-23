module Foton.Program

open System
open System.Windows.Forms

[<EntryPoint>]
let main args =
    let f = new Form()
    f.Controls.Add(new Label(Text="Hello world!"))
    Application.Run(f)
    0
