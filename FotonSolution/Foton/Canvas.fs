module Foton.Canvas
open System.Drawing

let Canvas (width : int) height = new Bitmap(width, height)

let GetPixel (canvas: Bitmap) x y = canvas.GetPixel(x, y)
//let GetPixels (canvas: Bitmap) = 

let SetPixel (canvas: Bitmap) x y color = canvas.SetPixel(x, y, color)
//let SetPixels (canvas: Bitmap) color = 

let private GetRange x = 
    let updateState state = 
        match state with
        | state when (state <= x) -> Some(state, state + 1)
        | _ -> None
    Seq.unfold updateState 0


//let private EnumerateDimensions x y =
    