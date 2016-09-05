module Cake.SquareLogo.Main

open System.Drawing
open System.IO

type DrawSetting =
      { FontFamily: string
        FontSize: float32
        Foreground: string
        Background: string }

let startDraw(text: string, font: Font, color: Color, back: Color) =

      let padding = 20.0f

      let textSize(drawing: Graphics) = 
            drawing.MeasureString(text, font)

      let createImage() =
            let image = new Bitmap(1,1)
            let drawing = Graphics.FromImage(image)
            let textSize = textSize drawing
            let width = textSize.Width + padding;
            new Bitmap(width |> int , width |> int)

      let createGraphics(image: Image) =
            let drawing = Graphics.FromImage(image)
            drawing.Clear(back)
            drawing.Save() |> ignore
            (drawing)

      let drawText(drawing: Graphics, size: Size) = 
            let brush = new SolidBrush(color) :> Brush
            let textSize = textSize drawing
            let y =  ((size.Height / 2) |> float32) - textSize.Height / 2.0f
            let x = padding / 2.0f
            drawing.DrawString(text, font, brush, x , y)
            drawing.Save() |> ignore

      let image = createImage()
      let size = image.Size
      use drawing = createGraphics(image)
      drawText(drawing, size)

      image

let drawText(text, output: string,  settings: DrawSetting) =
     let family = new FontFamily(settings.FontFamily)
     let font = new Font(family, settings.FontSize, FontStyle.Regular, GraphicsUnit.Pixel)
     let color = Color.FromName(settings.Foreground)
     let back = Color.FromName(settings.Background)
     use image = startDraw(text, font, color, back);

     let info = FileInfo(output)
     if not info.Directory.Exists  then info.Directory.Create()
     image.Save(info.FullName)



