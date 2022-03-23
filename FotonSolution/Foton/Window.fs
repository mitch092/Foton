module Foton.Window
open System.Drawing
open System.Windows.Forms
open System.Drawing

let Update (picture : PictureBox) (canvas : Bitmap) = picture.Image <- canvas

let Init (canvas : Bitmap) = 
    let size = new Size(canvas.Width, canvas.Height)

    let form = new Form()
    form.ClientSize <- size

    let pictureBox = new PictureBox()
    pictureBox.ClientSize <- size
    pictureBox.SizeMode <- PictureBoxSizeMode.StretchImage
    Update pictureBox canvas

    form.Controls.Add(pictureBox)
    Application.Run(form)
    pictureBox
